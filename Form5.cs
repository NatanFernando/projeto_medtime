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

            listbox_horarios.Visible = false;

        }

        private void qUANDOCOMPRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagina_quatro_quando_comprar pagina_Quatro_Quando_Comprar = new pagina_quatro_quando_comprar();
            pagina_Quatro_Quando_Comprar.Closed += (s, args) => this.Close();
            pagina_Quatro_Quando_Comprar.Show();
        }

        private void cHECKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagina_seis_check_list pagina_Seis_Check_List = new pagina_seis_check_list();
            pagina_Seis_Check_List.Closed += (s, args) => this.Close();
            pagina_Seis_Check_List.Show();
        }

        private void btn_calcular_ja_tomou_Click(object sender, EventArgs e)
        {
            string nome_remedio = txtB_nome_do_remedio.Text;
            int intervalo = int.Parse(textBox_intervalo_remedio.Text);
            int primeira_hora = int.Parse(textBox_ultima_vez.Text);
            if (textBox_minutos.Text == "")
            {
                MessageBox.Show("INSIRA OS MINUTOS!");
                textBox_minutos.Clear();
            }
            else if (textBox_minutos.Text != "")
            {
                int minutos = int.Parse(textBox_minutos.Text);

                int vezes = (24 / intervalo);

                for (int i = 1; i <= vezes; i++)
                {
                    primeira_hora = primeira_hora + intervalo;
                    if (primeira_hora > 24)
                    {
                        primeira_hora = primeira_hora - 24;
                    }
                    if (minutos == 0 || Convert.ToString(minutos) == "")
                    {
                        listbox_horarios.Items.Add("Hora: " + primeira_hora + "H");
                    }
                    else if (minutos > 0)
                    {
                        listbox_horarios.Items.Add("Hora: " + primeira_hora + "H E " + minutos + " MINUTOS!");
                    }
                }

                listbox_horarios.Visible = true;
            }
        }

        private void checkBox_Unidade_ja_tomou_CheckedChanged(object sender, EventArgs e)
        {
            label_intervalo_remedio.Text = ("DE QUANTAS EM QUANTAS HORAS VOCÊ INGERI O REMÉDIO? ");
            label_ultima_vez.Text = ("QUANDO FOI A ÚLTIMA VEZ QUE INGERIU O REMÉDIO?");
        }

        private void label_intervalo_remedio_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_Miligrama_ja_tomou_CheckedChanged(object sender, EventArgs e)
        {
            label_intervalo_remedio.Text = ("DE QUANTAS EM QUANTAS HORAS VOCÊ TOMA O REMÉDIO?");
            label_ultima_vez.Text = ("QUANDO FOI A ÚLTIMA VEZ QUE TOMOU O REMÉDIO?");
        }

        private void listbox_horarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pagina_cinco_quando_tomar_Load(object sender, EventArgs e)
        {

        }

        private void label_ultima_vez_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_ajuda_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NÃO SE ESQUEÇA DE INCLUIR OS MINUTOS!");
        }
    }
}