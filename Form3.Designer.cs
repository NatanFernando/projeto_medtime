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
            lbl_apresentacao_menu = new Label();
            btn_calculo_de_compra_menu = new Button();
            btn_calculo_de_horario_menu = new Button();
            btn_check_list_menu = new Button();
            lbl_logo_menu = new Label();
            SuspendLayout();
            // 
            // lbl_apresentacao_menu
            // 
            lbl_apresentacao_menu.AutoSize = true;
            lbl_apresentacao_menu.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_apresentacao_menu.ForeColor = SystemColors.Window;
            lbl_apresentacao_menu.Location = new Point(136, 154);
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
            btn_calculo_de_compra_menu.BackColor = Color.CornflowerBlue;
            btn_calculo_de_compra_menu.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_calculo_de_compra_menu.ForeColor = SystemColors.Window;
            btn_calculo_de_compra_menu.Location = new Point(292, 226);
            btn_calculo_de_compra_menu.Name = "btn_calculo_de_compra_menu";
            btn_calculo_de_compra_menu.Size = new Size(301, 50);
            btn_calculo_de_compra_menu.TabIndex = 3;
            btn_calculo_de_compra_menu.Text = "QUANDO COMPRAR?";
            btn_calculo_de_compra_menu.UseVisualStyleBackColor = false;
            btn_calculo_de_compra_menu.Click += btn_calculo_de_compra_menu_Click;
            // 
            // btn_calculo_de_horario_menu
            // 
            btn_calculo_de_horario_menu.BackColor = Color.CornflowerBlue;
            btn_calculo_de_horario_menu.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_calculo_de_horario_menu.ForeColor = SystemColors.Window;
            btn_calculo_de_horario_menu.Location = new Point(292, 292);
            btn_calculo_de_horario_menu.Name = "btn_calculo_de_horario_menu";
            btn_calculo_de_horario_menu.Size = new Size(301, 50);
            btn_calculo_de_horario_menu.TabIndex = 4;
            btn_calculo_de_horario_menu.Text = "QUANDO TOMAR?";
            btn_calculo_de_horario_menu.UseVisualStyleBackColor = false;
            btn_calculo_de_horario_menu.Click += btn_calculo_de_horario_menu_Click;
            // 
            // btn_check_list_menu
            // 
            btn_check_list_menu.BackColor = Color.CornflowerBlue;
            btn_check_list_menu.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_check_list_menu.ForeColor = SystemColors.Window;
            btn_check_list_menu.Location = new Point(292, 357);
            btn_check_list_menu.Name = "btn_check_list_menu";
            btn_check_list_menu.Size = new Size(301, 50);
            btn_check_list_menu.TabIndex = 5;
            btn_check_list_menu.Text = "CHECK-LIST";
            btn_check_list_menu.UseVisualStyleBackColor = false;
            btn_check_list_menu.Click += btn_check_list_menu_Click;
            // 
            // lbl_logo_menu
            // 
            lbl_logo_menu.AutoSize = true;
            lbl_logo_menu.Font = new Font("Franklin Gothic Heavy", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_logo_menu.ForeColor = SystemColors.Window;
            lbl_logo_menu.Location = new Point(380, 71);
            lbl_logo_menu.Name = "lbl_logo_menu";
            lbl_logo_menu.Size = new Size(141, 50);
            lbl_logo_menu.TabIndex = 10;
            lbl_logo_menu.Text = "MENU";
            // 
            // pagina_tres_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(lbl_logo_menu);
            Controls.Add(btn_check_list_menu);
            Controls.Add(btn_calculo_de_horario_menu);
            Controls.Add(btn_calculo_de_compra_menu);
            Controls.Add(lbl_apresentacao_menu);
            Name = "pagina_tres_menu";
            Text = "MENU";
            Load += pagina_tres_menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_apresentacao_menu;
        private Button btn_calculo_de_compra_menu;
        private Button btn_calculo_de_horario_menu;
        private Button btn_check_list_menu;
        private Label lbl_logo_menu;
    }
}