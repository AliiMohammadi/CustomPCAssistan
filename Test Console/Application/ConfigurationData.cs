using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Console.Application
{
    internal class ConfigurationData
    {
        public bool IsMute { get; set; }
        public int SoundVolum { get; set; }
        public Point WindowSize { get; set; }

        public ConfigurationData()
        {

        }
    }
}
