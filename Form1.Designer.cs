namespace projeto_medtime
{
    partial class primeira_pagina_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(primeira_pagina_login));
            btn_logar_login = new Button();
            btn_pular = new Button();
            lbl_nome_login = new Label();
            txtB_nome_login = new TextBox();
            lbl_cpf_login = new Label();
            lbl_senha_login = new Label();
            txtB_senha_login = new TextBox();
            linkLabel_cadastro_login = new LinkLabel();
            lbl_cadastrarse_login = new Label();
            checkBox1 = new CheckBox();
            msk_txtB_CPF = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            lbl_logo_cadastro = new Label();
            pictureBox_ajuda_login = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ajuda_login).BeginInit();
            SuspendLayout();
            // 
            // btn_logar_login
            // 
            btn_logar_login.BackColor = Color.CornflowerBlue;
            btn_logar_login.BackgroundImageLayout = ImageLayout.None;
            btn_logar_login.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logar_login.ForeColor = SystemColors.Window;
            btn_logar_login.Location = new Point(491, 410);
            btn_logar_login.Name = "btn_logar_login";
            btn_logar_login.Size = new Size(104, 45);
            btn_logar_login.TabIndex = 0;
            btn_logar_login.Text = "LOGAR";
            btn_logar_login.UseVisualStyleBackColor = false;
            btn_logar_login.Click += button1_Click;
            // 
            // btn_pular
            // 
            btn_pular.BackColor = Color.CornflowerBlue;
            btn_pular.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_pular.ForeColor = SystemColors.Window;
            btn_pular.Location = new Point(629, 410);
            btn_pular.Name = "btn_pular";
            btn_pular.Size = new Size(99, 45);
            btn_pular.TabIndex = 1;
            btn_pular.Text = "PULAR";
            btn_pular.UseVisualStyleBackColor = false;
            btn_pular.Click += btn_pular_Click;
            // 
            // lbl_nome_login
            // 
            lbl_nome_login.AutoSize = true;
            lbl_nome_login.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome_login.ForeColor = SystemColors.Window;
            lbl_nome_login.Location = new Point(386, 115);
            lbl_nome_login.Name = "lbl_nome_login";
            lbl_nome_login.Size = new Size(230, 34);
            lbl_nome_login.TabIndex = 2;
            lbl_nome_login.Text = "PRIMEIRO NOME";
            // 
            // txtB_nome_login
            // 
            txtB_nome_login.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_nome_login.ForeColor = SystemColors.WindowFrame;
            txtB_nome_login.Location = new Point(386, 152);
            txtB_nome_login.Name = "txtB_nome_login";
            txtB_nome_login.Size = new Size(442, 35);
            txtB_nome_login.TabIndex = 3;
            txtB_nome_login.TextChanged += txtB_nome_login_TextChanged;
            // 
            // lbl_cpf_login
            // 
            lbl_cpf_login.AutoSize = true;
            lbl_cpf_login.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cpf_login.ForeColor = SystemColors.Window;
            lbl_cpf_login.Location = new Point(386, 199);
            lbl_cpf_login.Name = "lbl_cpf_login";
            lbl_cpf_login.Size = new Size(64, 34);
            lbl_cpf_login.TabIndex = 4;
            lbl_cpf_login.Text = "CPF";
            // 
            // lbl_senha_login
            // 
            lbl_senha_login.AutoSize = true;
            lbl_senha_login.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_senha_login.ForeColor = SystemColors.Window;
            lbl_senha_login.Location = new Point(386, 283);
            lbl_senha_login.Name = "lbl_senha_login";
            lbl_senha_login.Size = new Size(101, 34);
            lbl_senha_login.TabIndex = 6;
            lbl_senha_login.Text = "SENHA";
            // 
            // txtB_senha_login
            // 
            txtB_senha_login.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_senha_login.ForeColor = SystemColors.WindowFrame;
            txtB_senha_login.Location = new Point(386, 320);
            txtB_senha_login.Name = "txtB_senha_login";
            txtB_senha_login.Size = new Size(442, 35);
            txtB_senha_login.TabIndex = 7;
            txtB_senha_login.TextChanged += txtB_senha_login_TextChanged;
            // 
            // linkLabel_cadastro_login
            // 
            linkLabel_cadastro_login.ActiveLinkColor = Color.DeepSkyBlue;
            linkLabel_cadastro_login.AutoSize = true;
            linkLabel_cadastro_login.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel_cadastro_login.LinkColor = Color.CornflowerBlue;
            linkLabel_cadastro_login.Location = new Point(724, 362);
            linkLabel_cadastro_login.Name = "linkLabel_cadastro_login";
            linkLabel_cadastro_login.Size = new Size(104, 21);
            linkLabel_cadastro_login.TabIndex = 9;
            linkLabel_cadastro_login.TabStop = true;
            linkLabel_cadastro_login.Text = "CLIQUE AQUI";
            linkLabel_cadastro_login.LinkClicked += linkLabel_cadastro_login_LinkClicked;
            // 
            // lbl_cadastrarse_login
            // 
            lbl_cadastrarse_login.AutoSize = true;
            lbl_cadastrarse_login.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cadastrarse_login.ForeColor = SystemColors.Window;
            lbl_cadastrarse_login.Location = new Point(520, 362);
            lbl_cadastrarse_login.Name = "lbl_cadastrarse_login";
            lbl_cadastrarse_login.Size = new Size(208, 21);
            lbl_cadastrarse_login.TabIndex = 10;
            lbl_cadastrarse_login.Text = "AINDA NÃO CADASTRADO?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.Window;
            checkBox1.Location = new Point(386, 361);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 25);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "LEMBRAR-ME";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // msk_txtB_CPF
            // 
            msk_txtB_CPF.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msk_txtB_CPF.ForeColor = Color.LightSteelBlue;
            msk_txtB_CPF.Location = new Point(386, 236);
            msk_txtB_CPF.Mask = "000,000,000-00";
            msk_txtB_CPF.Name = "msk_txtB_CPF";
            msk_txtB_CPF.Size = new Size(190, 35);
            msk_txtB_CPF.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lbl_logo_cadastro
            // 
            lbl_logo_cadastro.AutoSize = true;
            lbl_logo_cadastro.Font = new Font("Franklin Gothic Heavy", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_logo_cadastro.ForeColor = SystemColors.Window;
            lbl_logo_cadastro.Location = new Point(130, 88);
            lbl_logo_cadastro.Name = "lbl_logo_cadastro";
            lbl_logo_cadastro.Size = new Size(148, 50);
            lbl_logo_cadastro.TabIndex = 14;
            lbl_logo_cadastro.Text = "LOGIN";
            lbl_logo_cadastro.Click += lbl_logo_cadastro_Click;
            // 
            // pictureBox_ajuda_login
            // 
            pictureBox_ajuda_login.Image = (Image)resources.GetObject("pictureBox_ajuda_login.Image");
            pictureBox_ajuda_login.Location = new Point(848, 528);
            pictureBox_ajuda_login.Name = "pictureBox_ajuda_login";
            pictureBox_ajuda_login.Size = new Size(25, 25);
            pictureBox_ajuda_login.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_ajuda_login.TabIndex = 15;
            pictureBox_ajuda_login.TabStop = false;
            pictureBox_ajuda_login.Click += pictureBox2_Click;
            // 
            // primeira_pagina_login
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(pictureBox_ajuda_login);
            Controls.Add(lbl_logo_cadastro);
            Controls.Add(pictureBox1);
            Controls.Add(msk_txtB_CPF);
            Controls.Add(checkBox1);
            Controls.Add(lbl_cadastrarse_login);
            Controls.Add(linkLabel_cadastro_login);
            Controls.Add(txtB_senha_login);
            Controls.Add(lbl_senha_login);
            Controls.Add(lbl_cpf_login);
            Controls.Add(txtB_nome_login);
            Controls.Add(lbl_nome_login);
            Controls.Add(btn_pular);
            Controls.Add(btn_logar_login);
            Name = "primeira_pagina_login";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += primeira_pagina_login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ajuda_login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_logar_login;
        private Button btn_pular;
        private Label lbl_nome_login;
        private Label lbl_cpf_login;
        private Label lbl_senha_login;
        private TextBox txtB_senha_login;
        private LinkLabel linkLabel_cadastro_login;
        private Label lbl_cadastrarse_login;
        private CheckBox checkBox1;
        private MaskedTextBox msk_txtB_CPF;
        private PictureBox pictureBox1;
        private Label lbl_logo_cadastro;
        private PictureBox pictureBox_ajuda_login;
        private TextBox txtB_nome_login;
    }
}
