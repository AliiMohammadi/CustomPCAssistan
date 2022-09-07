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
            public static bool Excute(string commanname, Strucures.CommandManager commandManager)
            {
                if(!commandManager.IsExist(commanname))
                    return false;


                Strucures.CommandData commmandData = commandManager.GetCommand(commanname);

                switch (commmandData.CommandType)
                {
                    case Strucures.CommandTypes.Address:
                        //commandManager.UserCommands[commanname].Value;
                        Console.WriteLine(commandManager.GetUserCommand(commanname).Value);
                        break;
                    case Strucures.CommandTypes.Systematic:
                        commandManager.SystematicCommands[commanname].Operation();
                        break;
                    case Strucures.CommandTypes.Applicational:
                        commandManager.SystematicCommands[commanname].Operation();
                        break;
                    case Strucures.CommandTypes.Note:
                        //commandManager.UserCommands[commanname].Value;
                        break;
                    default:
                        break;
                }

                return true;
            }
        }
    }
}
