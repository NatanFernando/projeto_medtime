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
        }

        private void btn_cadastrarme_cadastro_Click(object sender, EventArgs e)
        {
            pagina_tres_menu pagina_Tres_Menu = new pagina_tres_menu(txtB_nome_cadastro.Text);
            pagina_Tres_Menu.Show();
        }
    }
}
