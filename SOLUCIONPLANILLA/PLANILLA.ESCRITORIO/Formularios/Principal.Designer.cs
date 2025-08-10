namespace PLANILLA.ESCRITORIO
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mantendorToolStripMenuItem = new ToolStripMenuItem();
            cargosToolStripMenuItem = new ToolStripMenuItem();
            generosToolStripMenuItem = new ToolStripMenuItem();
            estadosCivilesToolStripMenuItem = new ToolStripMenuItem();
            sistemaDePensionesToolStripMenuItem = new ToolStripMenuItem();
            situacionDeTrabajadorToolStripMenuItem = new ToolStripMenuItem();
            tiposEDocumentosToolStripMenuItem = new ToolStripMenuItem();
            parametrosToolStripMenuItem = new ToolStripMenuItem();
            trabajadoresToolStripMenuItem = new ToolStripMenuItem();
            fichaDatosToolStripMenuItem = new ToolStripMenuItem();
            planillaToolStripMenuItem = new ToolStripMenuItem();
            asistenciaTrabajadorToolStripMenuItem = new ToolStripMenuItem();
            planillaMensualToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reporteBoletaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantendorToolStripMenuItem, trabajadoresToolStripMenuItem, planillaToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1339, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantendorToolStripMenuItem
            // 
            mantendorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargosToolStripMenuItem, generosToolStripMenuItem, estadosCivilesToolStripMenuItem, sistemaDePensionesToolStripMenuItem, situacionDeTrabajadorToolStripMenuItem, tiposEDocumentosToolStripMenuItem, parametrosToolStripMenuItem });
            mantendorToolStripMenuItem.Name = "mantendorToolStripMenuItem";
            mantendorToolStripMenuItem.Size = new Size(84, 20);
            mantendorToolStripMenuItem.Text = "Mantenedor";
            // 
            // cargosToolStripMenuItem
            // 
            cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            cargosToolStripMenuItem.Size = new Size(197, 22);
            cargosToolStripMenuItem.Text = "Cargos";
            cargosToolStripMenuItem.Click += cargosToolStripMenuItem_Click;
            // 
            // generosToolStripMenuItem
            // 
            generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            generosToolStripMenuItem.Size = new Size(197, 22);
            generosToolStripMenuItem.Text = "Generos";
            generosToolStripMenuItem.Click += generosToolStripMenuItem_Click;
            // 
            // estadosCivilesToolStripMenuItem
            // 
            estadosCivilesToolStripMenuItem.Name = "estadosCivilesToolStripMenuItem";
            estadosCivilesToolStripMenuItem.Size = new Size(197, 22);
            estadosCivilesToolStripMenuItem.Text = "Estados Civiles";
            estadosCivilesToolStripMenuItem.Click += estadosCivilesToolStripMenuItem_Click;
            // 
            // sistemaDePensionesToolStripMenuItem
            // 
            sistemaDePensionesToolStripMenuItem.Name = "sistemaDePensionesToolStripMenuItem";
            sistemaDePensionesToolStripMenuItem.Size = new Size(197, 22);
            sistemaDePensionesToolStripMenuItem.Text = "Sistema de Pensiones";
            sistemaDePensionesToolStripMenuItem.Click += sistemaDePensionesToolStripMenuItem_Click;
            // 
            // situacionDeTrabajadorToolStripMenuItem
            // 
            situacionDeTrabajadorToolStripMenuItem.Name = "situacionDeTrabajadorToolStripMenuItem";
            situacionDeTrabajadorToolStripMenuItem.Size = new Size(197, 22);
            situacionDeTrabajadorToolStripMenuItem.Text = "Situacion de Trabajador";
            situacionDeTrabajadorToolStripMenuItem.Click += situacionDeTrabajadorToolStripMenuItem_Click;
            // 
            // tiposEDocumentosToolStripMenuItem
            // 
            tiposEDocumentosToolStripMenuItem.Name = "tiposEDocumentosToolStripMenuItem";
            tiposEDocumentosToolStripMenuItem.Size = new Size(197, 22);
            tiposEDocumentosToolStripMenuItem.Text = "Tipos de Documentos";
            tiposEDocumentosToolStripMenuItem.Click += tiposEDocumentosToolStripMenuItem_Click;
            // 
            // parametrosToolStripMenuItem
            // 
            parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            parametrosToolStripMenuItem.Size = new Size(197, 22);
            parametrosToolStripMenuItem.Text = "Parametros";
            parametrosToolStripMenuItem.Click += parametrosToolStripMenuItem_Click;
            // 
            // trabajadoresToolStripMenuItem
            // 
            trabajadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fichaDatosToolStripMenuItem });
            trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            trabajadoresToolStripMenuItem.Size = new Size(85, 20);
            trabajadoresToolStripMenuItem.Text = "Trabajadores";
            // 
            // fichaDatosToolStripMenuItem
            // 
            fichaDatosToolStripMenuItem.Name = "fichaDatosToolStripMenuItem";
            fichaDatosToolStripMenuItem.Size = new Size(135, 22);
            fichaDatosToolStripMenuItem.Text = "Ficha Datos";
            fichaDatosToolStripMenuItem.Click += fichaDatosToolStripMenuItem_Click;
            // 
            // planillaToolStripMenuItem
            // 
            planillaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asistenciaTrabajadorToolStripMenuItem, planillaMensualToolStripMenuItem });
            planillaToolStripMenuItem.Name = "planillaToolStripMenuItem";
            planillaToolStripMenuItem.Size = new Size(57, 20);
            planillaToolStripMenuItem.Text = "Planilla";
            // 
            // asistenciaTrabajadorToolStripMenuItem
            // 
            asistenciaTrabajadorToolStripMenuItem.Name = "asistenciaTrabajadorToolStripMenuItem";
            asistenciaTrabajadorToolStripMenuItem.Size = new Size(185, 22);
            asistenciaTrabajadorToolStripMenuItem.Text = "Asistencia Trabajador";
            asistenciaTrabajadorToolStripMenuItem.Click += asistenciaTrabajadorToolStripMenuItem_Click;
            // 
            // planillaMensualToolStripMenuItem
            // 
            planillaMensualToolStripMenuItem.Name = "planillaMensualToolStripMenuItem";
            planillaMensualToolStripMenuItem.Size = new Size(185, 22);
            planillaMensualToolStripMenuItem.Text = "Planilla Mensual";
            planillaMensualToolStripMenuItem.Click += planillaMensualToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteBoletaToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteBoletaToolStripMenuItem
            // 
            reporteBoletaToolStripMenuItem.Name = "reporteBoletaToolStripMenuItem";
            reporteBoletaToolStripMenuItem.Size = new Size(180, 22);
            reporteBoletaToolStripMenuItem.Text = "Reporte Boleta";
            reporteBoletaToolStripMenuItem.Click += reporteBoletaToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 693);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantendorToolStripMenuItem;
        private ToolStripMenuItem cargosToolStripMenuItem;
        private ToolStripMenuItem generosToolStripMenuItem;
        private ToolStripMenuItem estadosCivilesToolStripMenuItem;
        private ToolStripMenuItem sistemaDePensionesToolStripMenuItem;
        private ToolStripMenuItem situacionDeTrabajadorToolStripMenuItem;
        private ToolStripMenuItem tiposEDocumentosToolStripMenuItem;
        private ToolStripMenuItem trabajadoresToolStripMenuItem;
        private ToolStripMenuItem fichaDatosToolStripMenuItem;
        private ToolStripMenuItem parametrosToolStripMenuItem;
        private ToolStripMenuItem planillaToolStripMenuItem;
        private ToolStripMenuItem asistenciaTrabajadorToolStripMenuItem;
        private ToolStripMenuItem planillaMensualToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem reporteBoletaToolStripMenuItem;
    }
}
