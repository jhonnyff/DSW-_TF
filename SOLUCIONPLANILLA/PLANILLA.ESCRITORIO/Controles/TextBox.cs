using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLANILLA.ESCRITORIO.Controles
{
    public partial class TextBox : System.Windows.Forms.TextBox, IControl
    {
        public void FxFocus()
        {
            base.Focus();
            FxSetCursorToFinal();
        }


        public enum _FxCharacterCasing
        {
            Upper,
            Lower,
            Normal,
        }

        private _FxCharacterCasing __FxCharacterCasing;//= _FxCharacterCasing.Upper;
        public _FxCharacterCasing FxCharacterCasing
        {
            get { return __FxCharacterCasing; }
            set
            {
                __FxCharacterCasing = value;
                switch (value)
                {
                    case _FxCharacterCasing.Upper:
                        this.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                        break;
                    case _FxCharacterCasing.Lower:
                        this.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
                        break;
                    case _FxCharacterCasing.Normal:
                        this.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                        break;
                }
            }
        }


        public TextBox()
        {
            // this.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        }

        ~TextBox()
        {

        }

        private bool _FxEditable = true;
        public bool FxEditable
        {
            set
            {
                _FxEditable = value;
            }
            get
            {
                return _FxEditable;
            }
        }

        #region FxText


        public byte FxTextToByte { get { return ConvertForce.toByte(this.Text); } }
        public short FxTextToShort { get { return ConvertForce.toShort(this.Text); } }
        public int FxTextToInt { get { return ConvertForce.toInt(this.Text); } }
        public long FxTextToLong { get { return ConvertForce.toLong(this.Text); } }
        public decimal FxTextToDecimal { get { return ConvertForce.toDecimal(this.Text); } }

        public string FxTextToTrim { get { return Convert.toTrim(this.Text); } }

        #endregion

        public void FxClear()
        {
            this.Text = "";
            this.Refresh();
        }
        public string FxText
        {
            set
            {
                this.Text = value;
                this.Refresh();
            }
            get { return this.Text; }
        }

        public void FxAutoCompleteNow(char value)
        {
            this.Text = this.Text.Trim();
            while (this.Text.Length < this.MaxLength)
            {
                this.Text = value + this.Text;
            }
        }

        public string FxAutoCompletePreview(char value)
        {
            string str = this.Text.Trim();
            while (str.Length < this.MaxLength)
            {
                str = value + str;
            }
            return str;
        }


        private bool _FxBlockEnterKey = true;
        public bool FxBlockEnterKey { get { return _FxBlockEnterKey; } set { _FxBlockEnterKey = value; } }


        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (_FxEditable == false)
            {
                e.Handled = true;
            }
            else

                FxMaskType_KeyPress(e);


        }



        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (_FxEditable == false)
            {
                if (e.KeyCode != System.Windows.Forms.Keys.Up && e.KeyCode != System.Windows.Forms.Keys.Down && e.KeyCode != System.Windows.Forms.Keys.Right && e.KeyCode != System.Windows.Forms.Keys.Left)
                    e.Handled = true;
            }
        }


        public void FxSetCursorToFinal()
        {
            if (base.Text.Length > 0)
            {
                base.SelectionStart = this.Text.Length;
                base.SelectionLength = 0;
            }
        }
        public void FxSetCursorToInicio()
        {
            if (base.Text.Length > 0)
            {
                base.SelectionStart = 0;
                base.SelectionLength = 0;
            }
        }


        private string TextoCorrecto = "";
        protected override void OnEnter(System.EventArgs e)
        {
            base.OnEnter(e);
        }

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);

            switch (FxMaskType)
            {
                case __TextBox_TipoMascara.NumeroPunto:

                    break;
            }

        }
        private const int WM_PASTE = 0x0302;

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg != WM_PASTE)
            {
                // Handle all other messages normally
                base.WndProc(ref m);
            }
            else
            {
                // Some simplified example code that complete replaces the
                // text box content only if the clipboard contains a valid double.
                // I'll leave improvement of this behavior as an exercise :)
                decimal value;
                if (Clipboard.GetText().Length + this.Text.Length <= this.MaxLength)
                {
                    switch (FxMaskType)
                    {
                        case __TextBox_TipoMascara.Numeros:
                        case __TextBox_TipoMascara.NumeroPunto:
                        case __TextBox_TipoMascara.NumeroPuntoComa:
                        case __TextBox_TipoMascara.NumeroComa:
                            if (decimal.TryParse(Clipboard.GetText(), out value))
                            {
                                int x = this.SelectionStart;
                                Text = Text.Insert(this.SelectionStart, value.ToString());
                                this.SelectionStart = x + value.ToString().Length;
                                this.SelectionLength = 0;
                            }
                            break;
                        default:
                            base.WndProc(ref m);
                            break;
                    }
                }
            }
        }

        #region FxMaskType

        public enum __TextBox_TipoMascara
        {
            Ninguno,
            Numeros,
            Letras,
            NumeroPunto,
            NumeroPuntoComa,
            NumeroComa,
            NumerosLetras,
            CaracteresAceptar,
            CaracteresDenegar,
            NumerosLetrasEspacioEnBlanco,
            NumeroPuntoYSignoNegativo,
            NumeroIp,
            FechaMesAño,
        }

        private __TextBox_TipoMascara _MaskType = __TextBox_TipoMascara.Ninguno;
        public __TextBox_TipoMascara FxMaskType { get { return _MaskType; } set { _MaskType = value; } }
        private string _CaracteresAceptar;
        public string FxMaskType_CaracteresAceptar { get { return _CaracteresAceptar; } set { _CaracteresAceptar = value; } }
        private string _CaracteresDenegar;
        public string FxMaskType_CaracteresDenegar { get { return _CaracteresDenegar; } set { _CaracteresDenegar = value; } }

        private void FxMaskType_KeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 13)
            {
                if (_FxBlockEnterKey)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (System.Convert.ToInt32(e.KeyChar) == 8) return;
            switch (_MaskType)
            {
                case __TextBox_TipoMascara.NumeroPuntoYSignoNegativo:
                    if (e.KeyChar == System.Convert.ToChar(".") && this.Text.IndexOf(System.Convert.ToChar(".")) > -1)
                        e.Handled = true;
                    else if (e.KeyChar == System.Convert.ToChar("-") && this.Text.IndexOf(System.Convert.ToChar("-")) > -1)
                        e.Handled = true;
                    else if (!char.IsNumber(e.KeyChar) && e.KeyChar != System.Convert.ToChar(".") && e.KeyChar != System.Convert.ToChar("-"))
                        e.Handled = true;
                    break;
                case __TextBox_TipoMascara.Letras:
                    if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ') e.Handled = true;
                    break;
                case __TextBox_TipoMascara.NumeroPunto:
                    if (e.KeyChar == System.Convert.ToChar(".") && this.Text.IndexOf(System.Convert.ToChar(".")) > -1)
                        e.Handled = true;
                    else if (!char.IsNumber(e.KeyChar) && e.KeyChar != System.Convert.ToChar("."))
                        e.Handled = true;
                    break;
                case __TextBox_TipoMascara.NumeroIp:
                    if (e.KeyChar == System.Convert.ToChar(".") && this.Text.Split('.').Count() > 3)
                        e.Handled = true;
                    else if (!char.IsNumber(e.KeyChar) && e.KeyChar != System.Convert.ToChar("."))
                        e.Handled = true;
                    break;
                case __TextBox_TipoMascara.NumeroPuntoComa:
                    if (e.KeyChar == System.Convert.ToChar(".") && this.Text.IndexOf(System.Convert.ToChar(".")) > -1)
                        e.Handled = true;
                    else if (e.KeyChar == System.Convert.ToChar(",") && this.Text.IndexOf(System.Convert.ToChar(",")) > -1)
                        e.Handled = true;
                    else if (!char.IsNumber(e.KeyChar) && e.KeyChar != System.Convert.ToChar(".") && e.KeyChar != System.Convert.ToChar(","))
                        e.Handled = true;
                    break;
                case __TextBox_TipoMascara.NumeroComa:
                    if (e.KeyChar == System.Convert.ToChar(",") && this.Text.IndexOf(System.Convert.ToChar(",")) > -1)
                        e.Handled = true;
                    else if (!char.IsNumber(e.KeyChar) && e.KeyChar != System.Convert.ToChar(",")) e.Handled = true;
                    break;
                case __TextBox_TipoMascara.Numeros:
                    if (!char.IsNumber(e.KeyChar)) e.Handled = true;
                    break;
                case __TextBox_TipoMascara.NumerosLetras:
                    if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
                    break;
                case __TextBox_TipoMascara.NumerosLetrasEspacioEnBlanco:
                    if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ') e.Handled = true;
                    break;
                case __TextBox_TipoMascara.CaracteresAceptar:
                    if (_CaracteresAceptar.IndexOf(e.KeyChar) == -1) e.Handled = true;
                    break;
                case __TextBox_TipoMascara.CaracteresDenegar:
                    if (_CaracteresAceptar.IndexOf(e.KeyChar) != -1) e.Handled = true;
                    break;
            }

        }

        #endregion

        private System.Windows.Forms.Control[] _ObjPanel;
        public System.Windows.Forms.Control[] ObjPanel
        {
            get
            {
                return _ObjPanel;
            }
            set
            {
                _ObjPanel = value;
            }
        }

    }
}
