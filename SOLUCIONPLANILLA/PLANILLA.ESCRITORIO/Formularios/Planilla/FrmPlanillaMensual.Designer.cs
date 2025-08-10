namespace PLANILLA.ESCRITORIO.Formularios.Planilla
{
    partial class FrmPlanillaMensual
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
            groupBox1 = new GroupBox();
            BtGenerar = new Button();
            CbMes = new ComboBox();
            CbAño = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            DgPlanilla = new DataGridView();
            CDNI = new DataGridViewTextBoxColumn();
            CTRABAJADOR = new DataGridViewTextBoxColumn();
            CDIASLABORALES = new DataGridViewTextBoxColumn();
            CDIASDESCANSO = new DataGridViewTextBoxColumn();
            CDIASINASISTENCIA = new DataGridViewTextBoxColumn();
            CDIASFERIADOS = new DataGridViewTextBoxColumn();
            CHORAEXTRA1 = new DataGridViewTextBoxColumn();
            CHORAEXTRA2 = new DataGridViewTextBoxColumn();
            CREMUNERACION = new DataGridViewTextBoxColumn();
            CVALE = new DataGridViewTextBoxColumn();
            CBONIFICACION = new DataGridViewTextBoxColumn();
            CHORAEXTRAVALOR1 = new DataGridViewTextBoxColumn();
            CHORAEXTRAVALOR2 = new DataGridViewTextBoxColumn();
            CVALORFERIADO = new DataGridViewTextBoxColumn();
            CTOTALINGRESO = new DataGridViewTextBoxColumn();
            CSISTEMAPENSION = new DataGridViewTextBoxColumn();
            CAPORTE = new DataGridViewTextBoxColumn();
            CCOMISION = new DataGridViewTextBoxColumn();
            CPRIMA = new DataGridViewTextBoxColumn();
            CTOTALDESCUENTO = new DataGridViewTextBoxColumn();
            CTOTALPAGAR = new DataGridViewTextBoxColumn();
            BtGrabar = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPlanilla).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(BtGrabar);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(DgPlanilla);
            splitContainer1.Size = new Size(1107, 532);
            splitContainer1.SplitterDistance = 102;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtGenerar);
            groupBox1.Controls.Add(CbMes);
            groupBox1.Controls.Add(CbAño);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 88);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo";
            // 
            // BtGenerar
            // 
            BtGenerar.Location = new Point(500, 16);
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
            CbMes.Location = new Point(246, 24);
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
            label2.Location = new Point(200, 27);
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
            // DgPlanilla
            // 
            DgPlanilla.AllowUserToAddRows = false;
            DgPlanilla.AllowUserToDeleteRows = false;
            DgPlanilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPlanilla.Columns.AddRange(new DataGridViewColumn[] { CDNI, CTRABAJADOR, CDIASLABORALES, CDIASDESCANSO, CDIASINASISTENCIA, CDIASFERIADOS, CHORAEXTRA1, CHORAEXTRA2, CREMUNERACION, CVALE, CBONIFICACION, CHORAEXTRAVALOR1, CHORAEXTRAVALOR2, CVALORFERIADO, CTOTALINGRESO, CSISTEMAPENSION, CAPORTE, CCOMISION, CPRIMA, CTOTALDESCUENTO, CTOTALPAGAR });
            DgPlanilla.Dock = DockStyle.Fill;
            DgPlanilla.Location = new Point(0, 0);
            DgPlanilla.Name = "DgPlanilla";
            DgPlanilla.ReadOnly = true;
            DgPlanilla.RowHeadersVisible = false;
            DgPlanilla.ScrollBars = ScrollBars.Horizontal;
            DgPlanilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgPlanilla.Size = new Size(1107, 425);
            DgPlanilla.TabIndex = 0;
            // 
            // CDNI
            // 
            CDNI.HeaderText = "DNI";
            CDNI.Name = "CDNI";
            CDNI.ReadOnly = true;
            // 
            // CTRABAJADOR
            // 
            CTRABAJADOR.HeaderText = "TRABAJADOR";
            CTRABAJADOR.Name = "CTRABAJADOR";
            CTRABAJADOR.ReadOnly = true;
            // 
            // CDIASLABORALES
            // 
            CDIASLABORALES.HeaderText = "DIAS LABORALES";
            CDIASLABORALES.Name = "CDIASLABORALES";
            CDIASLABORALES.ReadOnly = true;
            // 
            // CDIASDESCANSO
            // 
            CDIASDESCANSO.HeaderText = "DIAS DESCANSO";
            CDIASDESCANSO.Name = "CDIASDESCANSO";
            CDIASDESCANSO.ReadOnly = true;
            // 
            // CDIASINASISTENCIA
            // 
            CDIASINASISTENCIA.HeaderText = "DIAS INASISTENCIA";
            CDIASINASISTENCIA.Name = "CDIASINASISTENCIA";
            CDIASINASISTENCIA.ReadOnly = true;
            // 
            // CDIASFERIADOS
            // 
            CDIASFERIADOS.HeaderText = "DIAS FERIADOS";
            CDIASFERIADOS.Name = "CDIASFERIADOS";
            CDIASFERIADOS.ReadOnly = true;
            // 
            // CHORAEXTRA1
            // 
            CHORAEXTRA1.HeaderText = "HORA EXTRA 25";
            CHORAEXTRA1.Name = "CHORAEXTRA1";
            CHORAEXTRA1.ReadOnly = true;
            // 
            // CHORAEXTRA2
            // 
            CHORAEXTRA2.HeaderText = "HORA EXTRA 35";
            CHORAEXTRA2.Name = "CHORAEXTRA2";
            CHORAEXTRA2.ReadOnly = true;
            // 
            // CREMUNERACION
            // 
            CREMUNERACION.HeaderText = "REMUNERACION";
            CREMUNERACION.Name = "CREMUNERACION";
            CREMUNERACION.ReadOnly = true;
            // 
            // CVALE
            // 
            CVALE.HeaderText = "VALE";
            CVALE.Name = "CVALE";
            CVALE.ReadOnly = true;
            // 
            // CBONIFICACION
            // 
            CBONIFICACION.HeaderText = "BONIFICACION";
            CBONIFICACION.Name = "CBONIFICACION";
            CBONIFICACION.ReadOnly = true;
            // 
            // CHORAEXTRAVALOR1
            // 
            CHORAEXTRAVALOR1.HeaderText = "VALOR EXTRA 25";
            CHORAEXTRAVALOR1.Name = "CHORAEXTRAVALOR1";
            CHORAEXTRAVALOR1.ReadOnly = true;
            // 
            // CHORAEXTRAVALOR2
            // 
            CHORAEXTRAVALOR2.HeaderText = "VALOR EXTRA 35";
            CHORAEXTRAVALOR2.Name = "CHORAEXTRAVALOR2";
            CHORAEXTRAVALOR2.ReadOnly = true;
            // 
            // CVALORFERIADO
            // 
            CVALORFERIADO.HeaderText = "VALOR FERIADO";
            CVALORFERIADO.Name = "CVALORFERIADO";
            CVALORFERIADO.ReadOnly = true;
            // 
            // CTOTALINGRESO
            // 
            CTOTALINGRESO.HeaderText = "TOTAL INGRESO";
            CTOTALINGRESO.Name = "CTOTALINGRESO";
            CTOTALINGRESO.ReadOnly = true;
            // 
            // CSISTEMAPENSION
            // 
            CSISTEMAPENSION.HeaderText = "SISTEMA PENSION";
            CSISTEMAPENSION.Name = "CSISTEMAPENSION";
            CSISTEMAPENSION.ReadOnly = true;
            // 
            // CAPORTE
            // 
            CAPORTE.HeaderText = "APORTE";
            CAPORTE.Name = "CAPORTE";
            CAPORTE.ReadOnly = true;
            // 
            // CCOMISION
            // 
            CCOMISION.HeaderText = "COMISION";
            CCOMISION.Name = "CCOMISION";
            CCOMISION.ReadOnly = true;
            // 
            // CPRIMA
            // 
            CPRIMA.HeaderText = "PRIMA";
            CPRIMA.Name = "CPRIMA";
            CPRIMA.ReadOnly = true;
            // 
            // CTOTALDESCUENTO
            // 
            CTOTALDESCUENTO.HeaderText = "TOTAL DESCUENTO";
            CTOTALDESCUENTO.Name = "CTOTALDESCUENTO";
            CTOTALDESCUENTO.ReadOnly = true;
            // 
            // CTOTALPAGAR
            // 
            CTOTALPAGAR.HeaderText = "TOTAL A PAGAR";
            CTOTALPAGAR.Name = "CTOTALPAGAR";
            CTOTALPAGAR.ReadOnly = true;
            // 
            // BtGrabar
            // 
            BtGrabar.Location = new Point(991, 50);
            BtGrabar.Name = "BtGrabar";
            BtGrabar.Size = new Size(104, 38);
            BtGrabar.TabIndex = 5;
            BtGrabar.Text = "Grabar";
            BtGrabar.UseVisualStyleBackColor = true;
            BtGrabar.Click += BtGrabar_Click;
            // 
            // FrmPlanillaMensual
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 532);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmPlanillaMensual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planilla Mensual";
            Load += FrmPlanillaMensual_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPlanilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView DgPlanilla;
        private GroupBox groupBox1;
        private Button BtGenerar;
        private ComboBox CbMes;
        private ComboBox CbAño;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn CDNI;
        private DataGridViewTextBoxColumn CTRABAJADOR;
        private DataGridViewTextBoxColumn CDIASLABORALES;
        private DataGridViewTextBoxColumn CDIASDESCANSO;
        private DataGridViewTextBoxColumn CDIASINASISTENCIA;
        private DataGridViewTextBoxColumn CDIASFERIADOS;
        private DataGridViewTextBoxColumn CHORAEXTRA1;
        private DataGridViewTextBoxColumn CHORAEXTRA2;
        private DataGridViewTextBoxColumn CREMUNERACION;
        private DataGridViewTextBoxColumn CVALE;
        private DataGridViewTextBoxColumn CBONIFICACION;
        private DataGridViewTextBoxColumn CHORAEXTRAVALOR1;
        private DataGridViewTextBoxColumn CHORAEXTRAVALOR2;
        private DataGridViewTextBoxColumn CVALORFERIADO;
        private DataGridViewTextBoxColumn CTOTALINGRESO;
        private DataGridViewTextBoxColumn CSISTEMAPENSION;
        private DataGridViewTextBoxColumn CAPORTE;
        private DataGridViewTextBoxColumn CCOMISION;
        private DataGridViewTextBoxColumn CPRIMA;
        private DataGridViewTextBoxColumn CTOTALDESCUENTO;
        private DataGridViewTextBoxColumn CTOTALPAGAR;
        private Button BtGrabar;
    }
}