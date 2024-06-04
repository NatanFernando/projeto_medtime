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
            // ESTE BOT�O DIRECIONA PARA A P�GINA DO MENU, SEM LOGIN

            this.Hide();
            pagina_tres_menu pagina_Tres_Menu = new pagina_tres_menu(txtB_nome_login.Text);
            pagina_Tres_Menu.Closed += (s, args) => this.Close(); //ESTE COMANDO PERMITE QUE A P�GINA ATUAL SEJA FECHADA QUANDO O NOVO FORMS FOR INICIADO
            pagina_Tres_Menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ESTE BOT�O DIRECIONA PARA A P�GINA DO MENU, COM LOGIN
            if (msk_txtB_CPF.Text == "123.456.789-10" && txtB_senha_login.Text == "Carla")
            {
                this.Hide();
                pagina_tres_menu pagina_Tres_Menu = new pagina_tres_menu(txtB_nome_login.Text);
                pagina_Tres_Menu.Closed += (s, args) => this.Close();
                pagina_Tres_Menu.Show();
            }
            else
            {
                MessageBox.Show("Login Inv�lido"); // ESTE COMANDO PERMITE INFORMAR O USU�RIO ATRAV�S DE UM POP-UP QUE O LOGIN EST� INCORRETO
                msk_txtB_CPF.Clear(); //ESTE COMANDO EXCLUI AS INFORMA��ES INCORRETAS INSERIDAS NO MASKED TEXT BOX 'CPF'
                txtB_senha_login.Clear(); //ESTE COMANDO EXCLUI AS INFORMA��ES INCORRETAS INSERIDAS NO TEXT BOX 'LOGIN'
            }
        }

        private void txtB_nome_login_TextChanged(object sender, EventArgs e)
        {
            txtB_nome_login.MaxLength = 10; // ESTA LINHA DE COMANDO DETERMINA QUE O TEXT BOX 'PRIMEIRO NOME' APENAS ACEITA 10 CARACTERES
        }

        private void linkLabel_cadastro_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ESTE LINKLABEL DIRECIONA PARA A P�GINA DE CADASTRO
            this.Hide();
            pagina_dois_cadastro pagina_Dois_Cadastro = new pagina_dois_cadastro();
            pagina_Dois_Cadastro.Closed += (s, args) => this.Close();
            pagina_Dois_Cadastro.Show();
        }

        private void txtB_senha_login_TextChanged(object sender, EventArgs e)
        {
            txtB_senha_login.PasswordChar = '*'; // ESTE COMANDO TRANSFORMA AS INFORMA��ES INSERIDAS NO TEXT BOX 'SENHA' EM ASTERISCOS
        }

        private void txtB_cpf_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_logo_cadastro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CASO ESTEJA TENDO DIFICULDADES COM SEU LOGIN, ACESSE O PROGRAMA DIRETO ATRAV�S DO BOT�O \"PULAR\" ");
            // ESTE COMANDO AUXILIA O USU�RIO ATRAV�S DE UM POP-UP INFORMATIVO
        }
    }
}

