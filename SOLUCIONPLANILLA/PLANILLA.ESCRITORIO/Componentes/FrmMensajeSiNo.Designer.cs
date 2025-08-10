namespace PLANILLA.ESCRITORIO.Componentes
{
    partial class FrmMensajeSiNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensajeSiNo));
            BAceptar = new Button();
            BCancelar = new Button();
            SuspendLayout();
            // 
            // BAceptar
            // 
            BAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BAceptar.Image = (Image)resources.GetObject("BAceptar.Image");
            BAceptar.Location = new Point(436, 315);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(101, 23);
            BAceptar.TabIndex = 9;
            BAceptar.Text = "Si";
            BAceptar.TextAlign = ContentAlignment.MiddleRight;
            BAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAceptar.UseVisualStyleBackColor = true;
            BAceptar.Click += BAceptar_Click;
            // 
            // BCancelar
            // 
            BCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BCancelar.Image = (Image)resources.GetObject("BCancelar.Image");
            BCancelar.Location = new Point(304, 315);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(101, 23);
            BCancelar.TabIndex = 10;
            BCancelar.Text = "No";
            BCancelar.TextAlign = ContentAlignment.MiddleRight;
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // FrmMensajeSiNo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 345);
            Controls.Add(BCancelar);
            Controls.Add(BAceptar);
            Name = "FrmMensajeSiNo";
            Text = "FrmMensajeSiNo";
            Load += FrmMensajeSiNo_Load;
            Shown += FrmMensajeSiNo_Shown;
            KeyDown += FrmMensajeSiNo_KeyDown;
            Controls.SetChildIndex(BAceptar, 0);
            Controls.SetChildIndex(BCancelar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BAceptar;
        private Button BCancelar;
    }
}