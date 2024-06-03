namespace projeto_medtime
{
    partial class pagina_cinco_quando_tomar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            qUANDOCOMPRARToolStripMenuItem = new ToolStripMenuItem();
            qUANDOTOMARToolStripMenuItem = new ToolStripMenuItem();
            cHECKLISTToolStripMenuItem = new ToolStripMenuItem();
            lbl_nome_do_remedio = new Label();
            lbl_quantidade_por_dia = new Label();
            txtB_quantidade_por_dia = new TextBox();
            checkBox2_Miligrama = new CheckBox();
            checkBox_Unidade = new CheckBox();
            checkBox_sim = new CheckBox();
            checkBox_nao = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { qUANDOCOMPRARToolStripMenuItem, qUANDOTOMARToolStripMenuItem, cHECKLISTToolStripMenuItem });
            menuStrip1.Location = new Point(222, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(444, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // qUANDOCOMPRARToolStripMenuItem
            // 
            qUANDOCOMPRARToolStripMenuItem.ForeColor = SystemColors.Window;
            qUANDOCOMPRARToolStripMenuItem.Name = "qUANDOCOMPRARToolStripMenuItem";
            qUANDOCOMPRARToolStripMenuItem.Size = new Size(175, 25);
            qUANDOCOMPRARToolStripMenuItem.Text = "QUANDO COMPRAR?";
            qUANDOCOMPRARToolStripMenuItem.Click += qUANDOCOMPRARToolStripMenuItem_Click;
            // 
            // qUANDOTOMARToolStripMenuItem
            // 
            qUANDOTOMARToolStripMenuItem.ForeColor = SystemColors.Window;
            qUANDOTOMARToolStripMenuItem.Name = "qUANDOTOMARToolStripMenuItem";
            qUANDOTOMARToolStripMenuItem.Size = new Size(152, 25);
            qUANDOTOMARToolStripMenuItem.Text = "QUANDO TOMAR?";
            // 
            // cHECKLISTToolStripMenuItem
            // 
            cHECKLISTToolStripMenuItem.ForeColor = SystemColors.Window;
            cHECKLISTToolStripMenuItem.Name = "cHECKLISTToolStripMenuItem";
            cHECKLISTToolStripMenuItem.Size = new Size(109, 25);
            cHECKLISTToolStripMenuItem.Text = "CHECK-LIST";
            cHECKLISTToolStripMenuItem.Click += cHECKLISTToolStripMenuItem_Click;
            // 
            // lbl_nome_do_remedio
            // 
            lbl_nome_do_remedio.AutoSize = true;
            lbl_nome_do_remedio.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome_do_remedio.ForeColor = SystemColors.Window;
            lbl_nome_do_remedio.Location = new Point(126, 88);
            lbl_nome_do_remedio.Name = "lbl_nome_do_remedio";
            lbl_nome_do_remedio.Size = new Size(345, 26);
            lbl_nome_do_remedio.TabIndex = 8;
            lbl_nome_do_remedio.Text = "JÁ ESTAVA TOMANDO O REMÉDIO?";
            // 
            // lbl_quantidade_por_dia
            // 
            lbl_quantidade_por_dia.AutoSize = true;
            lbl_quantidade_por_dia.Font = new Font("Franklin Gothic Heavy", 15.75F);
            lbl_quantidade_por_dia.ForeColor = SystemColors.Window;
            lbl_quantidade_por_dia.Location = new Point(126, 216);
            lbl_quantidade_por_dia.Name = "lbl_quantidade_por_dia";
            lbl_quantidade_por_dia.Size = new Size(398, 26);
            lbl_quantidade_por_dia.TabIndex = 10;
            lbl_quantidade_por_dia.Text = "QUANTAS(OS) UNIDADES/ML's POSSUI?";
            // 
            // txtB_quantidade_por_dia
            // 
            txtB_quantidade_por_dia.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_quantidade_por_dia.ForeColor = SystemColors.WindowFrame;
            txtB_quantidade_por_dia.Location = new Point(126, 245);
            txtB_quantidade_por_dia.Name = "txtB_quantidade_por_dia";
            txtB_quantidade_por_dia.Size = new Size(656, 31);
            txtB_quantidade_por_dia.TabIndex = 11;
            // 
            // checkBox2_Miligrama
            // 
            checkBox2_Miligrama.AutoSize = true;
            checkBox2_Miligrama.Font = new Font("Franklin Gothic Heavy", 15.75F);
            checkBox2_Miligrama.ForeColor = SystemColors.Window;
            checkBox2_Miligrama.Location = new Point(464, 172);
            checkBox2_Miligrama.Name = "checkBox2_Miligrama";
            checkBox2_Miligrama.Size = new Size(146, 30);
            checkBox2_Miligrama.TabIndex = 15;
            checkBox2_Miligrama.Text = "MILIGRAMA";
            checkBox2_Miligrama.UseVisualStyleBackColor = true;
            // 
            // checkBox_Unidade
            // 
            checkBox_Unidade.AutoSize = true;
            checkBox_Unidade.Font = new Font("Franklin Gothic Heavy", 15.75F);
            checkBox_Unidade.ForeColor = SystemColors.Window;
            checkBox_Unidade.Location = new Point(304, 172);
            checkBox_Unidade.Name = "checkBox_Unidade";
            checkBox_Unidade.Size = new Size(119, 30);
            checkBox_Unidade.TabIndex = 14;
            checkBox_Unidade.Text = "UNIDADE";
            checkBox_Unidade.UseVisualStyleBackColor = true;
            // 
            // checkBox_sim
            // 
            checkBox_sim.AutoSize = true;
            checkBox_sim.Font = new Font("Franklin Gothic Heavy", 15.75F);
            checkBox_sim.ForeColor = SystemColors.Window;
            checkBox_sim.Location = new Point(354, 126);
            checkBox_sim.Name = "checkBox_sim";
            checkBox_sim.Size = new Size(69, 30);
            checkBox_sim.TabIndex = 16;
            checkBox_sim.Text = "SIM";
            checkBox_sim.UseVisualStyleBackColor = true;
            // 
            // checkBox_nao
            // 
            checkBox_nao.AutoSize = true;
            checkBox_nao.Font = new Font("Franklin Gothic Heavy", 15.75F);
            checkBox_nao.ForeColor = SystemColors.Window;
            checkBox_nao.Location = new Point(464, 126);
            checkBox_nao.Name = "checkBox_nao";
            checkBox_nao.Size = new Size(73, 30);
            checkBox_nao.TabIndex = 17;
            checkBox_nao.Text = "NÃO";
            checkBox_nao.UseVisualStyleBackColor = true;
            // 
            // pagina_cinco_quando_tomar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(checkBox_nao);
            Controls.Add(checkBox_sim);
            Controls.Add(checkBox2_Miligrama);
            Controls.Add(checkBox_Unidade);
            Controls.Add(txtB_quantidade_por_dia);
            Controls.Add(lbl_quantidade_por_dia);
            Controls.Add(lbl_nome_do_remedio);
            Controls.Add(menuStrip1);
            Location = new Point(222, 9);
            Name = "pagina_cinco_quando_tomar";
            Text = "QUANDO TOMAR?";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem qUANDOCOMPRARToolStripMenuItem;
        private ToolStripMenuItem qUANDOTOMARToolStripMenuItem;
        private ToolStripMenuItem cHECKLISTToolStripMenuItem;
        private Label lbl_nome_do_remedio;
        private Label lbl_quantidade_por_dia;
        private TextBox txtB_quantidade_por_dia;
        private CheckBox checkBox2_Miligrama;
        private CheckBox checkBox_Unidade;
        private CheckBox checkBox_sim;
        private CheckBox checkBox_nao;
    }
}