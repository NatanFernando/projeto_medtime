namespace projeto_medtime
{
    public partial class primeira_pagina_login : Form
    {

        public primeira_pagina_login()
        {
            InitializeComponent();

        }

        private void primeira_pagina_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_pular_Click(object sender, EventArgs e)
        {
            // ESTE BOTÃO DIRECIONA PARA A PÁGINA DO MENU, SEM LOGIN
            pagina_tres_menu pagina_Tres_Menu = new pagina_tres_menu(txtB_nome_login.Text);
            pagina_Tres_Menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ESTE BOTÃO DIRECIONA PARA A PÁGINA DO MENU, COM LOGIN
            if (msk_txtB_CPF.Text == "112.311.015-32" && txtB_senha_login.Text == "Nicholas")
            {
                pagina_tres_menu pagina_Tres_Menu = new pagina_tres_menu(txtB_nome_login.Text);
                pagina_Tres_Menu.Show();
            }
            else
            {
                MessageBox.Show("Login Inválido");
                msk_txtB_CPF.Clear();
                txtB_senha_login.Clear();
            }
        }

        private void txtB_nome_login_TextChanged(object sender, EventArgs e)
        {
            txtB_nome_login.MaxLength = 10;
        }

        private void linkLabel_cadastro_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ESTE LINKLABEL DIRECIONA PARA A PÁGINA DE CADASTRO
            pagina_dois_cadastro pagina_Dois_Cadastro = new pagina_dois_cadastro();
            pagina_Dois_Cadastro.Show();
        }

        private void txtB_senha_login_TextChanged(object sender, EventArgs e)
        {
            txtB_senha_login.PasswordChar = '*';
        }

        private void txtB_cpf_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_logo_cadastro_Click(object sender, EventArgs e)
        {

        }
    }
}

