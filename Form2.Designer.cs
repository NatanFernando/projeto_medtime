namespace projeto_medtime
{
    partial class pagina_dois_cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nome_cadastro = new Label();
            txtB_nome_cadastro = new TextBox();
            btn_cadastrarme_cadastro = new Button();
            lbl_logo_cadastro = new Label();
            lbl_senha_cadastro = new Label();
            lbl_cpf_cadastro = new Label();
            lbl_confirmar_senha_cadastro = new Label();
            txtB_senha_cadastro = new TextBox();
            txtB_confirmar_senha_cadastro = new TextBox();
            msk_txtB_CPF = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbl_nome_cadastro
            // 
            lbl_nome_cadastro.AutoSize = true;
            lbl_nome_cadastro.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome_cadastro.ForeColor = SystemColors.Window;
            lbl_nome_cadastro.Location = new Point(494, 79);
            lbl_nome_cadastro.Name = "lbl_nome_cadastro";
            lbl_nome_cadastro.Size = new Size(230, 34);
            lbl_nome_cadastro.TabIndex = 0;
            lbl_nome_cadastro.Text = "PRIMEIRO NOME";
            // 
            // txtB_nome_cadastro
            // 
            txtB_nome_cadastro.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_nome_cadastro.ForeColor = SystemColors.WindowFrame;
            txtB_nome_cadastro.Location = new Point(494, 116);
            txtB_nome_cadastro.Name = "txtB_nome_cadastro";
            txtB_nome_cadastro.Size = new Size(334, 35);
            txtB_nome_cadastro.TabIndex = 1;
            txtB_nome_cadastro.TextChanged += txtB_nome_cadastro_TextChanged;
            // 
            // btn_cadastrarme_cadastro
            // 
            btn_cadastrarme_cadastro.BackColor = Color.CornflowerBlue;
            btn_cadastrarme_cadastro.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrarme_cadastro.ForeColor = SystemColors.Window;
            btn_cadastrarme_cadastro.Location = new Point(513, 432);
            btn_cadastrarme_cadastro.Name = "btn_cadastrarme_cadastro";
            btn_cadastrarme_cadastro.Size = new Size(301, 50);
            btn_cadastrarme_cadastro.TabIndex = 2;
            btn_cadastrarme_cadastro.Text = "CONCLUIR CADASTRO";
            btn_cadastrarme_cadastro.UseVisualStyleBackColor = false;
            btn_cadastrarme_cadastro.Click += btn_cadastrarme_cadastro_Click;
            // 
            // lbl_logo_cadastro
            // 
            lbl_logo_cadastro.AutoSize = true;
            lbl_logo_cadastro.Font = new Font("Franklin Gothic Heavy", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_logo_cadastro.ForeColor = SystemColors.Window;
            lbl_logo_cadastro.Location = new Point(12, 18);
            lbl_logo_cadastro.Name = "lbl_logo_cadastro";
            lbl_logo_cadastro.Size = new Size(238, 50);
            lbl_logo_cadastro.TabIndex = 9;
            lbl_logo_cadastro.Text = "CADASTRO";
            // 
            // lbl_senha_cadastro
            // 
            lbl_senha_cadastro.AutoSize = true;
            lbl_senha_cadastro.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_senha_cadastro.ForeColor = SystemColors.Window;
            lbl_senha_cadastro.Location = new Point(493, 247);
            lbl_senha_cadastro.Name = "lbl_senha_cadastro";
            lbl_senha_cadastro.Size = new Size(101, 34);
            lbl_senha_cadastro.TabIndex = 10;
            lbl_senha_cadastro.Text = "SENHA";
            lbl_senha_cadastro.Click += lbl_senha_cadastro_Click;
            // 
            // lbl_cpf_cadastro
            // 
            lbl_cpf_cadastro.AutoSize = true;
            lbl_cpf_cadastro.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cpf_cadastro.ForeColor = SystemColors.Window;
            lbl_cpf_cadastro.Location = new Point(493, 160);
            lbl_cpf_cadastro.Name = "lbl_cpf_cadastro";
            lbl_cpf_cadastro.Size = new Size(64, 34);
            lbl_cpf_cadastro.TabIndex = 11;
            lbl_cpf_cadastro.Text = "CPF";
            // 
            // lbl_confirmar_senha_cadastro
            // 
            lbl_confirmar_senha_cadastro.AutoSize = true;
            lbl_confirmar_senha_cadastro.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_confirmar_senha_cadastro.ForeColor = SystemColors.Window;
            lbl_confirmar_senha_cadastro.Location = new Point(493, 338);
            lbl_confirmar_senha_cadastro.Name = "lbl_confirmar_senha_cadastro";
            lbl_confirmar_senha_cadastro.Size = new Size(265, 34);
            lbl_confirmar_senha_cadastro.TabIndex = 12;
            lbl_confirmar_senha_cadastro.Text = "CONFIRMAR SENHA";
            // 
            // txtB_senha_cadastro
            // 
            txtB_senha_cadastro.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_senha_cadastro.ForeColor = SystemColors.WindowFrame;
            txtB_senha_cadastro.Location = new Point(493, 284);
            txtB_senha_cadastro.Name = "txtB_senha_cadastro";
            txtB_senha_cadastro.Size = new Size(334, 35);
            txtB_senha_cadastro.TabIndex = 14;
            txtB_senha_cadastro.TextChanged += txtB_senha_cadastro_TextChanged;
            // 
            // txtB_confirmar_senha_cadastro
            // 
            txtB_confirmar_senha_cadastro.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_confirmar_senha_cadastro.ForeColor = SystemColors.WindowFrame;
            txtB_confirmar_senha_cadastro.Location = new Point(493, 375);
            txtB_confirmar_senha_cadastro.Name = "txtB_confirmar_senha_cadastro";
            txtB_confirmar_senha_cadastro.Size = new Size(334, 35);
            txtB_confirmar_senha_cadastro.TabIndex = 15;
            txtB_confirmar_senha_cadastro.TextChanged += txtB_confirmar_senha_cadastro_TextChanged;
            // 
            // msk_txtB_CPF
            // 
            msk_txtB_CPF.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msk_txtB_CPF.ForeColor = Color.LightSteelBlue;
            msk_txtB_CPF.Location = new Point(493, 197);
            msk_txtB_CPF.Mask = "000,000,000-00";
            msk_txtB_CPF.Name = "msk_txtB_CPF";
            msk_txtB_CPF.Size = new Size(163, 35);
            msk_txtB_CPF.TabIndex = 16;
            // 
            // pagina_dois_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(msk_txtB_CPF);
            Controls.Add(txtB_confirmar_senha_cadastro);
            Controls.Add(txtB_senha_cadastro);
            Controls.Add(lbl_confirmar_senha_cadastro);
            Controls.Add(lbl_cpf_cadastro);
            Controls.Add(lbl_senha_cadastro);
            Controls.Add(lbl_logo_cadastro);
            Controls.Add(btn_cadastrarme_cadastro);
            Controls.Add(txtB_nome_cadastro);
            Controls.Add(lbl_nome_cadastro);
            Name = "pagina_dois_cadastro";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = "CADASTRO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome_cadastro;
        private TextBox txtB_nome_cadastro;
        private Button btn_cadastrarme_cadastro;
        private Label lbl_logo_cadastro;
        private Label lbl_senha_cadastro;
        private Label lbl_cpf_cadastro;
        private Label lbl_confirmar_senha_cadastro;
        private TextBox txtB_senha_cadastro;
        private TextBox txtB_confirmar_senha_cadastro;
        private MaskedTextBox msk_txtB_CPF;
    }
}