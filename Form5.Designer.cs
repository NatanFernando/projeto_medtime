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
            lbl_ja_estava_tomando_o_remedio = new Label();
            lbl_quantidade_por_dia = new Label();
            txtB_quantidade_por_dia = new TextBox();
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
            menuStrip1.Size = new Size(485, 29);
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
            cHECKLISTToolStripMenuItem.Size = new Size(150, 25);
            cHECKLISTToolStripMenuItem.Text = "GERENCIAMENTO";
            cHECKLISTToolStripMenuItem.Click += cHECKLISTToolStripMenuItem_Click;
            // 
            // lbl_ja_estava_tomando_o_remedio
            // 
            lbl_ja_estava_tomando_o_remedio.AutoSize = true;
            lbl_ja_estava_tomando_o_remedio.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ja_estava_tomando_o_remedio.ForeColor = SystemColors.Window;
            lbl_ja_estava_tomando_o_remedio.Location = new Point(126, 88);
            lbl_ja_estava_tomando_o_remedio.Name = "lbl_ja_estava_tomando_o_remedio";
            lbl_ja_estava_tomando_o_remedio.Size = new Size(345, 26);
            lbl_ja_estava_tomando_o_remedio.TabIndex = 8;
            lbl_ja_estava_tomando_o_remedio.Text = "JÁ ESTAVA TOMANDO O REMÉDIO?";
            // 
            // lbl_quantidade_por_dia
            // 
            lbl_quantidade_por_dia.AutoSize = true;
            lbl_quantidade_por_dia.Font = new Font("Franklin Gothic Heavy", 15.75F);
            lbl_quantidade_por_dia.ForeColor = SystemColors.Window;
            lbl_quantidade_por_dia.Location = new Point(126, 168);
            lbl_quantidade_por_dia.Name = "lbl_quantidade_por_dia";
            lbl_quantidade_por_dia.Size = new Size(398, 26);
            lbl_quantidade_por_dia.TabIndex = 10;
            lbl_quantidade_por_dia.Text = "QUANTAS(OS) UNIDADES/ML's POSSUI?";
            // 
            // txtB_quantidade_por_dia
            // 
            txtB_quantidade_por_dia.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_quantidade_por_dia.ForeColor = SystemColors.WindowFrame;
            txtB_quantidade_por_dia.Location = new Point(126, 197);
            txtB_quantidade_por_dia.Name = "txtB_quantidade_por_dia";
            txtB_quantidade_por_dia.Size = new Size(656, 31);
            txtB_quantidade_por_dia.TabIndex = 11;
            // 
            // checkBox_sim
            // 
            checkBox_sim.AutoSize = true;
            checkBox_sim.Font = new Font("Franklin Gothic Heavy", 15.75F);
            checkBox_sim.ForeColor = SystemColors.Window;
            checkBox_sim.Location = new Point(126, 126);
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
            checkBox_nao.Location = new Point(211, 126);
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
            Controls.Add(txtB_quantidade_por_dia);
            Controls.Add(lbl_quantidade_por_dia);
            Controls.Add(lbl_ja_estava_tomando_o_remedio);
            Controls.Add(menuStrip1);
            Location = new Point(222, 9);
            Name = "pagina_cinco_quando_tomar";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lbl_ja_estava_tomando_o_remedio;
        private Label lbl_quantidade_por_dia;
        private TextBox txtB_quantidade_por_dia;
        private CheckBox checkBox_sim;
        private CheckBox checkBox_nao;
    }
}