using System;
using System.Collections;
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
    public partial class pagina_seis_check_list : Form
    {
        public pagina_seis_check_list()
        {
            InitializeComponent();
        }

        private void qUANDOCOMPRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagina_quatro_quando_comprar pagina_Quatro_Quando_Comprar = new pagina_quatro_quando_comprar();
            pagina_Quatro_Quando_Comprar.Closed += (s, args) => this.Close();
            pagina_Quatro_Quando_Comprar.Show();
        }

        private void qUANDOTOMARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagina_cinco_quando_tomar pagina_Cinco_Quando_Tomar = new pagina_cinco_quando_tomar();
            pagina_Cinco_Quando_Tomar.Closed += (s, args) => this.Close();
            pagina_Cinco_Quando_Tomar.Show();
        }

        private void cHECKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {

            ArrayList lista_remedios = new ArrayList();

            string nome_remedio;
            nome_remedio = textBox_nome_do_remedio.Text;
            lista_remedios.Add(nome_remedio);

            foreach (string i in lista_remedios)
            {
                checkedListBox_lista.Items.Add(nome_remedio);
            }
            textBox_nome_do_remedio.Clear();
        }

        private void label_insira_o_nome_do_remedio_Click(object sender, EventArgs e)
        {

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            checkedListBox_lista.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
