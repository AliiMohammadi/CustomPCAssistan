using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneeChanRemake;

namespace OneeChanRemake.FormControl
{
    /// <summary>
    /// کلاس کنترول کننده ترمینال یا تکست باکس ورودی دستور در صفحه اصلی
    /// </summary>
    internal class TerminalControl
    {
        /// <summary>
        /// شعی خود تکست باکس
        /// </summary>
        public static TextBox TerminalLine;
        /// <summary>
        /// مقدار نوشته خود تکست باکس
        /// </summary>
        public static string TerminalLineText
        {
            get { return TerminalLine.Text; }
            set { TerminalLine.Text = value; }
        }
        /// <summary>
        /// طول نوشته در حال حاظر
        /// </summary>
        public static int Length
        {
            get { return TerminalLine.Text.Length;}
        }

        /// <summary>
        /// پاک کردن تکست باکس
        /// </summary>
        public static void Clear()
        {
            TerminalLine.Clear();
        }
        /// <summary>
        /// اجرا کردن هر دستوری که نوشته شده
        /// </summary>
        public static void Execute()
        {
            string command = TerminalLine.Text;

            try
            {
                ExecuteCommand(command);
            }
            catch (Exception ex )
            {
                LogLabelControler.PrintError(ex.Message);
            }

            
            Clear();
        }
        public static void KeyPressAction(KeyEventArgs e)
        {

            Keys key = e.KeyCode;

            if (key == Keys.Enter)
            {
                AutoCompleteControler.ExecuteSelectedItem();//اینجا اگه ایتمی انتخواب شده باشه رو اجرا میکنه و خط بعدی اجرا نمیشه.

                if (Length > 0) //این خط اجرا نمیشه اگه خط بالایی اجرا شده باشه
                    Execute();
            }
            else if (key == Keys.Escape)
            {
                Clear();
            }
        }


        static void ExecuteCommand(string command)
        {
            LogLabelControler.Clear();
            Application.LibraryCommand.Excute(command);
        }
    }
}
