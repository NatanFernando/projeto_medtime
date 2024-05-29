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
    public partial class pagina_tres_menu : Form
    {

        public pagina_tres_menu(String Menu)
        {
            InitializeComponent();

            lbl_apresentacao_menu.Text = ("Olá, seja bem vindo(a) " + Menu + "! Como posso lhe ajudar?");
        }

        private void lbl_apresentacao_menu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_calculo_de_compra_menu_Click(object sender, EventArgs e)
        {
            // ESTE BOTÃO DIRECIONA PARA A PÁGINA "QUANDO COMPRAR?"
            pagina_quatro_quando_comprar pagina_Quatro_Quando_Comprar = new pagina_quatro_quando_comprar();
            pagina_Quatro_Quando_Comprar.Show();
        }

        private void btn_calculo_de_horario_menu_Click(object sender, EventArgs e)
        {
            // ESTE BOTÃO DIRECIONA PARA A PÁGINA "QUANDO TOMAR?"
            pagina_cinco_quando_tomar pagina_Cinco_Quando_Tomar = new pagina_cinco_quando_tomar();
            pagina_Cinco_Quando_Tomar.Show();
        }

        private void btn_check_list_menu_Click(object sender, EventArgs e)
        {
            // ESTE BOTÃO DIRECIONA PARA A PÁGINA "CHECK-LIST"
            pagina_seis_check_list pagina_Seis_Check_List = new pagina_seis_check_list();
            pagina_Seis_Check_List.Show();
        }

        private void pagina_tres_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
