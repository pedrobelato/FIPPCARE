using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIPPCARE.Controle;
using FIPPCARE.Modelo;
using FIPPCARE.Persistencia;

//Yuri Junior Saito 261821148
//Matheus Ferreira Mioto 261821113
//Pedro Henrique Oliveira Belato 261821091

namespace FIPPCARE.Visao
{
    public partial class FCadastro : Form, IObservado
    {
        //TitularBD cpfs = new TitularBD();
        private List<IObservador> listaObservadores = new List<IObservador>();
        string acao = "N";
        public FCadastro()
        {
            InitializeComponent();
        }

        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach(IObservador observador in listaObservadores)
            {
                if(acao == "P")
                {
                    observador.notificar(acao, tbPesqNome.Text);
                }
                else
                {
                    observador.notificar(acao, tbCPF.Text,
                                               tbNome.Text,
                                               dtDataNasc.Value,
                                               cbEstadoCivil.Text,
                                               tbEmail.Text,
                                               tbFixo.Text,
                                               tbCelular.Text,
                                               tbCidade.Text,
                                               tbEndereco.Text,
                                               cbUF.Text,
                                               cbSexo.Text,
                                               cbModalidade.SelectedItem);
                }

            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            switch (acao)
            {
                case "A":
                    if (MessageBox.Show("Os dados serão alterados, deseja continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        notificarObservadores();
                    }
                    else
                        btCancelar.PerformClick();
                    break;

                case "E":
                    if (MessageBox.Show("Todos os dados seram apagados, deseja continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        notificarObservadores();
                    }
                    else
                        btCancelar.PerformClick();
                    break;

                case "I":
                    if (validar())
                    {
                        notificarObservadores();
                    }
                    break;
                default:
                    notificarObservadores();
                    tbCPF.Text = "";
                    tbNome.Text = "";
                    tbEmail.Text = "";
                    dtDataNasc.Value = DateTime.Now;
                    cbEstadoCivil.SelectedIndex = -1;
                    cbModalidade.SelectedIndex = 1;
                    cbSexo.SelectedIndex = -1;
                    cbUF.SelectedIndex = -1;
                    tbCelular.Text = "";
                    tbFixo.Text = "";
                    tbEndereco.Text = "";
                    tbCidade.Text = "";

                    btNovo.Enabled = true;
                    btPesquisar.Enabled = true;
                    break;
            }
        }

        
        private bool validar()
        {
            if(tbCPF.Text == "" || tbCPF.Text.Length > 14  /*|| cpfs.consulta(tbCPF.Text.ToString()) != null*/)
            {
                MessageBox.Show("Digite um CPF valido", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(tbNome.Text == "")
            {
                MessageBox.Show("Digite um nome", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(dtDataNasc.Value > DateTime.Now)
            {
                MessageBox.Show("Data de nascimento inválida", "Data de nascimento inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cbEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um estado civil", "Estado civil inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um sexo", " Sexo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(tbEndereco.Text == "")
            {
                MessageBox.Show("Digite um endereço", "Endereço inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(tbCidade.Text == "")
            {
                MessageBox.Show("Digite uma cidade", "Cidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cbUF.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma UF", "UF inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cbModalidade.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um plano", "Plano inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            acao = "I";
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btPesquisar.Enabled = false;
            tbCelular.Clear();
            tbNome.Clear();
            tbCidade.Clear();
            tbCPF.Clear();
            tbEmail.Clear();
            tbEndereco.Clear();
            tbFixo.Clear();
            dinamica(acao);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            acao = "A";

            dinamica(acao);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            acao = "E";
            btNovo.Enabled = false;
            btAlterar.Enabled = false;
            btPesquisar.Enabled = false;
            dinamica(acao);
        }

        private void btPesq_Click(object sender, EventArgs e)
        {
            acao = "P";
            notificarObservadores();
        }

        private void dinamica(string acao)
        {
            tbCPF.Enabled = "I".IndexOf(acao) >= 0;
            tbNome.Enabled = "I".IndexOf(acao) >= 0;
            dtDataNasc.Enabled = "I".IndexOf(acao) >= 0;
            cbEstadoCivil.Enabled = "IA".IndexOf(acao) >= 0;
            cbSexo.Enabled = "I".IndexOf(acao) >= 0;
            tbEndereco.Enabled = "IA".IndexOf(acao) >= 0;
            tbCidade.Enabled = "IA".IndexOf(acao) >= 0;
            cbUF.Enabled = "IA".IndexOf(acao) >= 0;
            tbEmail.Enabled = "IA".IndexOf(acao) >= 0;
            tbFixo.Enabled = "IA".IndexOf(acao) >= 0;
            tbCelular.Enabled = "IA".IndexOf(acao) >= 0;
            cbModalidade.Enabled = "IA".IndexOf(acao) >= 0;
            //dtVigInicial.Enabled = "IA".IndexOf(acao) >= 0;
            //dtVigFinal.Enabled = "IA".IndexOf(acao) >= 0;

            btExcluir.Enabled = "C".IndexOf(acao) >= 0;
            btAlterar.Enabled = "C".IndexOf(acao) >= 0;
            btConfirmar.Enabled = "IAE".IndexOf(acao) >= 0;
            btCancelar.Enabled = "IAEC".IndexOf(acao) >= 0;
        }

        private void dgvTabela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            acao = "C";
            btNovo.Enabled = false;
            btPesquisar.Enabled = false;
            dinamica(acao);
            if (!dgvTabela.SelectedRows[0].IsNewRow)
            {
                DataGridViewRow linha = dgvTabela.SelectedRows[0];
                tbCPF.Text = linha.Cells[0].Value.ToString();
                tbNome.Text = linha.Cells[1].Value.ToString();
                dtDataNasc.Value = (DateTime)linha.Cells[2].Value;
                cbEstadoCivil.SelectedItem = linha.Cells[3].Value;
                cbSexo.SelectedItem = linha.Cells[10].Value;
                cbModalidade.SelectedValue= linha.Cells[12].Value;
                tbEmail.Text = linha.Cells[4].Value.ToString();
                tbCelular.Text = linha.Cells[6].Value.ToString();
                tbFixo.Text = linha.Cells[5].Value.ToString();
                tbEndereco.Text = linha.Cells[8].Value.ToString();
                tbCidade.Text = linha.Cells[7].Value.ToString();
                cbUF.SelectedItem = linha.Cells[9].Value;

                tabCadastro.SelectedTab = tabCadastro.TabPages[0];  
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            tbCPF.Text = "";
            tbNome.Text = "";
            tbEmail.Text = "";
            dtDataNasc.Value = DateTime.Now;
            cbEstadoCivil.SelectedIndex = -1;
            cbModalidade.SelectedIndex = 1;
            cbSexo.SelectedIndex = -1;
            cbUF.SelectedIndex = -1;
            tbCelular.Text = "";
            tbFixo.Text = "";
            tbEndereco.Text = "";
            tbCidade.Text = "";

            btNovo.Enabled = true;
            btPesquisar.Enabled = true;
            btCancelar.Enabled = false;
            btConfirmar.Enabled = false;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            tabCadastro.SelectedTab = tabCadastro.TabPages[1];
        }

        private void cbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Plano atual = (Plano)cbModalidade.SelectedItem;
            dtVigFinal.Value = atual.Vigencia_fim;
            dtVigInicial.Value = atual.Vigencia_ini;
        }

        private void FCadastro_Load(object sender, EventArgs e)
        {

            this.visualizador.RefreshReport();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            if(cbRelatorios.SelectedIndex == 0)
            {
                acao = "RTC";
                notificarObservadores();
            }
            else if(cbRelatorios.SelectedIndex == 1)
            {
                acao = "RCA";
                notificarObservadores();
            }

        }
    }
}
