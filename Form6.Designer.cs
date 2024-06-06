namespace projeto_medtime
{
    partial class pagina_seis_check_list
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
            label_insira_o_nome_do_remedio = new Label();
            textBox_nome_do_remedio = new TextBox();
            checkedListBox_lista = new CheckedListBox();
            label_lista_de_comprar = new Label();
            btn_inserir = new Button();
            button_limpar = new Button();
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
            qUANDOTOMARToolStripMenuItem.Click += qUANDOTOMARToolStripMenuItem_Click;
            // 
            // cHECKLISTToolStripMenuItem
            // 
            cHECKLISTToolStripMenuItem.ForeColor = SystemColors.Window;
            cHECKLISTToolStripMenuItem.Name = "cHECKLISTToolStripMenuItem";
            cHECKLISTToolStripMenuItem.Size = new Size(150, 25);
            cHECKLISTToolStripMenuItem.Text = "GERENCIAMENTO";
            cHECKLISTToolStripMenuItem.Click += cHECKLISTToolStripMenuItem_Click;
            // 
            // label_insira_o_nome_do_remedio
            // 
            label_insira_o_nome_do_remedio.AutoSize = true;
            label_insira_o_nome_do_remedio.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_insira_o_nome_do_remedio.ForeColor = SystemColors.Window;
            label_insira_o_nome_do_remedio.Location = new Point(233, 81);
            label_insira_o_nome_do_remedio.Name = "label_insira_o_nome_do_remedio";
            label_insira_o_nome_do_remedio.Size = new Size(474, 30);
            label_insira_o_nome_do_remedio.TabIndex = 3;
            label_insira_o_nome_do_remedio.Text = "INSIRA O REMÉDIO QUE DEVE COMPRAR:";
            label_insira_o_nome_do_remedio.Click += label_insira_o_nome_do_remedio_Click;
            // 
            // textBox_nome_do_remedio
            // 
            textBox_nome_do_remedio.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_nome_do_remedio.ForeColor = SystemColors.WindowFrame;
            textBox_nome_do_remedio.Location = new Point(264, 130);
            textBox_nome_do_remedio.Name = "textBox_nome_do_remedio";
            textBox_nome_do_remedio.Size = new Size(411, 31);
            textBox_nome_do_remedio.TabIndex = 4;
            textBox_nome_do_remedio.TextChanged += textBox1_TextChanged;
            // 
            // checkedListBox_lista
            // 
            checkedListBox_lista.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox_lista.ForeColor = SystemColors.WindowFrame;
            checkedListBox_lista.FormattingEnabled = true;
            checkedListBox_lista.Location = new Point(167, 288);
            checkedListBox_lista.Name = "checkedListBox_lista";
            checkedListBox_lista.Size = new Size(606, 186);
            checkedListBox_lista.TabIndex = 6;
            // 
            // label_lista_de_comprar
            // 
            label_lista_de_comprar.AutoSize = true;
            label_lista_de_comprar.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_lista_de_comprar.ForeColor = SystemColors.Window;
            label_lista_de_comprar.Location = new Point(269, 246);
            label_lista_de_comprar.Name = "label_lista_de_comprar";
            label_lista_de_comprar.Size = new Size(406, 30);
            label_lista_de_comprar.TabIndex = 7;
            label_lista_de_comprar.Text = "LISTA DOS REMÉDIOS A COMPRAR:\r\n";
            // 
            // btn_inserir
            // 
            btn_inserir.BackColor = Color.CornflowerBlue;
            btn_inserir.BackgroundImageLayout = ImageLayout.None;
            btn_inserir.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_inserir.ForeColor = SystemColors.Window;
            btn_inserir.Location = new Point(410, 180);
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Size = new Size(122, 45);
            btn_inserir.TabIndex = 8;
            btn_inserir.Text = "INSERIR";
            btn_inserir.UseVisualStyleBackColor = false;
            btn_inserir.Click += btn_inserir_Click;
            // 
            // button_limpar
            // 
            button_limpar.BackColor = Color.CornflowerBlue;
            button_limpar.BackgroundImageLayout = ImageLayout.None;
            button_limpar.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_limpar.ForeColor = SystemColors.Window;
            button_limpar.Location = new Point(410, 493);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(122, 45);
            button_limpar.TabIndex = 9;
            button_limpar.Text = "LIMPAR";
            button_limpar.UseVisualStyleBackColor = false;
            button_limpar.Click += button_limpar_Click;
            // 
            // pagina_seis_check_list
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(button_limpar);
            Controls.Add(btn_inserir);
            Controls.Add(label_lista_de_comprar);
            Controls.Add(checkedListBox_lista);
            Controls.Add(textBox_nome_do_remedio);
            Controls.Add(label_insira_o_nome_do_remedio);
            Controls.Add(menuStrip1);
            Name = "pagina_seis_check_list";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHECK-LIST";
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
        private Label label_insira_o_nome_do_remedio;
        private TextBox textBox_nome_do_remedio;
        private CheckedListBox checkedListBox_lista;
        private Label label_lista_de_comprar;
        private Button btn_inserir;
        private Button button_limpar;
    }
}