using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

            lbl_resultado.Visible = false;
        }

        private void qUANDOTOMARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ESTE MENU ABRE A PÁGINA "QUANDO TOMAR?"
            this.Hide();
            pagina_cinco_quando_tomar pagina_Cinco_Quando_Tomar = new pagina_cinco_quando_tomar();
            pagina_Cinco_Quando_Tomar.Closed += (s, args) => this.Close();
            pagina_Cinco_Quando_Tomar.Show();
        }

        private void cHECKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ESTE MENU ABRE A PÁGINA "CHECK-LIST"
            this.Hide();
            pagina_seis_check_list pagina_Seis_Check_List = new pagina_seis_check_list();
            pagina_Seis_Check_List.Closed += (s, args) => this.Close();
            pagina_Seis_Check_List.Show();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtB_nome_do_remedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_quantas_vezes_ao_dia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string nome = txtB_nome_do_remedio.Text; //NOME DO REMÉDIO
            double total = Convert.ToDouble(txtB_quantidade_por_dia.Text); //QUANTAS MLS OU UNIDADE POR DIA
            double vezes = Convert.ToDouble(txtB_quantas_vezes_ao_dia.Text); //QUANTAS VEZES POR DIA
            double quantidade_vez = Convert.ToDouble(txtB_quantidade_cada_vez.Text); //QUANTIDADE TOMADA POR VEZ

            double dias = total / (vezes * quantidade_vez);
            double dose = total % (vezes * quantidade_vez);

            if (checkBox_Unidade.Checked == true)
            {
                if (dose > 0)
                {
                    lbl_resultado.Text = ("O REMÉDIO DURARÁ PARA " + Math.Floor(dias) + " DIAS E " + dose + " DOSE!");
                }
                else if (dose == 0)
                {
                    lbl_resultado.Text = ("O REMÉDIO DURARÁ PARA " + dias + " DIAS");
                }
            }
            else if (checkBox2_Miligrama.Checked == true)
            {
                if (dose > 0)
                {
                    lbl_resultado.Text = ("O REMÉDIO DURARÁ PARA " + Math.Floor(dias) + " DIAS E " + dose + " MG/ML!");
                }
                else if (dose == 0)
                {
                    lbl_resultado.Text = ("O REMÉDIO DURARÁ PARA " + dias + " DIAS");
                }
            }

            lbl_resultado.Visible = true;

        }

        private void checkBox_Unidade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Unidade.Checked)
            {
                lbl_quantidade_por_dia.Text = ("QUANTOS COMPRIMIDOS POSSUI?");
                lbl_quantidade_cada_vez.Text = ("QUANTOS COMPRIMIDOS VOCÊ INGERI POR VEZ?");
            }
        }

        private void checkBox2_Miligrama_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_Miligrama.Checked)
            {
                lbl_quantidade_por_dia.Text = ("QUANTAS MG/ML POSSUI?");
                lbl_quantidade_cada_vez.Text = ("QUANTAS MG/ML VOCÊ TOMA POR VEZ?");
            }
        }

        private void lbl_quantidade_por_dia_Click(object sender, EventArgs e)
        {

        }

        private void lbl_quantidade_cada_vez_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_quando_tomar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            pagina_cinco_quando_tomar pagina_Cinco_Quando_Tomar = new pagina_cinco_quando_tomar();
            pagina_Cinco_Quando_Tomar.Closed += (s, args) => this.Close();
            pagina_Cinco_Quando_Tomar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
