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
    public partial class pagina_quatro_quando_comprar : Form
    {
        public pagina_quatro_quando_comprar()
        {
            InitializeComponent();
        }

        private void qUANDOTOMARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagina_cinco_quando_tomar pagina_Cinco_Quando_Tomar = new pagina_cinco_quando_tomar();
            pagina_Cinco_Quando_Tomar.Show();
        }

        private void cHECKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagina_seis_check_list pagina_Seis_Check_List = new pagina_seis_check_list();
            pagina_Seis_Check_List.ShowDialog();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
