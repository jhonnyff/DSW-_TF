namespace PLANILLA.ESCRITORIO.Componentes
{
    partial class FrmBaseMensaje
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
            pictureBox1 = new PictureBox();
            TTexto = new TextBox();
            LTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(5, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // TTexto
            // 
            TTexto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTexto.BorderStyle = BorderStyle.FixedSingle;
            TTexto.Location = new Point(61, 25);
            TTexto.Multiline = true;
            TTexto.Name = "TTexto";
            TTexto.ReadOnly = true;
            TTexto.ScrollBars = ScrollBars.Vertical;
            TTexto.Size = new Size(472, 265);
            TTexto.TabIndex = 7;
            // 
            // LTitulo
            // 
            LTitulo.BackColor = Color.SteelBlue;
            LTitulo.Dock = DockStyle.Top;
            LTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo.ForeColor = Color.White;
            LTitulo.Location = new Point(0, 0);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(545, 22);
            LTitulo.TabIndex = 6;
            LTitulo.Text = "label1";
            LTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmBaseMensaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 345);
            Controls.Add(pictureBox1);
            Controls.Add(TTexto);
            Controls.Add(LTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmBaseMensaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mensaje";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TTexto;
        private Label LTitulo;
    }
}