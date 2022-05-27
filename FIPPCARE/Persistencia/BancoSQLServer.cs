using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPPCARE.Persistencia
{
    public class BancoSQLServer: Banco
    {
        private String strcon = @"DataSource=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pedro\Desktop\FIPPCARE\FIPPCARE\FIPPCARE\Banco\BDD.mdf;IntegratedSecurity=True;ConnectTimeout=30";

        private SqlConnection con = null;
        private SqlTransaction trans = null;

        public override bool Conecta()
        {
            bool resultado = false;
            try
            {
                con = new SqlConnection(strcon);
                con.Open();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro conexão" + e.Message);
            }
            return resultado;
        }

        public override void Desconecta()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
                con = null;
            }
        }

        public override void BeginTransaction()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
                trans = con.BeginTransaction();
        }

        public override void CommitTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Commit();
                trans = null;
            }
        }

        public override void RollbackTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Rollback();
                trans = null;
            }
        }

        public override bool ExecuteQuery(String sql, out DataTable dt, params Object[] parametros)
        {
            dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro execute query" + e.Message);
                return false;
            }
        }

        public override bool ExecuteNonQuery(String sql, params Object[] parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro execute nonquery" + e.Message);
                return false;
            }
        }

        public override int GetIdentity()
        {
            SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", con);
            object o = cmd.ExecuteScalar();
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
    }
}

