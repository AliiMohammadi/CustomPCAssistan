using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_Console
{
    namespace Application
    {
        internal class CommandExcuter
        {
            /// <summary>
            /// اجرای یک دستور با استفاده از اسم ان
            /// </summary>
            /// <param name="commanname"></param>
            /// <returns>درصورت اجرای موجود بودن دستور صحیح برگردانده میشود</returns>
            public static bool Excute(string commanname)
            {
                if(!Strucures.CommandManager.IsExist(commanname))
                    return false;

                Strucures.CommandData commmand = Strucures.CommandManager.GetCommand(commanname);

                switch (commmand.CommandType)
                {
                    case Strucures.CommandData.CommandTypes.Address:

                        break;
                    case Strucures.CommandData.CommandTypes.Systematic:
                        commmand.CommandOperation();
                        break;
                    case Strucures.CommandData.CommandTypes.Applicational:
                        commmand.CommandOperation();
                        break;
                    case Strucures.CommandData.CommandTypes.Note:

                        break;
                    default:
                        break;
                }

                return true;
            }
        }
    }
}
