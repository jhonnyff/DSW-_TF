namespace PLANILLA.ESCRITORIO.Formularios.Mantenedor
{
    partial class FrmSituacionTrabajador
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
            Tnombre.Size = new Size(392, 25);
            Tnombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 41);
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
            // FrmSituacionTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmSituacionTrabajador";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Situacion Trabajador";
            Load += FrmSituacionTrabajador_Load;
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
        private ContextMenuStrip MenuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem estadoToolStripMenuItem;
    }
}