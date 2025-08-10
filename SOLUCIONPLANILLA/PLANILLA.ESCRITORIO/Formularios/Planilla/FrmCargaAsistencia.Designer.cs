namespace PLANILLA.ESCRITORIO.Formularios.Planilla
{
    partial class FrmCargaAsistencia
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
            splitContainer1 = new SplitContainer();
            BGrabar = new Button();
            BtCarga = new Button();
            Descarga = new Button();
            groupBox1 = new GroupBox();
            BtBusqueda = new Button();
            CbMes = new ComboBox();
            CbAño = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            DgInasitencias = new DataGridView();
            CDNI = new DataGridViewTextBoxColumn();
            CDIASLABORALES = new DataGridViewTextBoxColumn();
            CDIASDESCANSO = new DataGridViewTextBoxColumn();
            CDIASINASISTENCIA = new DataGridViewTextBoxColumn();
            CDIASFERIADOS = new DataGridViewTextBoxColumn();
            CHORAEXTRA25 = new DataGridViewTextBoxColumn();
            CHORAEXTRA35 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgInasitencias).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(BGrabar);
            splitContainer1.Panel1.Controls.Add(BtCarga);
            splitContainer1.Panel1.Controls.Add(Descarga);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DgInasitencias);
            splitContainer1.Size = new Size(800, 510);
            splitContainer1.SplitterDistance = 198;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // BGrabar
            // 
            BGrabar.Location = new Point(713, 144);
            BGrabar.Name = "BGrabar";
            BGrabar.Size = new Size(75, 38);
            BGrabar.TabIndex = 32;
            BGrabar.Text = "Grabar";
            BGrabar.UseVisualStyleBackColor = true;
            BGrabar.Click += BGrabar_Click;
            // 
            // BtCarga
            // 
            BtCarga.Location = new Point(272, 144);
            BtCarga.Name = "BtCarga";
            BtCarga.Size = new Size(124, 38);
            BtCarga.TabIndex = 2;
            BtCarga.Text = "Carga Excel";
            BtCarga.UseVisualStyleBackColor = true;
            BtCarga.Click += BtCarga_Click;
            // 
            // Descarga
            // 
            Descarga.Location = new Point(12, 144);
            Descarga.Name = "Descarga";
            Descarga.Size = new Size(124, 38);
            Descarga.TabIndex = 1;
            Descarga.Text = "Descarga Excel";
            Descarga.UseVisualStyleBackColor = true;
            Descarga.Click += Descarga_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtBusqueda);
            groupBox1.Controls.Add(CbMes);
            groupBox1.Controls.Add(CbAño);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo";
            // 
            // BtBusqueda
            // 
            BtBusqueda.Location = new Point(274, 57);
            BtBusqueda.Name = "BtBusqueda";
            BtBusqueda.Size = new Size(104, 38);
            BtBusqueda.TabIndex = 4;
            BtBusqueda.Text = "Busqueda";
            BtBusqueda.UseVisualStyleBackColor = true;
            BtBusqueda.Click += button1_Click;
            // 
            // CbMes
            // 
            CbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            CbMes.FormattingEnabled = true;
            CbMes.Location = new Point(70, 65);
            CbMes.Name = "CbMes";
            CbMes.Size = new Size(121, 25);
            CbMes.TabIndex = 3;
            // 
            // CbAño
            // 
            CbAño.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAño.FormattingEnabled = true;
            CbAño.Location = new Point(70, 24);
            CbAño.Name = "CbAño";
            CbAño.Size = new Size(121, 25);
            CbAño.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 68);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 1;
            label2.Text = "Mes :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 0;
            label1.Text = "Año :";
            // 
            // DgInasitencias
            // 
            DgInasitencias.AllowUserToAddRows = false;
            DgInasitencias.AllowUserToDeleteRows = false;
            DgInasitencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgInasitencias.Columns.AddRange(new DataGridViewColumn[] { CDNI, CDIASLABORALES, CDIASDESCANSO, CDIASINASISTENCIA, CDIASFERIADOS, CHORAEXTRA25, CHORAEXTRA35 });
            DgInasitencias.Dock = DockStyle.Fill;
            DgInasitencias.Location = new Point(0, 0);
            DgInasitencias.MultiSelect = false;
            DgInasitencias.Name = "DgInasitencias";
            DgInasitencias.ReadOnly = true;
            DgInasitencias.RowHeadersVisible = false;
            DgInasitencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgInasitencias.Size = new Size(800, 307);
            DgInasitencias.TabIndex = 0;
            // 
            // CDNI
            // 
            CDNI.Frozen = true;
            CDNI.HeaderText = "DNI";
            CDNI.Name = "CDNI";
            CDNI.ReadOnly = true;
            // 
            // CDIASLABORALES
            // 
            CDIASLABORALES.Frozen = true;
            CDIASLABORALES.HeaderText = "DIAS LABORALES";
            CDIASLABORALES.Name = "CDIASLABORALES";
            CDIASLABORALES.ReadOnly = true;
            // 
            // CDIASDESCANSO
            // 
            CDIASDESCANSO.Frozen = true;
            CDIASDESCANSO.HeaderText = "DIAS DESCANSO";
            CDIASDESCANSO.Name = "CDIASDESCANSO";
            CDIASDESCANSO.ReadOnly = true;
            // 
            // CDIASINASISTENCIA
            // 
            CDIASINASISTENCIA.Frozen = true;
            CDIASINASISTENCIA.HeaderText = "DIAS INASISTENCIA";
            CDIASINASISTENCIA.Name = "CDIASINASISTENCIA";
            CDIASINASISTENCIA.ReadOnly = true;
            // 
            // CDIASFERIADOS
            // 
            CDIASFERIADOS.Frozen = true;
            CDIASFERIADOS.HeaderText = "DIAS FERIADOS";
            CDIASFERIADOS.Name = "CDIASFERIADOS";
            CDIASFERIADOS.ReadOnly = true;
            // 
            // CHORAEXTRA25
            // 
            CHORAEXTRA25.Frozen = true;
            CHORAEXTRA25.HeaderText = "HORA EXTRA 25";
            CHORAEXTRA25.Name = "CHORAEXTRA25";
            CHORAEXTRA25.ReadOnly = true;
            // 
            // CHORAEXTRA35
            // 
            CHORAEXTRA35.Frozen = true;
            CHORAEXTRA35.HeaderText = "HORA EXTRA 35";
            CHORAEXTRA35.Name = "CHORAEXTRA35";
            CHORAEXTRA35.ReadOnly = true;
            // 
            // FrmCargaAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmCargaAsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga Asistencia";
            Load += FrmCargaAsistencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgInasitencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ComboBox CbMes;
        private ComboBox CbAño;
        private Label label2;
        private Label label1;
        private DataGridView DgInasitencias;
        private DataGridViewTextBoxColumn CDNI;
        private DataGridViewTextBoxColumn CDIASLABORALES;
        private DataGridViewTextBoxColumn CDIASDESCANSO;
        private DataGridViewTextBoxColumn CDIASINASISTENCIA;
        private DataGridViewTextBoxColumn CDIASFERIADOS;
        private DataGridViewTextBoxColumn CHORAEXTRA25;
        private DataGridViewTextBoxColumn CHORAEXTRA35;
        private Button BtCarga;
        private Button Descarga;
        private Button BtBusqueda;
        private Button BGrabar;
    }
}