using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANILLA.ESCRITORIO.Controles
{
    [System.Serializable]
    public static class Convert
    {
        public static decimal enKilobytes(Image imagen)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagen.Save(ms,
                System.Drawing.Imaging.ImageFormat.Jpeg);
            return System.Convert.ToDecimal(ms.Length) / System.Convert.ToDecimal(1024);
        }
        public static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }
        public static byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }
        public static string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }
        public static Image ResizeImage(string Ruta, int newWidth, int newHeight)
        {
            Bitmap source = new Bitmap(Ruta);
            return ResizeImage(source, newWidth, newHeight);
        }
        public static Image ResizeImage(Image srcImage, int newWidth, int newHeight)
        {
            using (Bitmap imagenBitmap = new Bitmap(newWidth, newHeight, PixelFormat.Format32bppRgb))
            {
                imagenBitmap.SetResolution(System.Convert.ToInt32(srcImage.HorizontalResolution), System.Convert.ToInt32(srcImage.HorizontalResolution));
                using (Graphics imagenGraphics = Graphics.FromImage(imagenBitmap))
                {
                    imagenGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                    imagenGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    imagenGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    imagenGraphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(0, 0, srcImage.Width, srcImage.Height), GraphicsUnit.Pixel);
                    MemoryStream imagenMemoryStream = new MemoryStream();
                    imagenBitmap.Save(imagenMemoryStream, ImageFormat.Png);
                    srcImage = Image.FromStream(imagenMemoryStream);
                }
            }
            return srcImage;


        }
        public static Image ResizeImagePng(Image srcImage, int newWidth, int newHeight)
        {
            Stream imageStream = new MemoryStream();

            using (Image src = srcImage)
            {
                using (Bitmap dst = new Bitmap(newWidth, newHeight))
                {
                    using (Graphics g = Graphics.FromImage(dst))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.DrawImage(src, 0, 0, dst.Width, dst.Height);
                    }
                    dst.Save(imageStream, ImageFormat.Png);
                }
            }

            return Image.FromStream(imageStream);
        }
        public static System.Drawing.Image toImage(byte[] objArrayByte)
        {
            try
            {
                System.IO.MemoryStream objMemoryStream = new System.IO.MemoryStream(objArrayByte);
                return System.Drawing.Image.FromStream(objMemoryStream);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message, ex.InnerException);
            }
        }
        public static byte[] toArrayByte(System.Drawing.Image objImage)
        {
            try
            {
                System.IO.MemoryStream objMemoryStream = new System.IO.MemoryStream();

                //string x = objImage.PixelFormat  .ToString();
                //objImage .RawFormat .ToString 
                //System .Drawing .Imaging .ImageFormat 

                if (objImage.PixelFormat == System.Drawing.Imaging.PixelFormat.Format24bppRgb)
                    objImage.Save(objMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (objImage.PixelFormat == System.Drawing.Imaging.PixelFormat.Format32bppArgb)
                    objImage.Save(objMemoryStream, System.Drawing.Imaging.ImageFormat.Png);




                return objMemoryStream.ToArray();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message, ex.InnerException);
            }
        }
        public static byte[] toArrayByte(System.Drawing.Image objImage, System.Drawing.Imaging.ImageFormat formato)
        {
            try
            {
                System.IO.MemoryStream objMemoryStream = new System.IO.MemoryStream();

                objImage.Save(objMemoryStream, formato);

                return objMemoryStream.ToArray();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message, ex.InnerException);
            }
        }
        public static string toTrim(string value)
        {
            while (value.IndexOf("  ") > -1)
            {
                value = value.Replace("  ", " ");
            }
            return value.Trim();
        }




        #region fechaHora
        public static int convertirAMin24H(string hora)
        {
            int h;
            int m;
            h = ConvertForce.toInt(hora.Substring(0, 2));
            m = ConvertForce.toInt(hora.Substring(3, 2));
            return h * 60 + m;

        }
        public static IEnumerable<DateTime> AllDatesInMonth(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= days; day++)
            {
                yield return new DateTime(year, month, day);
            }
        }


        /// <summary>
        /// formato de la hora: 01:15AM
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string fechaHora_Hora_Formato1(System.DateTime value)
        {
            return
                (value.Hour < 10 ? "0" : "") + (value.Hour > 12 ? value.Hour - 12 : value.Hour).ToString() +
                ":" +
                (value.Minute < 10 ? "0" : "") + value.Minute.ToString() +
                (value.Hour > 11 ? "PM" : "AM");
        }
        /// <summary>
        /// formato de la hora: 01:15:48AM
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string fechaHora_Hora_Formato2(System.DateTime value)
        {
            return
                (value.Hour < 10 ? "0" : "") + (value.Hour > 12 ? value.Hour - 12 : value.Hour).ToString() +
                ":" +
                (value.Minute < 10 ? "0" : "") + value.Minute.ToString() +
                ":" +
                (value.Second < 10 ? "0" : "") + value.Second.ToString() +
                (value.Hour > 11 ? "PM" : "AM");
        }
        /// <summary>
        /// retorna el nombre del mes, ejemplo: ENERO, FEBRERO, MARZO, ABRIL, MAYO, JUNIO, JULIO, AGOSTO, SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string fechaHora_Mes_Nombre(System.DateTime value)
        {
            return fechaHora_Mes_Nombre(value.Month);
        }
        /// <summary>
        /// retorna el nombre del mes, ejemplo: ENERO, FEBRERO, MARZO, ABRIL, MAYO, JUNIO, JULIO, AGOSTO, SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string fechaHora_Mes_Nombre(byte value)
        {
            switch (value)
            {
                case 1: return "ENERO";
                case 2: return "FEBRERO";
                case 3: return "MARZO";
                case 4: return "ABRIL";
                case 5: return "MAYO";
                case 6: return "JUNIO";
                case 7: return "JULIO";
                case 8: return "AGOSTO";
                case 9: return "SEPTIEMBRE";
                case 10: return "OCTUBRE";
                case 11: return "NOVIEMBRE";
                case 12: return "DICIEMBRE";
                default: return null;
            }
        }
        /// <summary>
        /// retorna el nombre del mes, ejemplo: ENERO, FEBRERO, MARZO, ABRIL, MAYO, JUNIO, JULIO, AGOSTO, SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string fechaHora_Mes_Nombre(int value)
        {
            return fechaHora_Mes_Nombre(System.Convert.ToByte(value));
        }
        public static string fechaHora_Dia_Nombre(System.DateTime value)
        {
            return fechaHora_Dia_Nombre(System.Convert.ToInt32(value.DayOfWeek));
        }
        /// <summary>
        /// retorna: el nombre del dia de la semana, ejemplo: LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string fechaHora_Dia_Nombre(int value)
        {
            switch (value)
            {
                case 1: return "LUNES";
                case 2: return "MARTES";
                case 3: return "MIERCOLES";
                case 4: return "JUEVES";
                case 5: return "VIERNES";
                case 6: return "SABADO";
                case 7: case 0: return "DOMINGO";
                default: return "";
            }
        }
        /// <summary>
        /// Retorna01 DEL MES DE FEBRERO DEL DOS MIL VEINTE
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FechaCompletaaLetras(DateTime value)
        {
            return $"{value.Day.ToString("D2")} del mes de {fechaHora_Mes_Nombre(value.Month)} del {NumberToLetters.ToCardinal(value.Year)}";
        }
        /// <summary>
        /// 01 DE FEBRERO DEL 2020
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FechaCompletaaLetrasSinAño(DateTime value)
        {
            return $"{value.Day.ToString("D2")} de {fechaHora_Mes_Nombre(value.Month)} del {value.Year}";
        }
        #endregion

        /// <summary>
        /// Calculates the age in years of the current System.DateTime object today.
        /// </summary>
        /// <param name="birthDate">The date of birth</param>
        /// <returns>Age in years today. 0 is returned for a future date of birth.</returns>
        public static int Años(this DateTime birthDate)
        {
            return Age(birthDate, DateTime.Today);
        }

        /// <summary>
        /// Calculates the age in years of the current System.DateTime object on a later date.
        /// </summary>
        /// <param name="birthDate">The date of birth</param>
        /// <param name="laterDate">The date on which to calculate the age.</param>
        /// <returns>Age in years on a later day. 0 is returned as minimum.</returns>
        public static int Age(this DateTime birthDate, DateTime laterDate)
        {
            int age;
            age = laterDate.Year - birthDate.Year;

            if (age > 0)
            {
                age -= ConvertForce.toInt(laterDate.Date < birthDate.Date.AddYears(age));
            }
            else
            {
                age = 0;
            }

            return age;
        }
        public struct DateTimeSpan
        {
            private readonly int years;
            private readonly int months;
            private readonly int days;
            private readonly int hours;
            private readonly int minutes;
            private readonly int seconds;
            private readonly int milliseconds;
            public DateTimeSpan(int years, int months, int days, int hours, int minutes, int seconds, int milliseconds)
            {
                this.years = years; this.months = months; this.days = days; this.hours = hours; this.minutes = minutes; this.seconds = seconds; this.milliseconds = milliseconds;
            }
            public int Years { get { return years; } }
            public int Months { get { return months; } }
            public int Days { get { return days; } }
            public int Hours { get { return hours; } }
            public int Minutes { get { return minutes; } }
            public int Seconds { get { return seconds; } }
            public int Milliseconds { get { return milliseconds; } }
            enum Phase { Years, Months, Days, Done }
            public static DateTimeSpan CompareDates(DateTime date1, DateTime date2)
            {
                if (date2 < date1) { var sub = date1; date1 = date2; date2 = sub; }
                DateTime current = date1;
                int years = 0;
                int months = 0;
                int days = 0;
                Phase phase = Phase.Years;
                DateTimeSpan span = new DateTimeSpan();
                while (phase != Phase.Done)
                {
                    switch (phase)
                    {
                        case Phase.Years: if (current.AddYears(years + 1) > date2) { phase = Phase.Months; current = current.AddYears(years); } else { years++; } break;
                        case Phase.Months: if (current.AddMonths(months + 1) > date2) { phase = Phase.Days; current = current.AddMonths(months); } else { months++; } break;
                        case Phase.Days:
                            if (current.AddDays(days + 1) > date2)
                            {
                                current = current.AddDays(days); var timespan = date2 - current;
                                span = new DateTimeSpan(years, months, days, timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.Milliseconds); phase = Phase.Done;
                            }
                            else { days++; }
                            break;
                    }
                }
                return span;
            }
        }

    }
}
