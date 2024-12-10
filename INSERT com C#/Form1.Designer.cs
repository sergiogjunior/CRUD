namespace INSERT_com_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCadastroClientes = new Label();
            lblNomeCompleto = new Label();
            lblCpf = new Label();
            lblRg = new Label();
            lblDataNascimento = new Label();
            mtbCpf = new MaskedTextBox();
            lblTelefone = new Label();
            gpbCadastro = new GroupBox();
            cbbSexo = new Label();
            comboBox1 = new ComboBox();
            mtbDtNascimento = new MaskedTextBox();
            mtbTelefone = new MaskedTextBox();
            mtbRg = new MaskedTextBox();
            txtNome = new TextBox();
            btnInserir = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            lstUsuario = new ListView();
            lblBuscar = new Label();
            gpbCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // lblCadastroClientes
            // 
            lblCadastroClientes.AutoSize = true;
            lblCadastroClientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroClientes.Location = new Point(92, 9);
            lblCadastroClientes.Name = "lblCadastroClientes";
            lblCadastroClientes.Size = new Size(276, 37);
            lblCadastroClientes.TabIndex = 0;
            lblCadastroClientes.Text = "Cadastro de clientes";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(14, 28);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 1;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(14, 57);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF";
            // 
            // lblRg
            // 
            lblRg.AutoSize = true;
            lblRg.Location = new Point(14, 94);
            lblRg.Name = "lblRg";
            lblRg.Size = new Size(22, 15);
            lblRg.TabIndex = 3;
            lblRg.Text = "RG";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(14, 128);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(114, 15);
            lblDataNascimento.TabIndex = 4;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(48, 54);
            mtbCpf.Mask = "000,000,000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(100, 23);
            mtbCpf.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(14, 161);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // gpbCadastro
            // 
            gpbCadastro.Controls.Add(cbbSexo);
            gpbCadastro.Controls.Add(comboBox1);
            gpbCadastro.Controls.Add(mtbDtNascimento);
            gpbCadastro.Controls.Add(mtbTelefone);
            gpbCadastro.Controls.Add(mtbRg);
            gpbCadastro.Controls.Add(txtNome);
            gpbCadastro.Controls.Add(lblNomeCompleto);
            gpbCadastro.Controls.Add(lblCpf);
            gpbCadastro.Controls.Add(lblTelefone);
            gpbCadastro.Controls.Add(lblRg);
            gpbCadastro.Controls.Add(lblDataNascimento);
            gpbCadastro.Controls.Add(mtbCpf);
            gpbCadastro.Location = new Point(12, 58);
            gpbCadastro.Name = "gpbCadastro";
            gpbCadastro.Size = new Size(440, 267);
            gpbCadastro.TabIndex = 10;
            gpbCadastro.TabStop = false;
            gpbCadastro.Text = "Cadastro";
            // 
            // cbbSexo
            // 
            cbbSexo.AutoSize = true;
            cbbSexo.Location = new Point(14, 201);
            cbbSexo.Name = "cbbSexo";
            cbbSexo.Size = new Size(32, 15);
            cbbSexo.TabIndex = 15;
            cbbSexo.Text = "Sexo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Feminino" });
            comboBox1.Location = new Point(52, 198);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // mtbDtNascimento
            // 
            mtbDtNascimento.Location = new Point(134, 125);
            mtbDtNascimento.Mask = "00/00/0000";
            mtbDtNascimento.Name = "mtbDtNascimento";
            mtbDtNascimento.Size = new Size(100, 23);
            mtbDtNascimento.TabIndex = 13;
            mtbDtNascimento.ValidatingType = typeof(DateTime);
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(71, 158);
            mtbTelefone.Mask = "(00) 00000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(100, 23);
            mtbTelefone.TabIndex = 8;
            // 
            // mtbRg
            // 
            mtbRg.Location = new Point(45, 92);
            mtbRg.Name = "mtbRg";
            mtbRg.Size = new Size(100, 23);
            mtbRg.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(116, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(306, 23);
            txtNome.TabIndex = 6;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // btnInserir
            // 
            btnInserir.Image = (Image)resources.GetObject("btnInserir.Image");
            btnInserir.Location = new Point(12, 342);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(70, 70);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "Inserir";
            btnInserir.TextAlign = ContentAlignment.BottomCenter;
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnSalvar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.Location = new Point(804, 36);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(70, 70);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.BottomCenter;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(202, 342);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(70, 70);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "excluir";
            btnExcluir.TextAlign = ContentAlignment.BottomCenter;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.Location = new Point(382, 342);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(70, 70);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "atualizar";
            btnAtualizar.TextAlign = ContentAlignment.BottomCenter;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lstUsuario
            // 
            lstUsuario.Location = new Point(458, 112);
            lstUsuario.Name = "lstUsuario";
            lstUsuario.Size = new Size(416, 213);
            lstUsuario.TabIndex = 15;
            lstUsuario.UseCompatibleStateImageBehavior = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuscar.Location = new Point(458, 80);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(60, 21);
            lblBuscar.TabIndex = 17;
            lblBuscar.Text = "Buscar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 428);
            Controls.Add(lblBuscar);
            Controls.Add(lstUsuario);
            Controls.Add(btnAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnInserir);
            Controls.Add(gpbCadastro);
            Controls.Add(lblCadastroClientes);
            Name = "Form1";
            Text = "Cadastro Cliente";
            gpbCadastro.ResumeLayout(false);
            gpbCadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroClientes;
        private Label lblNomeCompleto;
        private Label lblCpf;
        private Label lblRg;
        private Label lblDataNascimento;
        private MaskedTextBox mtbCpf;
        private Label lblTelefone;
        private GroupBox gpbCadastro;
        private MaskedTextBox mtbRg;
        private TextBox txtNome;
        private MaskedTextBox mtbTelefone;
        private Button btnInserir;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private MaskedTextBox mtbDtNascimento;
        private ListView lstUsuario;
        private Label lblBuscar;
        private Label cbbSexo;
        private ComboBox comboBox1;
    }
}