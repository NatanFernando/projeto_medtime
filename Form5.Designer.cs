﻿namespace projeto_medtime
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
            vOLTARToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { qUANDOCOMPRARToolStripMenuItem, qUANDOTOMARToolStripMenuItem, cHECKLISTToolStripMenuItem, vOLTARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // qUANDOCOMPRARToolStripMenuItem
            // 
            qUANDOCOMPRARToolStripMenuItem.Name = "qUANDOCOMPRARToolStripMenuItem";
            qUANDOCOMPRARToolStripMenuItem.Size = new Size(135, 20);
            qUANDOCOMPRARToolStripMenuItem.Text = "QUANDO COMPRAR?";
            // 
            // qUANDOTOMARToolStripMenuItem
            // 
            qUANDOTOMARToolStripMenuItem.Name = "qUANDOTOMARToolStripMenuItem";
            qUANDOTOMARToolStripMenuItem.Size = new Size(118, 20);
            qUANDOTOMARToolStripMenuItem.Text = "QUANDO TOMAR?";
            // 
            // cHECKLISTToolStripMenuItem
            // 
            cHECKLISTToolStripMenuItem.Name = "cHECKLISTToolStripMenuItem";
            cHECKLISTToolStripMenuItem.Size = new Size(83, 20);
            cHECKLISTToolStripMenuItem.Text = "CHECK-LIST";
            // 
            // vOLTARToolStripMenuItem
            // 
            vOLTARToolStripMenuItem.Name = "vOLTARToolStripMenuItem";
            vOLTARToolStripMenuItem.Size = new Size(60, 20);
            vOLTARToolStripMenuItem.Text = "VOLTAR";
            // 
            // pagina_cinco_quando_tomar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(menuStrip1);
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
        private ToolStripMenuItem vOLTARToolStripMenuItem;
    }
}