using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneeChanRemake;

namespace OneeChanRemake.FormControl
{
    internal class TerminalControl
    {
        public static TextBox TerminalLine;
        public static int Length
        {
            get { return TerminalLine.Text.Length;}
        }

        public static void Clear()
        {
            TerminalLine.Clear();
        }

        public static void Execute()
        {
            string command = TerminalLine.Text;

            if (!ExecuteCommand(command))
                Console.WriteLine(@"Error. Command : " + command + " is not exist." );
            Clear();
        }

        static bool ExecuteCommand(string command)
        {
            return Application.CommandExcuter.Excute(command);
        }
    }
}
