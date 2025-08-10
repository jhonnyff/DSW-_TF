namespace PLANILLA.ESCRITORIO.Componentes
{
    partial class FrmMensajeAceptar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensajeAceptar));
            BAceptar = new Button();
            SuspendLayout();
            // 
            // BAceptar
            // 
            BAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BAceptar.Image = (Image)resources.GetObject("BAceptar.Image");
            BAceptar.Location = new Point(418, 310);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(101, 23);
            BAceptar.TabIndex = 3;
            BAceptar.Text = "Aceptar";
            BAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAceptar.UseVisualStyleBackColor = true;
            BAceptar.Click += BAceptar_Click;
            // 
            // FrmMensajeAceptar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 345);
            Controls.Add(BAceptar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMensajeAceptar";
            Text = "FrmMensajeAceptar";
            Load += FrmMensajeAceptar_Load;
            KeyDown += FrmMensajeAceptar_KeyDown;
            Controls.SetChildIndex(BAceptar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BAceptar;
    }
}