namespace PLANILLA.ESCRITORIO.Formularios.Trabajador
{
    partial class FrmTrabajador
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
            splitContainer2 = new SplitContainer();
            TBusqueda = new TextBox();
            label2 = new Label();
            BBuscar = new Button();
            label1 = new Label();
            DGBusqueda = new DataGridView();
            CDocumento = new DataGridViewTextBoxColumn();
            CNombre = new DataGridViewTextBoxColumn();
            CEstado = new DataGridViewCheckBoxColumn();
            BtIngresos = new Button();
            BModificar = new Button();
            BNuevo = new Button();
            BGrabar = new Button();
            DtpIngreso = new DateTimePicker();
            Dtpnacimiento = new DateTimePicker();
            THijos = new TextBox();
            TEmail = new TextBox();
            TDireccion = new TextBox();
            CbSistemaPension = new ComboBox();
            CbSituacion = new ComboBox();
            CbCargo = new ComboBox();
            CbEstadoCivil = new ComboBox();
            CbGenero = new ComboBox();
            TApellidoPaterno = new TextBox();
            TApellidoMaterno = new TextBox();
            TNombre = new TextBox();
            TDocumento = new TextBox();
            CbTipoDocumento = new ComboBox();
            PFoto = new Panel();
            PImagen = new PictureBox();
            BCargarImagen = new Button();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            MenuStrip = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGBusqueda).BeginInit();
            PFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PImagen).BeginInit();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(BtIngresos);
            splitContainer1.Panel2.Controls.Add(BModificar);
            splitContainer1.Panel2.Controls.Add(BNuevo);
            splitContainer1.Panel2.Controls.Add(BGrabar);
            splitContainer1.Panel2.Controls.Add(DtpIngreso);
            splitContainer1.Panel2.Controls.Add(Dtpnacimiento);
            splitContainer1.Panel2.Controls.Add(THijos);
            splitContainer1.Panel2.Controls.Add(TEmail);
            splitContainer1.Panel2.Controls.Add(TDireccion);
            splitContainer1.Panel2.Controls.Add(CbSistemaPension);
            splitContainer1.Panel2.Controls.Add(CbSituacion);
            splitContainer1.Panel2.Controls.Add(CbCargo);
            splitContainer1.Panel2.Controls.Add(CbEstadoCivil);
            splitContainer1.Panel2.Controls.Add(CbGenero);
            splitContainer1.Panel2.Controls.Add(TApellidoPaterno);
            splitContainer1.Panel2.Controls.Add(TApellidoMaterno);
            splitContainer1.Panel2.Controls.Add(TNombre);
            splitContainer1.Panel2.Controls.Add(TDocumento);
            splitContainer1.Panel2.Controls.Add(CbTipoDocumento);
            splitContainer1.Panel2.Controls.Add(PFoto);
            splitContainer1.Panel2.Controls.Add(label17);
            splitContainer1.Panel2.Controls.Add(label16);
            splitContainer1.Panel2.Controls.Add(label15);
            splitContainer1.Panel2.Controls.Add(label14);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new Size(1019, 468);
            splitContainer1.SplitterDistance = 301;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(TBusqueda);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(BBuscar);
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(DGBusqueda);
            splitContainer2.Size = new Size(301, 468);
            splitContainer2.SplitterDistance = 130;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBusqueda.Location = new Point(9, 56);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(284, 25);
            TBusqueda.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 36);
            label2.Name = "label2";
            label2.Size = new Size(136, 17);
            label2.TabIndex = 2;
            label2.Text = "Nro. Doc. o Nombre :";
            // 
            // BBuscar
            // 
            BBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BBuscar.Location = new Point(218, 85);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(75, 34);
            BBuscar.TabIndex = 1;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 30);
            label1.TabIndex = 0;
            label1.Text = "Busqueda";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGBusqueda
            // 
            DGBusqueda.AllowUserToAddRows = false;
            DGBusqueda.AllowUserToDeleteRows = false;
            DGBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGBusqueda.Columns.AddRange(new DataGridViewColumn[] { CDocumento, CNombre, CEstado });
            DGBusqueda.Dock = DockStyle.Fill;
            DGBusqueda.Location = new Point(0, 0);
            DGBusqueda.Name = "DGBusqueda";
            DGBusqueda.ReadOnly = true;
            DGBusqueda.RowHeadersVisible = false;
            DGBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGBusqueda.Size = new Size(299, 331);
            DGBusqueda.TabIndex = 0;
            DGBusqueda.SelectionChanged += DGBusqueda_SelectionChanged;
            DGBusqueda.MouseClick += DGBusqueda_MouseClick;
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
            // CEstado
            // 
            CEstado.HeaderText = "Estado";
            CEstado.Name = "CEstado";
            CEstado.ReadOnly = true;
            // 
            // BtIngresos
            // 
            BtIngresos.Location = new Point(501, 277);
            BtIngresos.Name = "BtIngresos";
            BtIngresos.Size = new Size(201, 38);
            BtIngresos.TabIndex = 34;
            BtIngresos.Text = "Ingresos";
            BtIngresos.UseVisualStyleBackColor = true;
            BtIngresos.Click += BtIngresos_Click;
            // 
            // BModificar
            // 
            BModificar.Location = new Point(132, 418);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(75, 38);
            BModificar.TabIndex = 33;
            BModificar.Text = "Modificar";
            BModificar.UseVisualStyleBackColor = true;
            BModificar.Click += BModificar_Click;
            // 
            // BNuevo
            // 
            BNuevo.Location = new Point(15, 418);
            BNuevo.Name = "BNuevo";
            BNuevo.Size = new Size(75, 38);
            BNuevo.TabIndex = 32;
            BNuevo.Text = "Nuevo";
            BNuevo.UseVisualStyleBackColor = true;
            BNuevo.Click += BNuevo_Click;
            // 
            // BGrabar
            // 
            BGrabar.Location = new Point(627, 418);
            BGrabar.Name = "BGrabar";
            BGrabar.Size = new Size(75, 38);
            BGrabar.TabIndex = 31;
            BGrabar.Text = "Grabar";
            BGrabar.UseVisualStyleBackColor = true;
            BGrabar.Click += BGrabar_Click;
            // 
            // DtpIngreso
            // 
            DtpIngreso.Format = DateTimePickerFormat.Short;
            DtpIngreso.Location = new Point(368, 363);
            DtpIngreso.Name = "DtpIngreso";
            DtpIngreso.Size = new Size(127, 25);
            DtpIngreso.TabIndex = 30;
            // 
            // Dtpnacimiento
            // 
            Dtpnacimiento.Format = DateTimePickerFormat.Short;
            Dtpnacimiento.Location = new Point(136, 363);
            Dtpnacimiento.Name = "Dtpnacimiento";
            Dtpnacimiento.Size = new Size(127, 25);
            Dtpnacimiento.TabIndex = 29;
            // 
            // THijos
            // 
            THijos.Location = new Point(132, 237);
            THijos.Name = "THijos";
            THijos.Size = new Size(82, 25);
            THijos.TabIndex = 28;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(131, 321);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(364, 25);
            TEmail.TabIndex = 27;
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(131, 279);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(364, 25);
            TDireccion.TabIndex = 26;
            // 
            // CbSistemaPension
            // 
            CbSistemaPension.DropDownStyle = ComboBoxStyle.DropDownList;
            CbSistemaPension.FormattingEnabled = true;
            CbSistemaPension.Location = new Point(365, 237);
            CbSistemaPension.Name = "CbSistemaPension";
            CbSistemaPension.Size = new Size(130, 25);
            CbSistemaPension.TabIndex = 25;
            // 
            // CbSituacion
            // 
            CbSituacion.DropDownStyle = ComboBoxStyle.DropDownList;
            CbSituacion.FormattingEnabled = true;
            CbSituacion.Location = new Point(132, 195);
            CbSituacion.Name = "CbSituacion";
            CbSituacion.Size = new Size(130, 25);
            CbSituacion.TabIndex = 24;
            // 
            // CbCargo
            // 
            CbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCargo.FormattingEnabled = true;
            CbCargo.Location = new Point(365, 195);
            CbCargo.Name = "CbCargo";
            CbCargo.Size = new Size(130, 25);
            CbCargo.TabIndex = 23;
            // 
            // CbEstadoCivil
            // 
            CbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            CbEstadoCivil.FormattingEnabled = true;
            CbEstadoCivil.Location = new Point(365, 153);
            CbEstadoCivil.Name = "CbEstadoCivil";
            CbEstadoCivil.Size = new Size(130, 25);
            CbEstadoCivil.TabIndex = 22;
            // 
            // CbGenero
            // 
            CbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            CbGenero.FormattingEnabled = true;
            CbGenero.Location = new Point(132, 153);
            CbGenero.Name = "CbGenero";
            CbGenero.Size = new Size(130, 25);
            CbGenero.TabIndex = 21;
            // 
            // TApellidoPaterno
            // 
            TApellidoPaterno.Location = new Point(135, 111);
            TApellidoPaterno.Name = "TApellidoPaterno";
            TApellidoPaterno.Size = new Size(118, 25);
            TApellidoPaterno.TabIndex = 20;
            // 
            // TApellidoMaterno
            // 
            TApellidoMaterno.Location = new Point(377, 111);
            TApellidoMaterno.Name = "TApellidoMaterno";
            TApellidoMaterno.Size = new Size(118, 25);
            TApellidoMaterno.TabIndex = 19;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(135, 69);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(360, 25);
            TNombre.TabIndex = 18;
            // 
            // TDocumento
            // 
            TDocumento.Location = new Point(377, 27);
            TDocumento.Name = "TDocumento";
            TDocumento.Size = new Size(118, 25);
            TDocumento.TabIndex = 17;
            // 
            // CbTipoDocumento
            // 
            CbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            CbTipoDocumento.FormattingEnabled = true;
            CbTipoDocumento.Location = new Point(135, 27);
            CbTipoDocumento.Name = "CbTipoDocumento";
            CbTipoDocumento.Size = new Size(130, 25);
            CbTipoDocumento.TabIndex = 16;
            // 
            // PFoto
            // 
            PFoto.BorderStyle = BorderStyle.FixedSingle;
            PFoto.Controls.Add(PImagen);
            PFoto.Controls.Add(BCargarImagen);
            PFoto.Location = new Point(501, 12);
            PFoto.Name = "PFoto";
            PFoto.Size = new Size(200, 260);
            PFoto.TabIndex = 15;
            // 
            // PImagen
            // 
            PImagen.Dock = DockStyle.Fill;
            PImagen.Location = new Point(0, 0);
            PImagen.Name = "PImagen";
            PImagen.Size = new Size(198, 217);
            PImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            PImagen.TabIndex = 1;
            PImagen.TabStop = false;
            PImagen.DoubleClick += PImagen_DoubleClick;
            // 
            // BCargarImagen
            // 
            BCargarImagen.Dock = DockStyle.Bottom;
            BCargarImagen.Location = new Point(0, 217);
            BCargarImagen.Name = "BCargarImagen";
            BCargarImagen.Size = new Size(198, 41);
            BCargarImagen.TabIndex = 0;
            BCargarImagen.Text = "Cargar Imagen";
            BCargarImagen.UseVisualStyleBackColor = true;
            BCargarImagen.Click += BCargarImagen_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(228, 241);
            label17.Name = "label17";
            label17.Size = new Size(132, 17);
            label17.TabIndex = 14;
            label17.Text = "Sistema de Pension : ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(55, 199);
            label16.Name = "label16";
            label16.Size = new Size(71, 17);
            label16.TabIndex = 13;
            label16.Text = "Situacion : ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(274, 367);
            label15.Name = "label15";
            label15.Size = new Size(89, 17);
            label15.TabIndex = 12;
            label15.Text = "Fec. Ingreso : ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 367);
            label14.Name = "label14";
            label14.Size = new Size(111, 17);
            label14.TabIndex = 11;
            label14.Text = "Fec. Nacimiento : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(298, 199);
            label13.Name = "label13";
            label13.Size = new Size(55, 17);
            label13.TabIndex = 10;
            label13.Text = "Cargo : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(78, 241);
            label12.Name = "label12";
            label12.Size = new Size(48, 17);
            label12.TabIndex = 9;
            label12.Text = "Hijos : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(75, 325);
            label11.Name = "label11";
            label11.Size = new Size(51, 17);
            label11.TabIndex = 8;
            label11.Text = "E-mail :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 283);
            label10.Name = "label10";
            label10.Size = new Size(73, 17);
            label10.TabIndex = 7;
            label10.Text = "Direccion : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(273, 157);
            label9.Name = "label9";
            label9.Size = new Size(86, 17);
            label9.TabIndex = 6;
            label9.Text = "Estado Civil : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 157);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 5;
            label8.Text = "Genero : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 115);
            label7.Name = "label7";
            label7.Size = new Size(116, 17);
            label7.TabIndex = 4;
            label7.Text = "Apellido Paterno : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 115);
            label6.Name = "label6";
            label6.Size = new Size(121, 17);
            label6.TabIndex = 3;
            label6.Text = "Apellido Materno : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 73);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 2;
            label5.Text = "Nombres : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 31);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 1;
            label4.Text = "Documento :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 31);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 0;
            label3.Text = "Tipo Documento :";
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            MenuStrip.Name = "contextMenuStrip1";
            MenuStrip.Size = new Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // FrmTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 468);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmTrabajador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trabajador";
            Load += FrmTrabajador_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGBusqueda).EndInit();
            PFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PImagen).EndInit();
            MenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TextBox TBusqueda;
        private Label label2;
        private Button BBuscar;
        private Label label1;
        private DataGridView DGBusqueda;
        private DataGridViewTextBoxColumn CDocumento;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewCheckBoxColumn CEstado;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel PFoto;
        private Button BCargarImagen;
        private Label label17;
        private TextBox TDocumento;
        private ComboBox CbTipoDocumento;
        private PictureBox PImagen;
        private DateTimePicker DtpIngreso;
        private DateTimePicker Dtpnacimiento;
        private TextBox THijos;
        private TextBox TEmail;
        private TextBox TDireccion;
        private ComboBox CbSistemaPension;
        private ComboBox CbSituacion;
        private ComboBox CbCargo;
        private ComboBox CbEstadoCivil;
        private ComboBox CbGenero;
        private TextBox TApellidoPaterno;
        private TextBox TApellidoMaterno;
        private TextBox TNombre;
        private Button BModificar;
        private Button BNuevo;
        private Button BGrabar;
        private ContextMenuStrip MenuStrip;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button BtIngresos;
    }
}