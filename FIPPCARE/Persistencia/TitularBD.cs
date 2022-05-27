using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIPPCARE.Modelo;

namespace FIPPCARE.Persistencia
{
    class TitularBD
    {
        private Banco BancoDeDados;

        public TitularBD(Banco banco)
        {
            this.BancoDeDados = banco;
           
        }

        public Titular consulta1(string cpfTitular)
        {
            string sql = "Select * from TITULAR where CPF_TIT = @cpf";
            DataTable dados;
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteQuery(sql, out dados, "@cpf", cpfTitular);
            if (dados.Rows.Count > 0)
            {
                PlanoBD planoBD = new PlanoBD(this.BancoDeDados);
                Plano planoTitular = planoBD.consulta(Convert.ToInt32(dados.Rows[0][11].ToString()));
                Titular resultadoTitular = new Titular(    dados.Rows[0][0].ToString(),
                                                           dados.Rows[0][1].ToString(),
                                                           Convert.ToDateTime(dados.Rows[0][2]),
                                                           dados.Rows[0][3].ToString(),
                                                           dados.Rows[0][4].ToString(),
                                                           dados.Rows[0][5].ToString(),
                                                           dados.Rows[0][6].ToString(),
                                                           dados.Rows[0][7].ToString(),
                                                           dados.Rows[0][8].ToString(),
                                                           dados.Rows[0][9].ToString(),
                                                           dados.Rows[0][10].ToString(),
                                                           planoTitular);
                return resultadoTitular;
            }
            else
                return null;
        } 

        public void incluir(Titular titular)
        {
            this.BancoDeDados.Conecta();
            string sql = "insert into TITULAR(CPF_TIT, NOME, DT_NASC, ESTADO_CIVIL, EMAIL, TELEFONE, CELULAR, CIDADE, ENDERECO, UF, SEXO, CODIGO_PLANO) values(@cpf, @nome, @data, @estadocivil, @email, @telefone, @celular, @cidade, @endereco, @uf, @sexo, @codigo_plano)";
            this.BancoDeDados.ExecuteNonQuery(sql,
                                              "@cpf", titular.Cpf_tit,
                                              "@nome", titular.Nome,
                                              "@data", titular.Dt_nasc,
                                              "@estadocivil", titular.EstadoCivil,
                                              "@email", titular.Email,
                                              "@telefone", titular.Telefone,
                                              "@celular", titular.Celular,
                                              "@cidade", titular.Cidade,
                                              "@endereco", titular.Endereco,
                                              "@uf", titular.Uf,
                                              "@sexo", titular.Sexo,
                                              "@codigo_plano", titular.Plano.Codigo);
            this.BancoDeDados.Desconecta();
        }

        public void alterar(Titular titular)
        {
            string sql = "update TITULAR set NOME = @nome, DT_NASC = @data, ESTADO_CIVIL = @estadocivil, EMAIL = @email , TELEFONE = @telefone, CELULAR = @celular, CIDADE = @cidade, ENDERECO = @endereco, UF = @uf, SEXO = @sexo, CODIGO_PLANO = @codigo_plano where CPF_TIT = @cpf";
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteNonQuery(sql,
                      "@cpf", titular.Cpf_tit,
                      "@nome", titular.Nome,
                      "@data", titular.Dt_nasc,
                      "@estadocivil", titular.EstadoCivil,
                      "@email", titular.Email,
                      "@telefone", titular.Telefone,
                      "@celular", titular.Celular,
                      "@cidade", titular.Cidade,
                      "@endereco", titular.Endereco,
                      "@uf", titular.Uf,
                      "@sexo", titular.Sexo,
                      "@codigo_plano", titular.Plano.Codigo);
            this.BancoDeDados.Desconecta();
        }

        /*public void exluir(Titular titular)
        {
            string sql = "delete from TITULAR where CPF_TIT = @cpf";
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteNonQuery(sql, "@cpf", titular.Cpf_tit);
            this.BancoDeDados.Desconecta();
        }*/

        public void excluir(string cpf)
        {
            string sql = "delete from TITULAR where CPF_TIT = @cpf";
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteNonQuery(sql, "@cpf", cpf);
            this.BancoDeDados.Desconecta();
        }

        public List<Titular> consulta(string termo)
        {
            string sql = "Select * from TITULAR where NOME like @termo";
            DataTable dados;
            this.BancoDeDados.Conecta();
            this.BancoDeDados.ExecuteQuery(sql, out dados, "@termo", "%" + termo + "%");
            this.BancoDeDados.Desconecta();
            List <Titular> titulares = new List<Titular>();
            for (int i = 0; i < dados.Rows.Count; i++)
            {
                PlanoBD planoBD = new PlanoBD(this.BancoDeDados);
                Plano planoTitular = planoBD.consulta(Convert.ToInt32(dados.Rows[i][11].ToString()));
                DataRow linha = dados.Rows[i];
                Titular titular = new Titular(dados.Rows[i][0].ToString(),
                                              dados.Rows[i][1].ToString(),
                                              Convert.ToDateTime(dados.Rows[i][2]),
                                              dados.Rows[i][4].ToString(),
                                              dados.Rows[i][3].ToString(),
                                              dados.Rows[i][5].ToString(),
                                              dados.Rows[i][6].ToString(),
                                              dados.Rows[i][7].ToString(),
                                              dados.Rows[i][8].ToString(),
                                              dados.Rows[i][9].ToString(),
                                              dados.Rows[i][10].ToString(),
                                              planoTitular);
                titulares.Add(titular);
            }
            return titulares;
        }

    }
}
