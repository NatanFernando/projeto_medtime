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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagina_cinco_quando_tomar));
            menuStrip1 = new MenuStrip();
            qUANDOCOMPRARToolStripMenuItem = new ToolStripMenuItem();
            qUANDOTOMARToolStripMenuItem = new ToolStripMenuItem();
            cHECKLISTToolStripMenuItem = new ToolStripMenuItem();
            lbl_nome_do_remedio_ja_tomou = new Label();
            txtB_nome_do_remedio = new TextBox();
            label_intervalo_remedio = new Label();
            textBox_intervalo_remedio = new TextBox();
            label_ultima_vez = new Label();
            textBox_ultima_vez = new TextBox();
            checkBox2_Miligrama_ja_tomou = new CheckBox();
            checkBox_Unidade_ja_tomou = new CheckBox();
            btn_calcular_ja_tomou = new Button();
            listbox_horarios = new ListBox();
            label_hora = new Label();
            label_minutos = new Label();
            textBox_minutos = new TextBox();
            pictureBox_ajuda_menu = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ajuda_menu).BeginInit();
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
            // lbl_nome_do_remedio_ja_tomou
            // 
            lbl_nome_do_remedio_ja_tomou.AutoSize = true;
            lbl_nome_do_remedio_ja_tomou.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome_do_remedio_ja_tomou.ForeColor = SystemColors.Window;
            lbl_nome_do_remedio_ja_tomou.Location = new Point(124, 70);
            lbl_nome_do_remedio_ja_tomou.Name = "lbl_nome_do_remedio_ja_tomou";
            lbl_nome_do_remedio_ja_tomou.Size = new Size(334, 30);
            lbl_nome_do_remedio_ja_tomou.TabIndex = 8;
            lbl_nome_do_remedio_ja_tomou.Text = "QUAL O NOME DO REMÉDIO?";
            // 
            // txtB_nome_do_remedio
            // 
            txtB_nome_do_remedio.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_nome_do_remedio.ForeColor = SystemColors.WindowFrame;
            txtB_nome_do_remedio.Location = new Point(124, 103);
            txtB_nome_do_remedio.Name = "txtB_nome_do_remedio";
            txtB_nome_do_remedio.Size = new Size(656, 29);
            txtB_nome_do_remedio.TabIndex = 9;
            // 
            // label_intervalo_remedio
            // 
            label_intervalo_remedio.AutoSize = true;
            label_intervalo_remedio.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_intervalo_remedio.ForeColor = SystemColors.Window;
            label_intervalo_remedio.Location = new Point(124, 187);
            label_intervalo_remedio.Name = "label_intervalo_remedio";
            label_intervalo_remedio.Size = new Size(458, 30);
            label_intervalo_remedio.TabIndex = 10;
            label_intervalo_remedio.Text = "QUAL INTERVALO VOCÊ INGERI / TOMA?";
            label_intervalo_remedio.Click += label_intervalo_remedio_Click;
            // 
            // textBox_intervalo_remedio
            // 
            textBox_intervalo_remedio.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_intervalo_remedio.ForeColor = SystemColors.WindowFrame;
            textBox_intervalo_remedio.Location = new Point(124, 220);
            textBox_intervalo_remedio.Name = "textBox_intervalo_remedio";
            textBox_intervalo_remedio.Size = new Size(656, 29);
            textBox_intervalo_remedio.TabIndex = 11;
            // 
            // label_ultima_vez
            // 
            label_ultima_vez.AutoSize = true;
            label_ultima_vez.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ultima_vez.ForeColor = SystemColors.Window;
            label_ultima_vez.Location = new Point(124, 271);
            label_ultima_vez.Name = "label_ultima_vez";
            label_ultima_vez.Size = new Size(633, 30);
            label_ultima_vez.TabIndex = 12;
            label_ultima_vez.Text = "QUE HORAS VOCÊ TOMOU / INGERIU PELA ÚLTIMA VEZ?";
            label_ultima_vez.Click += label_ultima_vez_Click;
            // 
            // textBox_ultima_vez
            // 
            textBox_ultima_vez.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ultima_vez.ForeColor = SystemColors.WindowFrame;
            textBox_ultima_vez.Location = new Point(278, 316);
            textBox_ultima_vez.Name = "textBox_ultima_vez";
            textBox_ultima_vez.Size = new Size(159, 29);
            textBox_ultima_vez.TabIndex = 13;
            // 
            // checkBox2_Miligrama_ja_tomou
            // 
            checkBox2_Miligrama_ja_tomou.AutoSize = true;
            checkBox2_Miligrama_ja_tomou.Font = new Font("Franklin Gothic Heavy", 14.25F);
            checkBox2_Miligrama_ja_tomou.ForeColor = SystemColors.Window;
            checkBox2_Miligrama_ja_tomou.Location = new Point(497, 147);
            checkBox2_Miligrama_ja_tomou.Name = "checkBox2_Miligrama_ja_tomou";
            checkBox2_Miligrama_ja_tomou.Size = new Size(104, 28);
            checkBox2_Miligrama_ja_tomou.TabIndex = 15;
            checkBox2_Miligrama_ja_tomou.Text = "MG / ML";
            checkBox2_Miligrama_ja_tomou.UseVisualStyleBackColor = true;
            checkBox2_Miligrama_ja_tomou.CheckedChanged += checkBox2_Miligrama_ja_tomou_CheckedChanged;
            // 
            // checkBox_Unidade_ja_tomou
            // 
            checkBox_Unidade_ja_tomou.AutoSize = true;
            checkBox_Unidade_ja_tomou.Font = new Font("Franklin Gothic Heavy", 14.25F);
            checkBox_Unidade_ja_tomou.ForeColor = SystemColors.Window;
            checkBox_Unidade_ja_tomou.Location = new Point(318, 147);
            checkBox_Unidade_ja_tomou.Name = "checkBox_Unidade_ja_tomou";
            checkBox_Unidade_ja_tomou.Size = new Size(109, 28);
            checkBox_Unidade_ja_tomou.TabIndex = 14;
            checkBox_Unidade_ja_tomou.Text = "UNIDADE";
            checkBox_Unidade_ja_tomou.UseVisualStyleBackColor = true;
            checkBox_Unidade_ja_tomou.CheckedChanged += checkBox_Unidade_ja_tomou_CheckedChanged;
            // 
            // btn_calcular_ja_tomou
            // 
            btn_calcular_ja_tomou.BackColor = Color.CornflowerBlue;
            btn_calcular_ja_tomou.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_calcular_ja_tomou.ForeColor = SystemColors.Window;
            btn_calcular_ja_tomou.Location = new Point(390, 367);
            btn_calcular_ja_tomou.Name = "btn_calcular_ja_tomou";
            btn_calcular_ja_tomou.Size = new Size(124, 35);
            btn_calcular_ja_tomou.TabIndex = 16;
            btn_calcular_ja_tomou.Text = "CALCULAR";
            btn_calcular_ja_tomou.UseVisualStyleBackColor = false;
            btn_calcular_ja_tomou.Click += btn_calcular_ja_tomou_Click;
            // 
            // listbox_horarios
            // 
            listbox_horarios.BackColor = Color.LightSteelBlue;
            listbox_horarios.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_horarios.ForeColor = SystemColors.Window;
            listbox_horarios.FormattingEnabled = true;
            listbox_horarios.ItemHeight = 34;
            listbox_horarios.Location = new Point(209, 452);
            listbox_horarios.Name = "listbox_horarios";
            listbox_horarios.Size = new Size(517, 72);
            listbox_horarios.TabIndex = 17;
            listbox_horarios.SelectedIndexChanged += listbox_horarios_SelectedIndexChanged;
            // 
            // label_hora
            // 
            label_hora.AutoSize = true;
            label_hora.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_hora.ForeColor = SystemColors.Window;
            label_hora.Location = new Point(189, 317);
            label_hora.Name = "label_hora";
            label_hora.Size = new Size(74, 26);
            label_hora.TabIndex = 18;
            label_hora.Text = "HORA:";
            // 
            // label_minutos
            // 
            label_minutos.AutoSize = true;
            label_minutos.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_minutos.ForeColor = SystemColors.Window;
            label_minutos.Location = new Point(452, 317);
            label_minutos.Name = "label_minutos";
            label_minutos.Size = new Size(109, 26);
            label_minutos.TabIndex = 19;
            label_minutos.Text = "MINUTOS:";
            // 
            // textBox_minutos
            // 
            textBox_minutos.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_minutos.ForeColor = SystemColors.WindowFrame;
            textBox_minutos.Location = new Point(567, 317);
            textBox_minutos.Name = "textBox_minutos";
            textBox_minutos.Size = new Size(159, 29);
            textBox_minutos.TabIndex = 20;
            // 
            // pictureBox_ajuda_menu
            // 
            pictureBox_ajuda_menu.Image = (Image)resources.GetObject("pictureBox_ajuda_menu.Image");
            pictureBox_ajuda_menu.Location = new Point(847, 524);
            pictureBox_ajuda_menu.Name = "pictureBox_ajuda_menu";
            pictureBox_ajuda_menu.Size = new Size(25, 25);
            pictureBox_ajuda_menu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_ajuda_menu.TabIndex = 21;
            pictureBox_ajuda_menu.TabStop = false;
            pictureBox_ajuda_menu.Click += pictureBox_ajuda_menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(209, 419);
            label1.Name = "label1";
            label1.Size = new Size(315, 30);
            label1.TabIndex = 22;
            label1.Text = "NAS PRÓXIMAS 24 HORAS:";
            // 
            // pagina_cinco_quando_tomar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(label1);
            Controls.Add(pictureBox_ajuda_menu);
            Controls.Add(textBox_minutos);
            Controls.Add(label_minutos);
            Controls.Add(label_hora);
            Controls.Add(listbox_horarios);
            Controls.Add(btn_calcular_ja_tomou);
            Controls.Add(checkBox2_Miligrama_ja_tomou);
            Controls.Add(checkBox_Unidade_ja_tomou);
            Controls.Add(textBox_ultima_vez);
            Controls.Add(label_ultima_vez);
            Controls.Add(textBox_intervalo_remedio);
            Controls.Add(label_intervalo_remedio);
            Controls.Add(txtB_nome_do_remedio);
            Controls.Add(lbl_nome_do_remedio_ja_tomou);
            Controls.Add(menuStrip1);
            Location = new Point(222, 9);
            Name = "pagina_cinco_quando_tomar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUANDO TOMAR?";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ajuda_menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem qUANDOCOMPRARToolStripMenuItem;
        private ToolStripMenuItem qUANDOTOMARToolStripMenuItem;
        private ToolStripMenuItem cHECKLISTToolStripMenuItem;
        private Label lbl_nome_do_remedio_ja_tomou;
        private TextBox txtB_nome_do_remedio;
        private Label label_intervalo_remedio;
        private TextBox textBox_intervalo_remedio;
        private Label label_ultima_vez;
        private TextBox textBox_ultima_vez;
        private CheckBox checkBox2_Miligrama_ja_tomou;
        private CheckBox checkBox_Unidade_ja_tomou;
        private Button btn_calcular_ja_tomou;
        private ListBox listbox_horarios;
        private Label label_hora;
        private Label label_minutos;
        private TextBox textBox_minutos;
        private PictureBox pictureBox_ajuda_menu;
        private Label label1;
    }
}