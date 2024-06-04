namespace projeto_medtime
{
    partial class pagina_tres_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagina_tres_menu));
            lbl_apresentacao_menu = new Label();
            btn_calculo_de_compra_menu = new Button();
            btn_calculo_de_horario_menu = new Button();
            btn_check_list_menu = new Button();
            pictureBox1 = new PictureBox();
            pictureBox_ajuda_menu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ajuda_menu).BeginInit();
            SuspendLayout();
            // 
            // lbl_apresentacao_menu
            // 
            lbl_apresentacao_menu.AutoSize = true;
            lbl_apresentacao_menu.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_apresentacao_menu.ForeColor = SystemColors.Window;
            lbl_apresentacao_menu.Location = new Point(136, 162);
            lbl_apresentacao_menu.Name = "lbl_apresentacao_menu";
            lbl_apresentacao_menu.RightToLeft = RightToLeft.No;
            lbl_apresentacao_menu.Size = new Size(612, 30);
            lbl_apresentacao_menu.TabIndex = 0;
            lbl_apresentacao_menu.Text = "OLÁ, SEJA BEM VINDO(A)! COMO POSSO LHE AJUDAR?";
            lbl_apresentacao_menu.TextAlign = ContentAlignment.MiddleCenter;
            lbl_apresentacao_menu.Click += lbl_apresentacao_menu_Click;
            // 
            // btn_calculo_de_compra_menu
            // 
            btn_calculo_de_compra_menu.AutoSize = true;
            btn_calculo_de_compra_menu.BackColor = Color.CornflowerBlue;
            btn_calculo_de_compra_menu.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_calculo_de_compra_menu.ForeColor = SystemColors.Window;
            btn_calculo_de_compra_menu.Location = new Point(292, 230);
            btn_calculo_de_compra_menu.Name = "btn_calculo_de_compra_menu";
            btn_calculo_de_compra_menu.Size = new Size(301, 50);
            btn_calculo_de_compra_menu.TabIndex = 3;
            btn_calculo_de_compra_menu.Text = "QUANDO COMPRAR?";
            btn_calculo_de_compra_menu.UseVisualStyleBackColor = false;
            btn_calculo_de_compra_menu.Click += btn_calculo_de_compra_menu_Click;
            // 
            // btn_calculo_de_horario_menu
            // 
            btn_calculo_de_horario_menu.AutoSize = true;
            btn_calculo_de_horario_menu.BackColor = Color.CornflowerBlue;
            btn_calculo_de_horario_menu.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_calculo_de_horario_menu.ForeColor = SystemColors.Window;
            btn_calculo_de_horario_menu.Location = new Point(292, 298);
            btn_calculo_de_horario_menu.Name = "btn_calculo_de_horario_menu";
            btn_calculo_de_horario_menu.Size = new Size(301, 50);
            btn_calculo_de_horario_menu.TabIndex = 4;
            btn_calculo_de_horario_menu.Text = "QUANDO TOMAR?";
            btn_calculo_de_horario_menu.UseVisualStyleBackColor = false;
            btn_calculo_de_horario_menu.Click += btn_calculo_de_horario_menu_Click;
            // 
            // btn_check_list_menu
            // 
            btn_check_list_menu.AutoSize = true;
            btn_check_list_menu.BackColor = Color.CornflowerBlue;
            btn_check_list_menu.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_check_list_menu.ForeColor = SystemColors.Window;
            btn_check_list_menu.Location = new Point(292, 367);
            btn_check_list_menu.Name = "btn_check_list_menu";
            btn_check_list_menu.Size = new Size(301, 50);
            btn_check_list_menu.TabIndex = 5;
            btn_check_list_menu.Text = "GERENCIAMENTO";
            btn_check_list_menu.UseVisualStyleBackColor = false;
            btn_check_list_menu.Click += btn_check_list_menu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox_ajuda_menu
            // 
            pictureBox_ajuda_menu.Image = (Image)resources.GetObject("pictureBox_ajuda_menu.Image");
            pictureBox_ajuda_menu.Location = new Point(847, 524);
            pictureBox_ajuda_menu.Name = "pictureBox_ajuda_menu";
            pictureBox_ajuda_menu.Size = new Size(25, 25);
            pictureBox_ajuda_menu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_ajuda_menu.TabIndex = 16;
            pictureBox_ajuda_menu.TabStop = false;
            pictureBox_ajuda_menu.Click += pictureBox_ajuda_menu_Click;
            // 
            // pagina_tres_menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(pictureBox_ajuda_menu);
            Controls.Add(pictureBox1);
            Controls.Add(btn_check_list_menu);
            Controls.Add(btn_calculo_de_horario_menu);
            Controls.Add(btn_calculo_de_compra_menu);
            Controls.Add(lbl_apresentacao_menu);
            Name = "pagina_tres_menu";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            Load += pagina_tres_menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ajuda_menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_apresentacao_menu;
        private Button btn_calculo_de_compra_menu;
        private Button btn_calculo_de_horario_menu;
        private Button btn_check_list_menu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox_ajuda_menu;
    }
}