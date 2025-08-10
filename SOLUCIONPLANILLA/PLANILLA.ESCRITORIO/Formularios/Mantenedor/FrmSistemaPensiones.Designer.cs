namespace PLANILLA.ESCRITORIO.Formularios.Mantenedor
{
    partial class FrmSistemaPensiones
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BNuevo = new Button();
            BGrabar = new Button();
            Tnombre = new TextBox();
            label1 = new Label();
            Dg1 = new DataGridView();
            CId = new DataGridViewTextBoxColumn();
            CNombre = new DataGridViewTextBoxColumn();
            CEstado = new DataGridViewCheckBoxColumn();
            CCreacion = new DataGridViewTextBoxColumn();
            MenuStrip = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            estadoToolStripMenuItem = new ToolStripMenuItem();
            TAporte = new Controles.TextBox();
            TPrima = new Controles.TextBox();
            TComision = new Controles.TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dg1).BeginInit();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(TComision);
            splitContainer1.Panel1.Controls.Add(TPrima);
            splitContainer1.Panel1.Controls.Add(TAporte);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(BNuevo);
            splitContainer1.Panel1.Controls.Add(BGrabar);
            splitContainer1.Panel1.Controls.Add(Tnombre);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Dg1);
            splitContainer1.Size = new Size(800, 510);
            splitContainer1.SplitterDistance = 173;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 80);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 8;
            label4.Text = "Comision : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 80);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 6;
            label3.Text = "Prima : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 79);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 4;
            label2.Text = "Aporte : ";
            // 
            // BNuevo
            // 
            BNuevo.Location = new Point(713, 35);
            BNuevo.Name = "BNuevo";
            BNuevo.Size = new Size(75, 38);
            BNuevo.TabIndex = 3;
            BNuevo.Text = "Nuevo";
            BNuevo.UseVisualStyleBackColor = true;
            BNuevo.Click += BNuevo_Click;
            // 
            // BGrabar
            // 
            BGrabar.Location = new Point(713, 99);
            BGrabar.Name = "BGrabar";
            BGrabar.Size = new Size(75, 34);
            BGrabar.TabIndex = 2;
            BGrabar.Text = "Grabar";
            BGrabar.UseVisualStyleBackColor = true;
            BGrabar.Click += BGrabar_Click;
            // 
            // Tnombre
            // 
            Tnombre.Location = new Point(101, 38);
            Tnombre.Name = "Tnombre";
            Tnombre.Size = new Size(449, 25);
            Tnombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre : ";
            // 
            // Dg1
            // 
            Dg1.AllowUserToAddRows = false;
            Dg1.AllowUserToDeleteRows = false;
            Dg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dg1.Columns.AddRange(new DataGridViewColumn[] { CId, CNombre, CEstado, CCreacion });
            Dg1.Dock = DockStyle.Fill;
            Dg1.Location = new Point(0, 0);
            Dg1.MultiSelect = false;
            Dg1.Name = "Dg1";
            Dg1.ReadOnly = true;
            Dg1.RowHeadersVisible = false;
            Dg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dg1.Size = new Size(800, 332);
            Dg1.TabIndex = 0;
            Dg1.MouseClick += Dg1_MouseClick;
            // 
            // CId
            // 
            CId.HeaderText = "ID";
            CId.Name = "CId";
            CId.ReadOnly = true;
            // 
            // CNombre
            // 
            CNombre.HeaderText = "Nombre";
            CNombre.Name = "CNombre";
            CNombre.ReadOnly = true;
            // 
            // CEstado
            // 
            CEstado.HeaderText = "Estado";
            CEstado.Name = "CEstado";
            CEstado.ReadOnly = true;
            CEstado.Resizable = DataGridViewTriState.True;
            CEstado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CCreacion
            // 
            CCreacion.HeaderText = "FecCreacion";
            CCreacion.Name = "CCreacion";
            CCreacion.ReadOnly = true;
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, estadoToolStripMenuItem });
            MenuStrip.Name = "contextMenuStrip1";
            MenuStrip.Size = new Size(110, 48);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(109, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // estadoToolStripMenuItem
            // 
            estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            estadoToolStripMenuItem.Size = new Size(109, 22);
            estadoToolStripMenuItem.Text = "Estado";
            estadoToolStripMenuItem.Click += estadoToolStripMenuItem_ClickAsync;
            // 
            // TAporte
            // 
            TAporte.FxBlockEnterKey = true;
            TAporte.FxCharacterCasing = Controles.TextBox._FxCharacterCasing.Upper;
            TAporte.FxEditable = true;
            TAporte.FxMaskType = Controles.TextBox.__TextBox_TipoMascara.NumeroPunto;
            TAporte.FxMaskType_CaracteresAceptar = null;
            TAporte.FxMaskType_CaracteresDenegar = null;
            TAporte.FxText = "";
            TAporte.Location = new Point(101, 76);
            TAporte.Name = "TAporte";
            TAporte.ObjPanel = null;
            TAporte.Size = new Size(100, 25);
            TAporte.TabIndex = 10;
            // 
            // TPrima
            // 
            TPrima.FxBlockEnterKey = true;
            TPrima.FxCharacterCasing = Controles.TextBox._FxCharacterCasing.Upper;
            TPrima.FxEditable = true;
            TPrima.FxMaskType = Controles.TextBox.__TextBox_TipoMascara.NumeroPunto;
            TPrima.FxMaskType_CaracteresAceptar = null;
            TPrima.FxMaskType_CaracteresDenegar = null;
            TPrima.FxText = "";
            TPrima.Location = new Point(265, 76);
            TPrima.Name = "TPrima";
            TPrima.ObjPanel = null;
            TPrima.Size = new Size(100, 25);
            TPrima.TabIndex = 11;
            // 
            // TComision
            // 
            TComision.FxBlockEnterKey = true;
            TComision.FxCharacterCasing = Controles.TextBox._FxCharacterCasing.Upper;
            TComision.FxEditable = true;
            TComision.FxMaskType = Controles.TextBox.__TextBox_TipoMascara.NumeroPunto;
            TComision.FxMaskType_CaracteresAceptar = null;
            TComision.FxMaskType_CaracteresDenegar = null;
            TComision.FxText = "";
            TComision.Location = new Point(450, 76);
            TComision.Name = "TComision";
            TComision.ObjPanel = null;
            TComision.Size = new Size(100, 25);
            TComision.TabIndex = 12;
            // 
            // FrmSistemaPensiones
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmSistemaPensiones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sistema Pensiones";
            Load += FrmSistemaPensiones_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dg1).EndInit();
            MenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BNuevo;
        private Button BGrabar;
        private TextBox Tnombre;
        private Label label1;
        private DataGridView Dg1;
        private DataGridViewTextBoxColumn CId;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewCheckBoxColumn CEstado;
        private DataGridViewTextBoxColumn CCreacion;
        private Label label2;
        private Label label4;
        private Label label3;
        private ContextMenuStrip MenuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem estadoToolStripMenuItem;
        private Controles.TextBox TComision;
        private Controles.TextBox TPrima;
        private Controles.TextBox TAporte;
    }
}