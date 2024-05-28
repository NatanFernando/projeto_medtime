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
    }
}
