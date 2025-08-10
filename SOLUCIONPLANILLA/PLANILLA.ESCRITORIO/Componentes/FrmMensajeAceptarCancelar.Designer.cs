namespace PLANILLA.ESCRITORIO.Componentes
{
    partial class FrmMensajeAceptarCancelar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensajeAceptarCancelar));
            BCancelar = new Button();
            BAceptar = new Button();
            TDato = new Controles.TextBox();
            SuspendLayout();
            // 
            // BCancelar
            // 
            BCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BCancelar.Image = (Image)resources.GetObject("BCancelar.Image");
            BCancelar.Location = new Point(304, 315);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(101, 23);
            BCancelar.TabIndex = 12;
            BCancelar.Text = "Cancelar";
            BCancelar.TextAlign = ContentAlignment.MiddleRight;
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // BAceptar
            // 
            BAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BAceptar.Image = (Image)resources.GetObject("BAceptar.Image");
            BAceptar.Location = new Point(436, 315);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(101, 23);
            BAceptar.TabIndex = 11;
            BAceptar.Text = "Aceptar";
            BAceptar.TextAlign = ContentAlignment.MiddleRight;
            BAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAceptar.UseVisualStyleBackColor = true;
            BAceptar.Click += BAceptar_Click;
            // 
            // TDato
            // 
            TDato.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TDato.CharacterCasing = CharacterCasing.Upper;
            TDato.FxBlockEnterKey = true;
            TDato.FxCharacterCasing = Controles.TextBox._FxCharacterCasing.Upper;
            TDato.FxEditable = true;
            TDato.FxMaskType = Controles.TextBox.__TextBox_TipoMascara.Ninguno;
            TDato.FxMaskType_CaracteresAceptar = null;
            TDato.FxMaskType_CaracteresDenegar = null;
            TDato.FxText = "";
            TDato.Location = new Point(99, 80);
            TDato.Name = "TDato";
            TDato.ObjPanel = null;
            TDato.Size = new Size(420, 23);
            TDato.TabIndex = 14;
            // 
            // FrmMensajeAceptarCancelar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 345);
            Controls.Add(TDato);
            Controls.Add(BCancelar);
            Controls.Add(BAceptar);
            Name = "FrmMensajeAceptarCancelar";
            Text = "FrmMensajeAceptarCancelar";
            Load += FrmMensajeAceptarCancelar_Load;
            Shown += FrmMensajeAceptarCancelar_Shown;
            KeyDown += FrmMensajeAceptarCancelar_KeyDown;
            Controls.SetChildIndex(BAceptar, 0);
            Controls.SetChildIndex(BCancelar, 0);
            Controls.SetChildIndex(TDato, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BCancelar;
        private Button BAceptar;
        public Controles.TextBox TDato;
    }
}