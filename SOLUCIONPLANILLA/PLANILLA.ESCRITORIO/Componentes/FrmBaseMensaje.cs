using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLANILLA.ESCRITORIO.Componentes
{
    public partial class FrmBaseMensaje : FrmBase
    {
        public FrmBaseMensaje()
        {
            InitializeComponent();
        }
        #region Mensaje
        public string Mensaje
        {
            set { TTexto.Text = value; }
        }

        public string Titulo
        {
            get { return LTitulo.Text; }
            set { LTitulo.Text = value + "\r\n\r\n"; this.Text = value; }
        }
        public enum _Iconos
        {
            Information,
            Question,
            Error,
            Warning,
            Exclamation,
            Ninguno,
        }

        private System.Drawing.Icon ObjIcon;

        private _Iconos Iconos_ = _Iconos.Ninguno;
        public _Iconos FxIcono
        {
            set
            {

                Iconos_ = value;
                switch (value)
                {
                    case _Iconos.Information:
                        //this.Text = "Información";
                        ObjIcon = System.Drawing.SystemIcons.Information;
                        break;
                    case _Iconos.Question:
                        //this.Text = "Pregunta";
                        ObjIcon = System.Drawing.SystemIcons.Question;
                        break;
                    case _Iconos.Error:
                        //this.Text = "Error";
                        ObjIcon = System.Drawing.SystemIcons.Error;
                        break;
                    case _Iconos.Warning:
                        this.Text = "Advertencia";
                        ObjIcon = System.Drawing.SystemIcons.Warning;
                        break;
                    case _Iconos.Exclamation:
                        //this.Text = "Exclamación";
                        ObjIcon = System.Drawing.SystemIcons.Exclamation;
                        break;
                    default:
                        this.Text = "";
                        ObjIcon = null;
                        break;
                }
            }
            get { return Iconos_; }
        }
        protected void mostrar()
        {
            System.Drawing.Graphics objGraphics = TTexto.CreateGraphics();
            System.Drawing.Font objFont = TTexto.Font;

            int mensajeAncho = System.Convert.ToInt32(objGraphics.MeasureString(TTexto.Text, objFont).Width);
            int mensajeAlto = System.Convert.ToInt32(objGraphics.MeasureString(TTexto.Text, objFont).Height);

            objFont = LTitulo.Font;
            int tituloAncho = System.Convert.ToInt32(objGraphics.MeasureString(LTitulo.Text, objFont).Width);
            int tituloAlto = System.Convert.ToInt32(objGraphics.MeasureString(LTitulo.Text, objFont).Height);

            int ancho = (mensajeAncho > tituloAncho ? mensajeAncho : tituloAncho) + 150;
            int alto = (mensajeAlto + tituloAlto) + 170;

            //------------------------------------------------------------------------------------------------------------------

            Screen pantalla = Screen.FromControl(this.Owner);

            //   if (mensajeAncho > SystemInformation.PrimaryMonitorSize.Width)

            if (mensajeAncho > pantalla.WorkingArea.Width - 150)
            {
                ancho = SystemInformation.PrimaryMonitorSize.Width - 200;
            }

            // if (mensajeAlto > SystemInformation.PrimaryMonitorSize.Height)
            if (mensajeAlto > pantalla.WorkingArea.Height - 150)
            {
                alto = SystemInformation.PrimaryMonitorSize.Height - 200;
            }

            this.Width = ancho;
            this.Height = alto;

            //this.Location = new Point
            //    (
            //        (SystemInformation.PrimaryMonitorSize.Width - this.Width) / 2,
            //        (SystemInformation.PrimaryMonitorSize.Height - this.Height) / 2
            //    );









            //****************************************************************************************


            //Screen pantalla = Screen.FromControl(this.Owner);

            //****************************************************************************************
            int x = 0;
            int y = 0;


            if (this.Owner.TopLevel == true)
            {
                x = this.Owner.Location.X + (this.Owner.Width - this.Width) / 2;
                y = this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2;

            }
            else
            {
                System.Windows.Forms.Form objFrmMenu = getMenu(this.Owner);

                if (this.Owner.Equals(objFrmMenu))
                {
                    x = this.Owner.Location.X + (this.Owner.Width - this.Width) / 2;
                    y = this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2;
                }
                else
                {
                    x = this.Owner.Location.X + (this.Owner.Width - this.Width) / 2 + objFrmMenu.Location.X;
                    y = this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2 + objFrmMenu.Location.Y;
                }
            }



            //Screen pantalla = Screen.FromControl(this.Owner);

            if (x < 0)
            {
                x = 0;
            }
            else if (this.Width + x > pantalla.WorkingArea.Width)
            {
                x -= (this.Width + x) - pantalla.WorkingArea.Width;
            }

            if (y < 0)
            {
                y = 0;
            }
            else if (this.Height + y > pantalla.WorkingArea.Height)
            {
                y -= (this.Height + y) - pantalla.WorkingArea.Height;
            }

            this.Location = new Point(x, y);
        }
        protected System.Windows.Forms.Form getMenu(System.Windows.Forms.Form f)
        {
            if (f.IsMdiChild)
                return f.MdiParent;
            else if (f.IsMdiContainer)
                return f;
            else if (f.Owner != null)
                return getMenu(f.Owner);
            return
                    null;
        }
        #endregion

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (ObjIcon != null)
            {
                e.Graphics.DrawIcon(ObjIcon, 0, 0);
            }
        }
    }
}
