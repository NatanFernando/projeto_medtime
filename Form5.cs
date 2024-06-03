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
    public partial class pagina_cinco_quando_tomar : Form
    {
        public pagina_cinco_quando_tomar()
        {
            InitializeComponent();
        }

        private void qUANDOCOMPRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagina_quatro_quando_comprar pagina_Quatro_Quando_Comprar = new pagina_quatro_quando_comprar();
            pagina_Quatro_Quando_Comprar.Show();
        }

        private void cHECKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagina_seis_check_list pagina_Seis_Check_List = new pagina_seis_check_list();
            pagina_Seis_Check_List.Show();
        }
    }
}
