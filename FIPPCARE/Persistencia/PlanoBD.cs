using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIPPCARE.Modelo;

namespace FIPPCARE.Persistencia
{
    class PlanoBD
    {
        private Banco BancoDeDados;
        public PlanoBD(Banco banco)
        {
            this.BancoDeDados = banco;
        }

        public void incluir(Plano plano)
        {
            string sql = "insert into PLANO_SAUDE(DESCRICAO, VIGENCIA_INI, VIGENCIA_FIM) values(@descricao, @vigencia_ini, @vigencia_fim)";
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteNonQuery(sql,"@descricao", plano.Descricao, "@vigencia_ini", plano.Vigencia_ini, "@vigencia_fim", plano.Vigencia_fim);
            this.BancoDeDados.Desconecta();
        }

        public void alterar(Plano plano)
        {
            string sql = "update PLANO_SAUDE set DESCRICAO = @descricao, VIGENCIA_INI = @vigencia_ini, VIGENCIA_FIM = @vigencia_fim where CODIGO = @codigo ";
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteNonQuery(sql, "@descricao", plano.Descricao, "@vigencia_ini", plano.Vigencia_ini, "@vigencia_fim", plano.Vigencia_fim, "@codigo", plano.Codigo);
            this.BancoDeDados.Desconecta();
        }

        public void excluir(Plano plano)
        {
            string sql = "delete from PLANO_SAUDE where CODIGO = @codigo";
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteNonQuery(sql,"@codigo", plano.Codigo);
            this.BancoDeDados.Desconecta();
        }


        public Plano consulta(int codigo)
        {
            string sql = "Select * from PLANO_SAUDE where CODIGO = @codigo";
            DataTable dados;
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteQuery(sql, out dados, "@codigo", codigo);
            if (dados.Rows.Count > 0)
            {
                Plano resultadoPlano = new Plano(Convert.ToInt32(dados.Rows[0][0].ToString()),
                                                 dados.Rows[0][1].ToString(),
                                                 Convert.ToDateTime(dados.Rows[0][2]),
                                                 Convert.ToDateTime(dados.Rows[0][3]));
                return resultadoPlano;
            }
            else
                return null;
        }

        public List<Plano> consulta(string termo)
        {
            string sql = "Select * from PLANO_SAUDE where DESCRICAO like @termo order by DESCRICAO";
            DataTable dados;
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteQuery(sql, out dados, "@termo", "%" + termo + "%");
            this.BancoDeDados.Desconecta();
            List<Plano> planos = new List<Plano>();
            for(int i=0; i<dados.Rows.Count; i++)
            {
                DataRow linha = dados.Rows[i];
                Plano plano = new Plano(Convert.ToInt32(linha[0].ToString()), linha[1].ToString(), Convert.ToDateTime(linha[2]), Convert.ToDateTime(linha[3]));
                planos.Add(plano);
            }
            return planos;
        }

    }
}
