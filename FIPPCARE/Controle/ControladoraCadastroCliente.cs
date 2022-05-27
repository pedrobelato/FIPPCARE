using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIPPCARE.Persistencia;
using FIPPCARE.Modelo;
using FIPPCARE.Visao;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Reporting.WinForms;

namespace FIPPCARE.Controle
{
    class ControladoraCadastroCliente : IObservador
    {
        private static ControladoraCadastroCliente instancia = null;
        private static object trava = new object();
        private Banco bancoDeDados;
        private Titular titularAtivo;
        FCadastro telaCadastroTitular;
        public static ControladoraCadastroCliente obterInstancia()
        {
            lock (trava)
            {
                if (instancia == null)
                {
                    instancia = new ControladoraCadastroCliente(TIPO_BD.SQLSERVER);
                }
                return instancia;
            }
        }

        public void mostrarTelaCadastroCliente()
        {
            PlanoBD planoBD = new PlanoBD(this.bancoDeDados);
            telaCadastroTitular = new FCadastro();
            telaCadastroTitular.adicionarObservadores(this);
            telaCadastroTitular.cbModalidade.DataSource = planoBD.consulta("");

            telaCadastroTitular.cbModalidade.DisplayMember = "Descricao";
            telaCadastroTitular.cbModalidade.ValueMember = "Codigo";
            telaCadastroTitular.ShowDialog();
        }

        public void ControladoraCadastroClientes(TIPO_BD tipoDeBanco)
        {
            if (tipoDeBanco == TIPO_BD.SQLSERVER)
            {
                bancoDeDados = new BancoSQLServer();
            }
        }

        private ControladoraCadastroCliente(TIPO_BD tipoDeBanco)
        {
            if(tipoDeBanco == TIPO_BD.SQLSERVER)
            {
                bancoDeDados = new BancoSQLServer();
            }
        }

        public void notificar(string acao, params object[] parametros)
        {
            ReportParameter[] paramRel = new ReportParameter[1];
            paramRel[0] = new ReportParameter("usuario", "Fulano");
            TitularBD titBD = new TitularBD(bancoDeDados);
            switch (acao)
            {
                case "I":
                    if(titBD.consulta1(parametros[0].ToString()) == null)
                    {
                        titularAtivo = new Titular(parametros[0].ToString(),
                                                   parametros[1].ToString(),
                                                   (DateTime)parametros[2],
                                                   parametros[4].ToString(),
                                                   parametros[3].ToString(),
                                                   parametros[5].ToString(),
                                                   parametros[6].ToString(),
                                                   parametros[7].ToString(),
                                                   parametros[8].ToString(),
                                                   parametros[9].ToString(),
                                                   parametros[10].ToString(),
                                                   (Plano)parametros[11]);
                        titBD.incluir(titularAtivo);
                        telaCadastroTitular.lbNotificar.Text = "Cliente cadastrado com sucesso";
                        Task.Delay(1500).Wait();
                        telaCadastroTitular.lbNotificar.Text = "";
                    }
                    else
                    {
                        telaCadastroTitular.lbNotificar.Text = "Titular com o CPF '"+parametros[0].ToString()+"' já existente";
                        Task.Delay(1500).Wait();
                        telaCadastroTitular.lbNotificar.Text = "";
                        //telaCadastroTitular.btCancelar.PerformClick();
                        telaCadastroTitular.tbCPF.Text = "";
                    }

                    break;

                case "A":
                    titularAtivo = new Titular(parametros[0].ToString(),
                                               parametros[1].ToString(),
                                               (DateTime)parametros[2],
                                               parametros[4].ToString(),
                                               parametros[3].ToString(),
                                               parametros[5].ToString(),
                                               parametros[6].ToString(),
                                               parametros[7].ToString(),
                                               parametros[8].ToString(),
                                               parametros[9].ToString(),
                                               parametros[10].ToString(),
                                               (Plano)parametros[11]);
                    titBD.alterar(titularAtivo);
                    telaCadastroTitular.lbNotificar.Text = "Dados alterados com sucesso";
                    Task.Delay(1500).Wait();
                    telaCadastroTitular.lbNotificar.Text = "";
                    break;

                case "E":
                    titBD.excluir(parametros[0].ToString());
                    titularAtivo = null;
                    telaCadastroTitular.lbNotificar.Text = "Dados excluídos com sucesso";
                    Task.Delay(1500).Wait();
                    telaCadastroTitular.lbNotificar.Text = "";
                    break;

                case "P":
                    DataTable dtTitulares = new DataTable();
                    dtTitulares.Columns.Add("cpf_tit");
                    dtTitulares.Columns.Add("nome");
                    dtTitulares.Columns.Add("dt_nasc", typeof(DateTime));
                    dtTitulares.Columns.Add("estadoCivil");
                    dtTitulares.Columns.Add("email");
                    dtTitulares.Columns.Add("telefone");
                    dtTitulares.Columns.Add("celular");
                    dtTitulares.Columns.Add("cidade");
                    dtTitulares.Columns.Add("endereco");
                    dtTitulares.Columns.Add("uf");
                    dtTitulares.Columns.Add("sexo");
                    dtTitulares.Columns.Add("plano", typeof(Plano));
                    dtTitulares.Columns.Add("CODIGO", typeof(int));
                    foreach(Titular titular in titBD.consulta(parametros[0].ToString()))
                    {
                        DataRow linha = dtTitulares.NewRow();
                        linha["cpf_tit"] = titular.Cpf_tit;
                        linha["nome"] = titular.Nome;
                        linha["dt_nasc"] = titular.Dt_nasc;
                        linha["estadoCivil"] = titular.EstadoCivil;
                        linha["sexo"] = titular.Sexo;
                        linha["plano"] = titular.Plano;
                        linha["email"] = titular.Email;
                        linha["celular"] = titular.Celular;
                        linha["telefone"] = titular.Telefone;
                        linha["endereco"] = titular.Endereco;
                        linha["cidade"] = titular.Cidade;
                        linha["uf"] = titular.Uf;                        
                        linha["CODIGO"] = titular.Plano.Codigo;

                        dtTitulares.Rows.Add(linha);
                    }
                    telaCadastroTitular.dgvTabela.DataSource = dtTitulares;
                    break;

                case "RTC":
                    processaRelatorio(telaCadastroTitular.visualizador,
                                      @"..\..\Relatorios\RelatorioSimples.rdlc",
                                      "DSClientes", titBD.consulta(""), paramRel);
                    break;

                case "RCA":
                    processaRelatorio(telaCadastroTitular.visualizador,
                                      @"..\..\Relatorios\RelatorioClienteAgrupadoPlano.rdlc",
                                      "DSClientes", titBD.consulta(""), paramRel);
                    break;
                default:
                    break;
            }
        }

        public void processaRelatorio(ReportViewer visualizador, string caminhoArquivoRelatorio, string nomeFonteDeDados, List<Titular> dados, ReportParameter[] parametros)
        {
            visualizador.Reset();
            visualizador.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource(nomeFonteDeDados,dados);
            visualizador.LocalReport.DataSources.Add(rds);
            visualizador.LocalReport.ReportPath = caminhoArquivoRelatorio;
            if (parametros != null)
            {
                visualizador.LocalReport.SetParameters(parametros);
            }
            visualizador.RefreshReport();
        }
        public enum TIPO_BD { SQLSERVER, ORACLE, MYSQL, FIREBIRD }
    }
}
