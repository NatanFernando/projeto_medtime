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
            pagina_tres_menu pagina_Tres_Menu = new pagina_tres_menu(txtB_nome_login.Text);
            pagina_Tres_Menu.Show();
        }

        private void txtB_nome_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_cadastro_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ESTE LINKLABEL DIRECIONA PARA A PÁGINA DE CADASTRO
            pagina_dois_cadastro pagina_Dois_Cadastro = new pagina_dois_cadastro();
            pagina_Dois_Cadastro.Show();
        }
    }
}

