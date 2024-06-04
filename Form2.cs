using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_medtime
{
    public partial class pagina_dois_cadastro : Form
    {
        public pagina_dois_cadastro()
        {
            InitializeComponent();
            // OS COMANDOS ABAIXO ESCONDEM AS IMAGENS DO PERFIL (TANTO 'FEMININO', 'MASCULINO' E 'OUTROS')
            pictureBox_outros.Visible = false;
            pictureBox_masculino.Visible = false;
            pictureBox_feminino.Visible = false;
        }

        private void btn_cadastrarme_cadastro_Click(object sender, EventArgs e)
        {
            // ESTE BOTÃO CONCLUI O CADASTRO E DIRECIONA PARA A PÁGINA DO MENU
            if (txtB_senha_cadastro.Text != txtB_confirmar_senha_cadastro.Text)
            {
                MessageBox.Show("INFORME SENHAS IGUAIS");
                // SENHA E CONFIRMAÇÃO DE SENHA DIFERENTES SÃO ALERTADAS ATRAVÉS DE UM POP-UP
                txtB_senha_cadastro.Clear();
                txtB_confirmar_senha_cadastro.Clear();
            }
            else
            {
                this.Hide();
                pagina_tres_menu pagina_Tres_Menu = new pagina_tres_menu(txtB_nome_cadastro.Text);
                pagina_Tres_Menu.Closed += (s, args) => this.Close();
                pagina_Tres_Menu.Show();
            }
        }

        private void txtB_nome_cadastro_TextChanged(object sender, EventArgs e)
        {
            txtB_nome_cadastro.MaxLength = 10;
        }

        private void txtB_senha_cadastro_TextChanged(object sender, EventArgs e)
        {
            txtB_senha_cadastro.PasswordChar = '*';
        }

        private void txtB_confirmar_senha_cadastro_TextChanged(object sender, EventArgs e)
        {
            txtB_confirmar_senha_cadastro.PasswordChar = '*';
        }

        private void lbl_senha_cadastro_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // EXIBE A IMAGEM DE PERFIL CORRESPONDENTE COM O CHECK-BOX SELECIONADO
            pictureBox_outros.Visible = false;
            pictureBox_masculino.Visible = false;
            pictureBox_feminino.Visible = true;
        }

        private void checkBox_outros_CheckedChanged(object sender, EventArgs e)
        {
            // EXIBE A IMAGEM DE PERFIL CORRESPONDENTE COM O CHECK-BOX SELECIONADO
            pictureBox_feminino.Visible = false;
            pictureBox_masculino.Visible = false;
            pictureBox_outros.Visible = true;
        }

        private void checkBox_masculino_CheckedChanged(object sender, EventArgs e)
        {
            // EXIBE A IMAGEM DE PERFIL CORRESPONDENTE COM O CHECK-BOX SELECIONADO
            pictureBox_feminino.Visible = false;
            pictureBox_outros.Visible = false;
            pictureBox_masculino.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pagina_dois_cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
