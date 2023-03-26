using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneeChanRemake.FormControl
{
    internal class KeyInput
    {
        public static char EnterCommand = Convert.ToChar(Keys.Enter);
        public static char SelectSugges = Convert.ToChar(Keys.Up);
        public static char ESC = Convert.ToChar(Keys.Escape);

        public static bool IsTropeInput(char input)
        {
            return (Encoding.UTF8.GetByteCount(new char[] { input }) > 1);
        }
    }
}
