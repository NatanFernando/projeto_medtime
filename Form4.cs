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
            pagina_cinco_quando_tomar pagina_Cinco_Quando_Tomar = new pagina_cinco_quando_tomar();
            pagina_Cinco_Quando_Tomar.Show();
        }

        private void cHECKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ESTE MENU ABRE A PÁGINA "CHECK-LIST"
            pagina_seis_check_list pagina_Seis_Check_List = new pagina_seis_check_list();
            pagina_Seis_Check_List.Show();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
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
            string nome = txtB_nome_do_remedio.Text;
            int total = int.Parse(txtB_quantidade_por_dia.Text); //QUANTAS MLS OU UNIDADE POR DIA
            int vezes = int.Parse(txtB_quantas_vezes_ao_dia.Text); //QUANTAS VEZES POR DIA
            int quanidade_vez = int.Parse(txtB_quantidade_cada_vez.Text); //QUANTIDADE TOMADA POR VEZ

            int dias = total / (vezes * quanidade_vez);

            lbl_resultado.Visible = true;   

            if ((60 % dias) == 0)
            {
                lbl_resultado.Text = ("O REMÉDIO ACABARÁ EM " + dias + " DIAS");
            }
            else
            {
                int dias_completos = (60 / dias);
                lbl_resultado.Text = ("Total de dias" + dias_completos);
            }
        }

        private void checkBox_Unidade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Unidade.Checked)
            {
                lbl_quantidade_por_dia.Text = ("QUANTAS UNIDADES POSSUI?");
            }
        }

        private void checkBox2_Miligrama_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_Miligrama.Checked)          
            {
                lbl_quantidade_por_dia.Text = ("QUANTAS MILIGRAMAS POSSUI?");
            }
        }

        private void lbl_quantidade_por_dia_Click(object sender, EventArgs e)
        {

        }
    }
}
