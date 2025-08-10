using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANILLA.ESCRITORIO.Controles
{
    [System.Serializable]
    public static class ConvertForce
    {
        #region toByte

        public static byte toByte(short value)
        {
            //System.DateTime xx=;

            byte objObj = 0;
            try
            {
                objObj = System.Convert.ToByte(value);
            }
            catch { }
            return objObj;
        }

        public static byte toByte(int value)
        {
            byte objObj = 0;
            try
            {
                objObj = System.Convert.ToByte(value);
            }
            catch { }
            return objObj;
        }

        public static byte toByte(long value)
        {
            byte objObj = 0;
            try
            {
                objObj = System.Convert.ToByte(value);
            }
            catch { }
            return objObj;
        }

        public static byte toByte(decimal value)
        {
            byte objObj = 0;
            try
            {
                objObj = System.Convert.ToByte(value);
            }
            catch { }
            return objObj;
        }

        public static byte toByte(string value)
        {
            byte objObj = 0;
            try
            {
                objObj = System.Convert.ToByte(value);
            }
            catch { }
            return objObj;
        }

        public static byte toByte(object value)
        {
            byte objObj = 0;
            try
            {
                objObj = System.Convert.ToByte(value);
            }
            catch { }
            return objObj;
        }

        #endregion
        public static bool toBoolean(object value)
        {
            bool objObj = false;
            try
            {
                objObj = System.Convert.ToBoolean(value);
            }
            catch { }
            return objObj;
        }
        #region toShort

        public static short toShort(byte value)
        {
            short objObj = 0;
            try
            {
                objObj = System.Convert.ToInt16(value);
            }
            catch { }
            return objObj;
        }

        public static short toShort(int value)
        {
            short objObj = 0;
            try
            {
                objObj = System.Convert.ToInt16(value);
            }
            catch { }
            return objObj;
        }

        public static short toShort(long value)
        {
            short objObj = 0;
            try
            {
                objObj = System.Convert.ToInt16(value);
            }
            catch { }
            return objObj;
        }

        public static short toShort(decimal value)
        {
            short objObj = 0;
            try
            {
                objObj = System.Convert.ToInt16(value);
            }
            catch { }
            return objObj;
        }

        public static short toShort(string value)
        {
            short objObj = 0;
            try
            {
                objObj = System.Convert.ToInt16(value);
            }
            catch { }
            return objObj;
        }

        public static short toShort(object value)
        {
            short objObj = 0;
            try
            {
                objObj = System.Convert.ToInt16(value);
            }
            catch { }
            return objObj;
        }

        #endregion

        #region toInt

        public static int toInt(byte value)
        {
            int objObj = 0;
            try
            {
                objObj = System.Convert.ToInt32(value);
            }
            catch { }
            return objObj;
        }

        public static int toInt(short value)
        {
            int objObj = 0;
            try
            {
                objObj = System.Convert.ToInt32(value);
            }
            catch { }
            return objObj;
        }

        public static int toInt(long value)
        {
            int objObj = 0;
            try
            {
                objObj = System.Convert.ToInt32(value);
            }
            catch { }
            return objObj;
        }

        public static int toInt(decimal value)
        {
            int objObj = 0;
            try
            {
                objObj = System.Convert.ToInt32(value);
            }
            catch { }
            return objObj;
        }
        public static int toInt(string value)
        {
            int objObj = 0;
            try
            {
                objObj = System.Convert.ToInt32(value);
            }
            catch { }
            return objObj;
        }
        public static int toInt(object value)
        {
            int objObj = 0;
            try
            {
                objObj = System.Convert.ToInt32(value);
            }
            catch { }
            return objObj;
        }

        #endregion

        #region toLong

        public static long toLong(byte value)
        {
            long objObj = 0;
            try
            {
                objObj = System.Convert.ToInt64(value);
            }
            catch { }
            return objObj;
        }

        public static long toLong(short value)
        {
            long objObj = 0;
            try
            {
                objObj = System.Convert.ToInt64(value);
            }
            catch { }
            return objObj;
        }

        public static long toLong(int value)
        {
            long objObj = 0;
            try
            {
                objObj = System.Convert.ToInt64(value);
            }
            catch { }
            return objObj;
        }

        public static long toLong(decimal value)
        {
            long objObj = 0;
            try
            {
                objObj = System.Convert.ToInt64(value);
            }
            catch { }
            return objObj;
        }

        public static long toLong(string value)
        {
            long objObj = 0;
            try
            {
                objObj = System.Convert.ToInt64(value);
            }
            catch { }
            return objObj;
        }

        public static long toLong(object value)
        {
            long objObj = 0;
            try
            {
                objObj = System.Convert.ToInt64(value);
            }
            catch { }
            return objObj;
        }

        #endregion

        #region toDecimal

        public static decimal toDecimal(byte value)
        {
            decimal objObj = 0;
            try
            {
                objObj = System.Convert.ToDecimal(value);
            }
            catch { }
            return objObj;
        }

        public static decimal toDecimal(short value)
        {
            decimal objObj = 0;
            try
            {
                objObj = System.Convert.ToDecimal(value);
            }
            catch { }
            return objObj;
        }

        public static decimal toDecimal(int value)
        {
            decimal objObj = 0;
            try
            {
                objObj = System.Convert.ToDecimal(value);
            }
            catch { }
            return objObj;
        }

        public static decimal toDecimal(long value)
        {
            decimal objObj = 0;
            try
            {
                objObj = System.Convert.ToDecimal(value);
            }
            catch { }
            return objObj;
        }

        public static decimal toDecimal(string value)
        {
            decimal objObj = 0;
            try
            {
                objObj = System.Convert.ToDecimal(value);

            }
            catch { }
            return objObj;
        }
        public static decimal toDecimal(object value)
        {
            decimal objObj = 0;
            try
            {
                objObj = System.Convert.ToDecimal(value);
            }
            catch { }
            return objObj;
        }
        #endregion

        #region toString

        public static string toString(byte value)
        {
            string objObj = "";
            try
            {
                objObj = System.Convert.ToString(value);
            }
            catch { }
            return objObj;
        }

        public static string toString(short value)
        {
            string objObj = "";
            try
            {
                objObj = System.Convert.ToString(value);
            }
            catch { }
            return objObj;
        }

        public static string toString(int value)
        {
            string objObj = "";
            try
            {
                objObj = System.Convert.ToString(value);
            }
            catch { }
            return objObj;
        }

        public static string toString(long value)
        {
            string objObj = "";
            try
            {
                objObj = System.Convert.ToString(value);
            }
            catch { }
            return objObj;
        }

        public static string toString(decimal value)
        {
            string objObj = "";
            try
            {
                objObj = System.Convert.ToString(value);
            }
            catch { }
            return objObj;
        }

        public static string toString(object value)
        {
            string objObj = "";
            try
            {
                objObj = System.Convert.ToString(value);
            }
            catch { }
            return objObj;
        }

        public static string VoucherContable(int value, int ceros)
        {
            string objObj = "";
            try
            {
                objObj = System.Convert.ToString(value.ToString("D" + ceros));
            }
            catch { }
            return objObj;
        }
        #endregion

        #region toStringTrim

        public static string toStringTrim(byte value)
        {
            string objObj = "";
            try
            {
                objObj = Convert.toTrim(System.Convert.ToString(value));
            }
            catch { }
            return objObj;
        }

        public static string toStringTrim(short value)
        {
            string objObj = "";
            try
            {
                objObj = Convert.toTrim(System.Convert.ToString(value));
            }
            catch { }
            return objObj;
        }

        public static string toStringTrim(int value)
        {
            string objObj = "";
            try
            {
                objObj = Convert.toTrim(System.Convert.ToString(value));
            }
            catch { }
            return objObj;
        }

        public static string toStringTrim(long value)
        {
            string objObj = "";
            try
            {
                objObj = Convert.toTrim(System.Convert.ToString(value));
            }
            catch { }
            return objObj;
        }

        public static string toStringTrim(decimal value)
        {
            string objObj = "";
            try
            {
                objObj = Convert.toTrim(System.Convert.ToString(value));
            }
            catch { }
            return objObj;
        }

        public static string toStringTrim(object value)
        {
            string objObj = "";
            try
            {
                objObj = Convert.toTrim(System.Convert.ToString(value));
            }
            catch { }
            return objObj;
        }


        #endregion


    }
}
