using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeto_medtime
{
    public partial class pagina_quatro_quando_comprar : Form
    {
        public pagina_quatro_quando_comprar()
        {
            InitializeComponent();

        }

        private void qUANDOTOMARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ESTE MENU ABRE A PÁGINA "QUANDO TOMAR?"
            pagina_cinco_quando_tomar pagina_Cinco_Quando_Tomar = new pagina_cinco_quando_tomar();
            pagina_Cinco_Quando_Tomar.Show();
        }

        private void cHECKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ESTE MENU ABRE A PÁGINA "CHECK-LIST"
            pagina_seis_check_list pagina_Seis_Check_List = new pagina_seis_check_list();
            pagina_Seis_Check_List.Show();
        }

        public void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ESTE BOTÃO VOLTA PARA PÁGINA "MENU"

        }

        private void qUANDOCOMPRARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagina_quatro_quando_comprar_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nome_cadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
