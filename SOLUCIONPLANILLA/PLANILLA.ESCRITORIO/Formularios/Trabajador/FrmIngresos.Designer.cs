namespace PLANILLA.ESCRITORIO.Formularios.Trabajador
{
    partial class FrmIngresos
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
            label2 = new Label();
            label3 = new Label();
            TRemuneracion = new Controles.TextBox();
            TVales = new Controles.TextBox();
            TBonificacion = new Controles.TextBox();
            TTotal = new Controles.TextBox();
            label4 = new Label();
            BGrabar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 25);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 0;
            label1.Text = "Remuneracion :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 59);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 1;
            label2.Text = "Vales :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 101);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 2;
            label3.Text = "Bonificacion :";
            // 
            // TRemuneracion
            // 
            TRemuneracion.CharacterCasing = CharacterCasing.Upper;
            TRemuneracion.FxBlockEnterKey = true;
            TRemuneracion.FxCharacterCasing = Controles.TextBox._FxCharacterCasing.Upper;
            TRemuneracion.FxEditable = true;
            TRemuneracion.FxMaskType = Controles.TextBox.__TextBox_TipoMascara.NumeroPunto;
            TRemuneracion.FxMaskType_CaracteresAceptar = null;
            TRemuneracion.FxMaskType_CaracteresDenegar = null;
            TRemuneracion.FxText = "";
            TRemuneracion.Location = new Point(154, 21);
            TRemuneracion.Name = "TRemuneracion";
            TRemuneracion.ObjPanel = null;
            TRemuneracion.Size = new Size(100, 25);
            TRemuneracion.TabIndex = 3;
            TRemuneracion.TextChanged += Tremuneracion_TextChanged;
            // 
            // TVales
            // 
            TVales.CharacterCasing = CharacterCasing.Upper;
            TVales.FxBlockEnterKey = true;
            TVales.FxCharacterCasing = Controles.TextBox._FxCharacterCasing.Upper;
            TVales.FxEditable = true;
            TVales.FxMaskType = Controles.TextBox.__TextBox_TipoMascara.NumeroPunto;
            TVales.FxMaskType_CaracteresAceptar = null;
            TVales.FxMaskType_CaracteresDenegar = null;
            TVales.FxText = "";
            TVales.Location = new Point(154, 55);
            TVales.Name = "TVales";
            TVales.ObjPanel = null;
            TVales.Size = new Size(100, 25);
            TVales.TabIndex = 4;
            TVales.TextChanged += Tremuneracion_TextChanged;
            // 
            // TBonificacion
            // 
            TBonificacion.CharacterCasing = CharacterCasing.Upper;
            TBonificacion.FxBlockEnterKey = true;
            TBonificacion.FxCharacterCasing = Controles.TextBox._FxCharacterCasing.Upper;
            TBonificacion.FxEditable = true;
            TBonificacion.FxMaskType = Controles.TextBox.__TextBox_TipoMascara.NumeroPunto;
            TBonificacion.FxMaskType_CaracteresAceptar = null;
            TBonificacion.FxMaskType_CaracteresDenegar = null;
            TBonificacion.FxText = "";
            TBonificacion.Location = new Point(154, 97);
            TBonificacion.Name = "TBonificacion";
            TBonificacion.ObjPanel = null;
            TBonificacion.Size = new Size(100, 25);
            TBonificacion.TabIndex = 5;
            TBonificacion.TextChanged += Tremuneracion_TextChanged;
            // 
            // TTotal
            // 
            TTotal.CharacterCasing = CharacterCasing.Upper;
            TTotal.FxBlockEnterKey = true;
            TTotal.FxCharacterCasing = Controles.TextBox._FxCharacterCasing.Upper;
            TTotal.FxEditable = true;
            TTotal.FxMaskType = Controles.TextBox.__TextBox_TipoMascara.Ninguno;
            TTotal.FxMaskType_CaracteresAceptar = null;
            TTotal.FxMaskType_CaracteresDenegar = null;
            TTotal.FxText = "";
            TTotal.Location = new Point(327, 97);
            TTotal.Name = "TTotal";
            TTotal.ObjPanel = null;
            TTotal.ReadOnly = true;
            TTotal.Size = new Size(100, 25);
            TTotal.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 101);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 6;
            label4.Text = "Total :";
            // 
            // BGrabar
            // 
            BGrabar.Location = new Point(511, 14);
            BGrabar.Name = "BGrabar";
            BGrabar.Size = new Size(75, 38);
            BGrabar.TabIndex = 32;
            BGrabar.Text = "Grabar";
            BGrabar.UseVisualStyleBackColor = true;
            BGrabar.Click += BGrabar_Click;
            // 
            // FrmIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 143);
            Controls.Add(BGrabar);
            Controls.Add(TTotal);
            Controls.Add(label4);
            Controls.Add(TBonificacion);
            Controls.Add(TVales);
            Controls.Add(TRemuneracion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmIngresos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresos Trabajador";
            Load += FrmIngresos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Controles.TextBox TRemuneracion;
        private Controles.TextBox TVales;
        private Controles.TextBox TBonificacion;
        private Controles.TextBox TTotal;
        private Label label4;
        private Button BGrabar;
    }
}