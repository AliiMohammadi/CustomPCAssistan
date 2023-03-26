using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneeChanRemake.FormControl
{
    /// <summary>
    /// کلاس کنترول کننده نوشته لوگ پایین صفحه اصلی
    /// </summary>
    internal class LogLabelControler
    {
        public static Label Loglabel;

        static Color messagecolor = Color.Black;
        static Color Errorcolor = Color.Red;
        static Color Warningcolor = Color.Yellow;

        public static void Print(object message)
        {
            Print(message.ToString(), messagecolor);
        }
        public static void PrintError(object message)
        {
            Print(message.ToString(), Errorcolor);
        }
        public static void PrintWarning(object message)
        {
            Print(message.ToString(), Warningcolor);
        }
        public static void Print(object message,Color forcolor)
        {
            SetColor(forcolor);
            SetLabel(message.ToString());
        }
        public static void Clear()
        {
            Loglabel.Text = string.Empty;
        }

        static void SetColor(Color color)
        {
            Loglabel.ForeColor = color;
        }
        static void SetLabel(string message)
        {
            Loglabel.Text = message;
        }
    }
}
