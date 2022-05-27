namespace FIPPCARE.Visao
{
    partial class FCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pesquisa = new System.Windows.Forms.TabPage();
            this.btPesq = new System.Windows.Forms.Button();
            this.Pesq = new System.Windows.Forms.Label();
            this.tbPesqNome = new System.Windows.Forms.TextBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.tabCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPlano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCodigoPlano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastro = new System.Windows.Forms.TabPage();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.uf = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.sexo = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.estadocivil = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb
                = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.celular = new System.Windows.Forms.Label();
            this.tbFixo = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.dtVigFinal = new System.Windows.Forms.DateTimePicker();
            this.dtVigInicial = new System.Windows.Forms.DateTimePicker();
            this.final = new System.Windows.Forms.Label();
            this.inicial = new System.Windows.Forms.Label();
            this.modalidade = new System.Windows.Forms.Label();
            this.tabCadastro = new System.Windows.Forms.TabControl();
            this.relatorio = new System.Windows.Forms.TabPage();
            this.visualizador = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btGerar = new System.Windows.Forms.Button();
            this.cbRelatorios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.cadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.relatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pesquisa
            // 
            this.pesquisa.Controls.Add(this.btPesq);
            this.pesquisa.Controls.Add(this.Pesq);
            this.pesquisa.Controls.Add(this.tbPesqNome);
            this.pesquisa.Controls.Add(this.dgvTabela);
            this.pesquisa.Location = new System.Drawing.Point(4, 22);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.pesquisa.Size = new System.Drawing.Size(922, 425);
            this.pesquisa.TabIndex = 1;
            this.pesquisa.Text = "Pesquisa";
            this.pesquisa.UseVisualStyleBackColor = true;
            // 
            // btPesq
            // 
            this.btPesq.Location = new System.Drawing.Point(278, 40);
            this.btPesq.Name = "btPesq";
            this.btPesq.Size = new System.Drawing.Size(99, 23);
            this.btPesq.TabIndex = 3;
            this.btPesq.Text = "Pesquisar";
            this.btPesq.UseVisualStyleBackColor = true;
            this.btPesq.Click += new System.EventHandler(this.btPesq_Click);
            // 
            // Pesq
            // 
            this.Pesq.AutoSize = true;
            this.Pesq.Location = new System.Drawing.Point(44, 26);
            this.Pesq.Name = "Pesq";
            this.Pesq.Size = new System.Drawing.Size(87, 13);
            this.Pesq.TabIndex = 2;
            this.Pesq.Text = "Nome do cliente:";
            // 
            // tbPesqNome
            // 
            this.tbPesqNome.Location = new System.Drawing.Point(47, 42);
            this.tbPesqNome.Name = "tbPesqNome";
            this.tbPesqNome.Size = new System.Drawing.Size(166, 20);
            this.tbPesqNome.TabIndex = 1;
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabCpf,
            this.tabNome,
            this.tabDataNasc,
            this.tabEstadoCivil,
            this.tabSexo,
            this.tabPlano,
            this.tabEmail,
            this.tabCelular,
            this.tabTelefone,
            this.tabEndereco,
            this.tabCidade,
            this.tabUf,
            this.tabCodigoPlano});
            this.dgvTabela.Location = new System.Drawing.Point(6, 113);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabela.Size = new System.Drawing.Size(907, 306);
            this.dgvTabela.TabIndex = 0;
            this.dgvTabela.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellDoubleClick);
            // 
            // tabCpf
            // 
            this.tabCpf.DataPropertyName = "cpf_tit";
            this.tabCpf.HeaderText = "CPF";
            this.tabCpf.Name = "tabCpf";
            // 
            // tabNome
            // 
            this.tabNome.DataPropertyName = "nome";
            this.tabNome.HeaderText = "Nome";
            this.tabNome.Name = "tabNome";
            // 
            // tabDataNasc
            // 
            this.tabDataNasc.DataPropertyName = "dt_nasc";
            this.tabDataNasc.HeaderText = "Nascimento";
            this.tabDataNasc.Name = "tabDataNasc";
            // 
            // tabEstadoCivil
            // 
            this.tabEstadoCivil.DataPropertyName = "estadoCivil";
            this.tabEstadoCivil.HeaderText = "Estado Civil";
            this.tabEstadoCivil.Name = "tabEstadoCivil";
            // 
            // tabSexo
            // 
            this.tabSexo.DataPropertyName = "sexo";
            this.tabSexo.HeaderText = "Sexo";
            this.tabSexo.Name = "tabSexo";
            // 
            // tabPlano
            // 
            this.tabPlano.DataPropertyName = "plano";
            this.tabPlano.HeaderText = "Plano";
            this.tabPlano.Name = "tabPlano";
            // 
            // tabEmail
            // 
            this.tabEmail.DataPropertyName = "email";
            this.tabEmail.HeaderText = "Email";
            this.tabEmail.Name = "tabEmail";
            // 
            // tabCelular
            // 
            this.tabCelular.DataPropertyName = "celular";
            this.tabCelular.HeaderText = "Celular";
            this.tabCelular.Name = "tabCelular";
            // 
            // tabTelefone
            // 
            this.tabTelefone.DataPropertyName = "telefone";
            this.tabTelefone.HeaderText = "Telefone";
            this.tabTelefone.Name = "tabTelefone";
            // 
            // tabEndereco
            // 
            this.tabEndereco.DataPropertyName = "endereco";
            this.tabEndereco.HeaderText = "Endereço";
            this.tabEndereco.Name = "tabEndereco";
            // 
            // tabCidade
            // 
            this.tabCidade.DataPropertyName = "cidade";
            this.tabCidade.HeaderText = "Cidade";
            this.tabCidade.Name = "tabCidade";
            // 
            // tabUf
            // 
            this.tabUf.DataPropertyName = "uf";
            this.tabUf.HeaderText = "UF";
            this.tabUf.Name = "tabUf";
            // 
            // tabCodigoPlano
            // 
            this.tabCodigoPlano.DataPropertyName = "CODIGO";
            this.tabCodigoPlano.HeaderText = "CodigoPlano";
            this.tabCodigoPlano.Name = "tabCodigoPlano";
            this.tabCodigoPlano.Visible = false;
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cadastro.Controls.Add(this.dtDataNasc);
            this.cadastro.Controls.Add(this.btPesquisar);
            this.cadastro.Controls.Add(this.btCancelar);
            this.cadastro.Controls.Add(this.btConfirmar);
            this.cadastro.Controls.Add(this.btAlterar);
            this.cadastro.Controls.Add(this.btExcluir);
            this.cadastro.Controls.Add(this.btNovo);
            this.cadastro.Controls.Add(this.cbUF);
            this.cadastro.Controls.Add(this.uf);
            this.cadastro.Controls.Add(this.tbCidade);
            this.cadastro.Controls.Add(this.tbEndereco);
            this.cadastro.Controls.Add(this.tbNome);
            this.cadastro.Controls.Add(this.tbCPF);
            this.cadastro.Controls.Add(this.cidade);
            this.cadastro.Controls.Add(this.endereco);
            this.cadastro.Controls.Add(this.cbSexo);
            this.cadastro.Controls.Add(this.sexo);
            this.cadastro.Controls.Add(this.cbEstadoCivil);
            this.cadastro.Controls.Add(this.estadocivil);
            this.cadastro.Controls.Add(this.data);
            this.cadastro.Controls.Add(this.nome);
            this.cadastro.Controls.Add(this.cpf);
            this.cadastro.Controls.Add(this.groupBox1);
            this.cadastro.Location = new System.Drawing.Point(4, 22);
            this.cadastro.Name = "cadastro";
            this.cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.cadastro.Size = new System.Drawing.Size(922, 425);
            this.cadastro.TabIndex = 0;
            this.cadastro.Text = "Cadastro";
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.Enabled = false;
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(540, 58);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(103, 20);
            this.dtDataNasc.TabIndex = 25;
            // 
            // btCancelar
            // 
            this.btCancelar.Enabled = false;
            this.btCancelar.Image = global::FIPPCARE.Properties.Resources.iconfinder_cancel_2_3090951;
            this.btCancelar.Location = new System.Drawing.Point(787, 322);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(110, 83);
            this.btCancelar.TabIndex = 22;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cbUF
            // 
            this.cbUF.Enabled = false;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(795, 121);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(121, 21);
            this.cbUF.TabIndex = 16;
            // 
            // uf
            // 
            this.uf.AutoSize = true;
            this.uf.Location = new System.Drawing.Point(793, 106);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(24, 13);
            this.uf.TabIndex = 15;
            this.uf.Text = "UF:";
            // 
            // tbCidade
            // 
            this.tbCidade.Enabled = false;
            this.tbCidade.Location = new System.Drawing.Point(470, 121);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(303, 20);
            this.tbCidade.TabIndex = 14;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Enabled = false;
            this.tbEndereco.Location = new System.Drawing.Point(20, 121);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(416, 20);
            this.tbEndereco.TabIndex = 12;
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(161, 57);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(346, 20);
            this.tbNome.TabIndex = 4;
            // 
            // tbCPF
            // 
            this.tbCPF.Enabled = false;
            this.tbCPF.Location = new System.Drawing.Point(20, 57);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(114, 20);
            this.tbCPF.TabIndex = 3;
            this.tbCPF.Tag = "";
            // 
            // cidade
            // 
            this.cidade.AutoSize = true;
            this.cidade.Location = new System.Drawing.Point(467, 105);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(50, 13);
            this.cidade.TabIndex = 13;
            this.cidade.Text = "CIDADE:";
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(17, 106);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(70, 13);
            this.endereco.TabIndex = 11;
            this.endereco.Text = "ENDEREÇO:";
            // 
            // cbSexo
            // 
            this.cbSexo.Enabled = false;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(796, 56);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(117, 21);
            this.cbSexo.TabIndex = 10;
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(793, 39);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(39, 13);
            this.sexo.TabIndex = 9;
            this.sexo.Text = "SEXO:";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Enabled = false;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(666, 57);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(107, 21);
            this.cbEstadoCivil.TabIndex = 8;
            // 
            // estadocivil
            // 
            this.estadocivil.AutoSize = true;
            this.estadocivil.Location = new System.Drawing.Point(672, 39);
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.Size = new System.Drawing.Size(83, 13);
            this.estadocivil.TabIndex = 7;
            this.estadocivil.Text = "ESTADO CIVIL:";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(537, 41);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(71, 13);
            this.data.TabIndex = 6;
            this.data.Text = "DATA NASC:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(158, 39);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(42, 13);
            this.nome.TabIndex = 2;
            this.nome.Text = "NOME:";
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(17, 41);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(30, 13);
            this.cpf.TabIndex = 1;
            this.cpf.Text = "CPF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNotificar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 297);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do cliente:";
            // 
            // lbNotificar
            // 
            this.lbNotificar.AutoSize = true;
            this.lbNotificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbNotificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotificar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbNotificar.Location = new System.Drawing.Point(7, 270);
            this.lbNotificar.Name = "lbNotificar";
            this.lbNotificar.Size = new System.Drawing.Size(0, 20);
            this.lbNotificar.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCelular);
            this.groupBox2.Controls.Add(this.celular);
            this.groupBox2.Controls.Add(this.tbFixo);
            this.groupBox2.Controls.Add(this.tel);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 72);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações para contato:";
            // 
            // tbCelular
            // 
            this.tbCelular.Enabled = false;
            this.tbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCelular.Location = new System.Drawing.Point(322, 44);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(100, 22);
            this.tbCelular.TabIndex = 22;
            // 
            // celular
            // 
            this.celular.AutoSize = true;
            this.celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular.Location = new System.Drawing.Point(319, 28);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(59, 13);
            this.celular.TabIndex = 1;
            this.celular.Text = "CELULAR:";
            // 
            // tbFixo
            // 
            this.tbFixo.Enabled = false;
            this.tbFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFixo.Location = new System.Drawing.Point(206, 44);
            this.tbFixo.Name = "tbFixo";
            this.tbFixo.Size = new System.Drawing.Size(100, 22);
            this.tbFixo.TabIndex = 21;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.Location = new System.Drawing.Point(203, 28);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(57, 13);
            this.tel.TabIndex = 20;
            this.tel.Text = "TEL FIXO:";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(9, 44);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(179, 22);
            this.tbEmail.TabIndex = 19;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(6, 28);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 13);
            this.email.TabIndex = 18;
            this.email.Text = "EMAIL:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbModalidade);
            this.groupBox3.Controls.Add(this.dtVigFinal);
            this.groupBox3.Controls.Add(this.dtVigInicial);
            this.groupBox3.Controls.Add(this.final);
            this.groupBox3.Controls.Add(this.inicial);
            this.groupBox3.Controls.Add(this.modalidade);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(485, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 72);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plano contratado:";
            // 
            // cbModalidade
            // 
            this.cbModalidade.BackColor = System.Drawing.SystemColors.Window;
            this.cbModalidade.DropDownHeight = 200;
            this.cbModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidade.DropDownWidth = 200;
            this.cbModalidade.Enabled = false;
            this.cbModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.IntegralHeight = false;
            this.cbModalidade.ItemHeight = 15;
            this.cbModalidade.Location = new System.Drawing.Point(9, 43);
            this.cbModalidade.MaxLength = 21;
            this.cbModalidade.MinimumSize = new System.Drawing.Size(121, 0);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(185, 23);
            this.cbModalidade.TabIndex = 23;
            this.cbModalidade.SelectedIndexChanged += new System.EventHandler(this.cbModalidade_SelectedIndexChanged);
            // 
            // dtVigFinal
            // 
            this.dtVigFinal.Enabled = false;
            this.dtVigFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVigFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVigFinal.Location = new System.Drawing.Point(322, 44);
            this.dtVigFinal.Name = "dtVigFinal";
            this.dtVigFinal.Size = new System.Drawing.Size(103, 22);
            this.dtVigFinal.TabIndex = 25;
            // 
            // dtVigInicial
            // 
            this.dtVigInicial.Enabled = false;
            this.dtVigInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVigInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVigInicial.Location = new System.Drawing.Point(206, 44);
            this.dtVigInicial.Name = "dtVigInicial";
            this.dtVigInicial.Size = new System.Drawing.Size(103, 22);
            this.dtVigInicial.TabIndex = 24;
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.Enabled = false;
            this.final.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final.Location = new System.Drawing.Point(319, 28);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(93, 13);
            this.final.TabIndex = 1;
            this.final.Text = "VIGÊNCIA FINAL:";
            // 
            // inicial
            // 
            this.inicial.AutoSize = true;
            this.inicial.Enabled = false;
            this.inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicial.Location = new System.Drawing.Point(203, 28);
            this.inicial.Name = "inicial";
            this.inicial.Size = new System.Drawing.Size(100, 13);
            this.inicial.TabIndex = 20;
            this.inicial.Text = "VIGÊNCIA INICIAL:";
            // 
            // modalidade
            // 
            this.modalidade.AutoSize = true;
            this.modalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalidade.Location = new System.Drawing.Point(6, 28);
            this.modalidade.Name = "modalidade";
            this.modalidade.Size = new System.Drawing.Size(81, 13);
            this.modalidade.TabIndex = 18;
            this.modalidade.Text = "MODALIDADE:";
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.cadastro);
            this.tabCadastro.Controls.Add(this.pesquisa);
            this.tabCadastro.Controls.Add(this.relatorio);
            this.tabCadastro.Location = new System.Drawing.Point(2, 1);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.SelectedIndex = 0;
            this.tabCadastro.Size = new System.Drawing.Size(930, 451);
            this.tabCadastro.TabIndex = 0;
            // 
            // relatorio
            // 
            this.relatorio.Controls.Add(this.visualizador);
            this.relatorio.Controls.Add(this.btGerar);
            this.relatorio.Controls.Add(this.cbRelatorios);
            this.relatorio.Controls.Add(this.label1);
            this.relatorio.Location = new System.Drawing.Point(4, 22);
            this.relatorio.Name = "relatorio";
            this.relatorio.Padding = new System.Windows.Forms.Padding(3);
            this.relatorio.Size = new System.Drawing.Size(922, 425);
            this.relatorio.TabIndex = 2;
            this.relatorio.Text = "Relatorio";
            this.relatorio.UseVisualStyleBackColor = true;
            // 
            // visualizador
            // 
            this.visualizador.Location = new System.Drawing.Point(6, 51);
            this.visualizador.Name = "visualizador";
            this.visualizador.ServerReport.BearerToken = null;
            this.visualizador.Size = new System.Drawing.Size(907, 371);
            this.visualizador.TabIndex = 3;
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(327, 19);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 26);
            this.btGerar.TabIndex = 2;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // cbRelatorios
            // 
            this.cbRelatorios.FormattingEnabled = true;
            this.cbRelatorios.Items.AddRange(new object[] {
            "Relatório simples de todos os clientes",
            "Relatório de clientes agrupados por plano"});
            this.cbRelatorios.Location = new System.Drawing.Point(143, 23);
            this.cbRelatorios.Name = "cbRelatorios";
            this.cbRelatorios.Size = new System.Drawing.Size(143, 21);
            this.cbRelatorios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o relatório:";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::FIPPCARE.Properties.Resources.iconfinder_icon_search_2118851;
            this.btPesquisar.Location = new System.Drawing.Point(407, 332);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(110, 83);
            this.btPesquisar.TabIndex = 23;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Enabled = false;
            this.btConfirmar.Image = global::FIPPCARE.Properties.Resources.iconfinder_check_3265721;
            this.btConfirmar.Location = new System.Drawing.Point(663, 322);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(110, 83);
            this.btConfirmar.TabIndex = 21;
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Enabled = false;
            this.btAlterar.Image = global::FIPPCARE.Properties.Resources.iconfinder_UI_Basic_GLYPH_48_47333761;
            this.btAlterar.Location = new System.Drawing.Point(279, 332);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(110, 83);
            this.btAlterar.TabIndex = 20;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Image = global::FIPPCARE.Properties.Resources.iconfinder_user_x_25614951;
            this.btExcluir.Location = new System.Drawing.Point(150, 332);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 83);
            this.btExcluir.TabIndex = 19;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btNovo
            // 
            this.btNovo.Image = global::FIPPCARE.Properties.Resources.iconfinder_user_plus_25614941;
            this.btNovo.Location = new System.Drawing.Point(25, 332);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(110, 83);
            this.btNovo.TabIndex = 18;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.tabCadastro);
            this.Name = "FCadastro";
            this.Text = "PLANO DE SAÚDE FIPPCARE";
            this.Load += new System.EventHandler(this.FCadastro_Load);
            this.pesquisa.ResumeLayout(false);
            this.pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.cadastro.ResumeLayout(false);
            this.cadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabCadastro.ResumeLayout(false);
            this.relatorio.ResumeLayout(false);
            this.relatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pesquisa;
        private System.Windows.Forms.Button btPesq;
        private System.Windows.Forms.Label Pesq;
        private System.Windows.Forms.TextBox tbPesqNome;
        private System.Windows.Forms.TabPage cadastro;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label uf;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label estadocivil;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtVigFinal;
        private System.Windows.Forms.DateTimePicker dtVigInicial;
        private System.Windows.Forms.Label final;
        private System.Windows.Forms.Label inicial;
        private System.Windows.Forms.Label modalidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label celular;
        private System.Windows.Forms.TextBox tbFixo;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TabControl tabCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabPlano;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabCodigoPlano;
        public System.Windows.Forms.DataGridView dgvTabela;
        public System.Windows.Forms.ComboBox cbModalidade;
        public System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.Label lbNotificar;
        public System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TabPage relatorio;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.ComboBox cbRelatorios;
        private System.Windows.Forms.Label label1;
        public Microsoft.Reporting.WinForms.ReportViewer visualizador;
    }
}

