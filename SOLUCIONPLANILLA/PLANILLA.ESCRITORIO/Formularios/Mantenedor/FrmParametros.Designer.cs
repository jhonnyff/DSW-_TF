namespace PLANILLA.ESCRITORIO.Formularios.Mantenedor
{
    partial class FrmParametros
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
            label1 = new Label();
            TRemuneracion = new TextBox();
            TPorcAsignacion = new TextBox();
            label2 = new Label();
            TPorcHora1 = new TextBox();
            label3 = new Label();
            TPorcHora2 = new TextBox();
            label4 = new Label();
            BNuevo = new Button();
            BGrabar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 0;
            label1.Text = "Remuneracion Basica : ";
            // 
            // TRemuneracion
            // 
            TRemuneracion.Location = new Point(172, 45);
            TRemuneracion.Name = "TRemuneracion";
            TRemuneracion.Size = new Size(100, 25);
            TRemuneracion.TabIndex = 1;
            // 
            // TPorcAsignacion
            // 
            TPorcAsignacion.Location = new Point(172, 89);
            TPorcAsignacion.Name = "TPorcAsignacion";
            TPorcAsignacion.Size = new Size(100, 25);
            TPorcAsignacion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 93);
            label2.Name = "label2";
            label2.Size = new Size(129, 17);
            label2.TabIndex = 2;
            label2.Text = "Porc. Asig. Familiar : ";
            // 
            // TPorcHora1
            // 
            TPorcHora1.Location = new Point(172, 133);
            TPorcHora1.Name = "TPorcHora1";
            TPorcHora1.Size = new Size(100, 25);
            TPorcHora1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 137);
            label3.Name = "label3";
            label3.Size = new Size(129, 17);
            label3.TabIndex = 4;
            label3.Text = "Porc. Hora Extra 1  : ";
            // 
            // TPorcHora2
            // 
            TPorcHora2.Location = new Point(172, 177);
            TPorcHora2.Name = "TPorcHora2";
            TPorcHora2.Size = new Size(100, 25);
            TPorcHora2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 181);
            label4.Name = "label4";
            label4.Size = new Size(125, 17);
            label4.TabIndex = 6;
            label4.Text = "Porc. Hora Extra 2 : ";
            // 
            // BNuevo
            // 
            BNuevo.Location = new Point(397, 49);
            BNuevo.Name = "BNuevo";
            BNuevo.Size = new Size(75, 38);
            BNuevo.TabIndex = 9;
            BNuevo.Text = "Limpiar";
            BNuevo.UseVisualStyleBackColor = true;
            // 
            // BGrabar
            // 
            BGrabar.Location = new Point(397, 168);
            BGrabar.Name = "BGrabar";
            BGrabar.Size = new Size(75, 34);
            BGrabar.TabIndex = 8;
            BGrabar.Text = "Grabar";
            BGrabar.UseVisualStyleBackColor = true;
            BGrabar.Click += BGrabar_Click;
            // 
            // FrmParametros
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 252);
            Controls.Add(BNuevo);
            Controls.Add(BGrabar);
            Controls.Add(TPorcHora2);
            Controls.Add(label4);
            Controls.Add(TPorcHora1);
            Controls.Add(label3);
            Controls.Add(TPorcAsignacion);
            Controls.Add(label2);
            Controls.Add(TRemuneracion);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmParametros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parametros";
            Load += FrmParametros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TRemuneracion;
        private TextBox TPorcAsignacion;
        private Label label2;
        private TextBox TPorcHora1;
        private Label label3;
        private TextBox TPorcHora2;
        private Label label4;
        private Button BNuevo;
        private Button BGrabar;
    }
}