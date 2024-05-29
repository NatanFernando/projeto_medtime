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
            btn_logar_login = new Button();
            btn_pular = new Button();
            lbl_nome_login = new Label();
            txtB_nome_login = new TextBox();
            lbl_cpf_login = new Label();
            txtB_cpf_login = new TextBox();
            lbl_senha_login = new Label();
            txtB_senha_login = new TextBox();
            lbl_logo_login = new Label();
            linkLabel_cadastro_login = new LinkLabel();
            lbl_cadastrarse_login = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btn_logar_login
            // 
            btn_logar_login.BackColor = Color.CornflowerBlue;
            btn_logar_login.BackgroundImageLayout = ImageLayout.None;
            btn_logar_login.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logar_login.ForeColor = SystemColors.Window;
            btn_logar_login.Location = new Point(332, 425);
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
            btn_pular.Location = new Point(456, 425);
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
            lbl_nome_login.Location = new Point(95, 194);
            lbl_nome_login.Name = "lbl_nome_login";
            lbl_nome_login.Size = new Size(92, 34);
            lbl_nome_login.TabIndex = 2;
            lbl_nome_login.Text = "NOME";
            // 
            // txtB_nome_login
            // 
            txtB_nome_login.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_nome_login.ForeColor = SystemColors.WindowFrame;
            txtB_nome_login.Location = new Point(206, 191);
            txtB_nome_login.Name = "txtB_nome_login";
            txtB_nome_login.Size = new Size(602, 35);
            txtB_nome_login.TabIndex = 3;
            txtB_nome_login.TextChanged += txtB_nome_login_TextChanged;
            // 
            // lbl_cpf_login
            // 
            lbl_cpf_login.AutoSize = true;
            lbl_cpf_login.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cpf_login.ForeColor = SystemColors.Window;
            lbl_cpf_login.Location = new Point(95, 254);
            lbl_cpf_login.Name = "lbl_cpf_login";
            lbl_cpf_login.Size = new Size(64, 34);
            lbl_cpf_login.TabIndex = 4;
            lbl_cpf_login.Text = "CPF";
            // 
            // txtB_cpf_login
            // 
            txtB_cpf_login.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_cpf_login.ForeColor = SystemColors.WindowFrame;
            txtB_cpf_login.Location = new Point(206, 250);
            txtB_cpf_login.Name = "txtB_cpf_login";
            txtB_cpf_login.Size = new Size(602, 35);
            txtB_cpf_login.TabIndex = 5;
            // 
            // lbl_senha_login
            // 
            lbl_senha_login.AutoSize = true;
            lbl_senha_login.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_senha_login.ForeColor = SystemColors.Window;
            lbl_senha_login.Location = new Point(95, 313);
            lbl_senha_login.Name = "lbl_senha_login";
            lbl_senha_login.Size = new Size(101, 34);
            lbl_senha_login.TabIndex = 6;
            lbl_senha_login.Text = "SENHA";
            // 
            // txtB_senha_login
            // 
            txtB_senha_login.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_senha_login.ForeColor = SystemColors.WindowFrame;
            txtB_senha_login.Location = new Point(206, 313);
            txtB_senha_login.Name = "txtB_senha_login";
            txtB_senha_login.Size = new Size(602, 35);
            txtB_senha_login.TabIndex = 7;
            // 
            // lbl_logo_login
            // 
            lbl_logo_login.AutoSize = true;
            lbl_logo_login.Font = new Font("Franklin Gothic Heavy", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_logo_login.ForeColor = SystemColors.Window;
            lbl_logo_login.Location = new Point(332, 99);
            lbl_logo_login.Name = "lbl_logo_login";
            lbl_logo_login.Size = new Size(207, 50);
            lbl_logo_login.TabIndex = 8;
            lbl_logo_login.Text = "MEDTIME";
            // 
            // linkLabel_cadastro_login
            // 
            linkLabel_cadastro_login.ActiveLinkColor = Color.DeepSkyBlue;
            linkLabel_cadastro_login.AutoSize = true;
            linkLabel_cadastro_login.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel_cadastro_login.Location = new Point(704, 359);
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
            lbl_cadastrarse_login.Location = new Point(490, 359);
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
            checkBox1.Location = new Point(206, 355);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 25);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "LEMBRAR-ME";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // primeira_pagina_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(checkBox1);
            Controls.Add(lbl_cadastrarse_login);
            Controls.Add(linkLabel_cadastro_login);
            Controls.Add(lbl_logo_login);
            Controls.Add(txtB_senha_login);
            Controls.Add(lbl_senha_login);
            Controls.Add(txtB_cpf_login);
            Controls.Add(lbl_cpf_login);
            Controls.Add(txtB_nome_login);
            Controls.Add(lbl_nome_login);
            Controls.Add(btn_pular);
            Controls.Add(btn_logar_login);
            Name = "primeira_pagina_login";
            Text = "LOGIN";
            Load += primeira_pagina_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_logar_login;
        private Button btn_pular;
        private Label lbl_nome_login;
        private TextBox txtB_nome_login;
        private Label lbl_cpf_login;
        private TextBox txtB_cpf_login;
        private Label lbl_senha_login;
        private TextBox txtB_senha_login;
        private Label lbl_logo_login;
        private LinkLabel linkLabel_cadastro_login;
        private Label lbl_cadastrarse_login;
        private CheckBox checkBox1;
    }
}
