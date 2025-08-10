namespace PLANILLA.ESCRITORIO.Formularios.Reportes
{
    partial class FrmReporteBoletas
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
            splitContainer3 = new SplitContainer();
            groupBox1 = new GroupBox();
            BtGenerar = new Button();
            CbMes = new ComboBox();
            CbAño = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            DGBusqueda = new DataGridView();
            CDocumento = new DataGridViewTextBoxColumn();
            CNombre = new DataGridViewTextBoxColumn();
            CTotal = new DataGridViewTextBoxColumn();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(webView21);
            splitContainer1.Size = new Size(977, 663);
            splitContainer1.SplitterDistance = 325;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.BorderStyle = BorderStyle.FixedSingle;
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(groupBox1);
            splitContainer3.Panel1.Controls.Add(label1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(DGBusqueda);
            splitContainer3.Size = new Size(325, 663);
            splitContainer3.SplitterDistance = 184;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtGenerar);
            groupBox1.Controls.Add(CbMes);
            groupBox1.Controls.Add(CbAño);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(2, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 146);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo";
            // 
            // BtGenerar
            // 
            BtGenerar.Location = new Point(199, 24);
            BtGenerar.Name = "BtGenerar";
            BtGenerar.Size = new Size(104, 38);
            BtGenerar.TabIndex = 4;
            BtGenerar.Text = "Generar";
            BtGenerar.UseVisualStyleBackColor = true;
            BtGenerar.Click += BtGenerar_Click;
            // 
            // CbMes
            // 
            CbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            CbMes.FormattingEnabled = true;
            CbMes.Location = new Point(72, 51);
            CbMes.Name = "CbMes";
            CbMes.Size = new Size(121, 23);
            CbMes.TabIndex = 3;
            // 
            // CbAño
            // 
            CbAño.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAño.FormattingEnabled = true;
            CbAño.Location = new Point(70, 24);
            CbAño.Name = "CbAño";
            CbAño.Size = new Size(121, 23);
            CbAño.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 54);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Mes :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 27);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Año :";
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 30);
            label1.TabIndex = 0;
            label1.Text = "Busqueda";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGBusqueda
            // 
            DGBusqueda.AllowUserToAddRows = false;
            DGBusqueda.AllowUserToDeleteRows = false;
            DGBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGBusqueda.Columns.AddRange(new DataGridViewColumn[] { CDocumento, CNombre, CTotal });
            DGBusqueda.Dock = DockStyle.Fill;
            DGBusqueda.Location = new Point(0, 0);
            DGBusqueda.Name = "DGBusqueda";
            DGBusqueda.ReadOnly = true;
            DGBusqueda.RowHeadersVisible = false;
            DGBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGBusqueda.Size = new Size(323, 472);
            DGBusqueda.TabIndex = 0;
            DGBusqueda.SelectionChanged += DGBusqueda_SelectionChanged;
            // 
            // CDocumento
            // 
            CDocumento.HeaderText = "Nro. Doc.";
            CDocumento.Name = "CDocumento";
            CDocumento.ReadOnly = true;
            // 
            // CNombre
            // 
            CNombre.HeaderText = "Nombre y Apellido";
            CNombre.Name = "CNombre";
            CNombre.ReadOnly = true;
            // 
            // CTotal
            // 
            CTotal.HeaderText = "Total";
            CTotal.Name = "CTotal";
            CTotal.ReadOnly = true;
            CTotal.Resizable = DataGridViewTriState.True;
            CTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(648, 663);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // FrmReporteBoletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 663);
            Controls.Add(splitContainer1);
            Name = "FrmReporteBoletas";
            Text = "Reporte Boletas";
            Load += FrmReporteBoletas_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer3;
        private Label label1;
        private DataGridView DGBusqueda;
        private GroupBox groupBox1;
        private Button BtGenerar;
        private ComboBox CbMes;
        private ComboBox CbAño;
        private Label label2;
        private Label label3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private DataGridViewTextBoxColumn CDocumento;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewTextBoxColumn CTotal;
    }
}