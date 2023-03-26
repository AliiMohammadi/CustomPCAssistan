using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strucures;

namespace Application
    {
        internal class CommandExcuter
        {
            public static CommandManager Commandmanager = new CommandManager();

            /// <summary>
            /// اجرای یک دستور با استفاده از اسم ان
            /// </summary>
            /// <param name="commanname"></param>
            /// <returns>درصورت اجرای موجود بودن دستور صحیح برگردانده میشود</returns>
            public static bool Excute(string commanname)
            {
                CommandData commmandData = Commandmanager.GetCommand(commanname);

                if (commmandData == null)
                    return false;

                switch (commmandData.CommandType)
                {
                    case Strucures.CommandTypes.Address:
                        string addres = Commandmanager.UserCommands[commanname].Value;
                        Operating_system.OSactions.OpenPath(addres);
                        break;
                    case Strucures.CommandTypes.Systematic:
                        Commandmanager.SystematicCommands[commanname].Operation();
                        break;
                    case Strucures.CommandTypes.Applicational:
                        Commandmanager.SystematicCommands[commanname].Operation();
                        break;
                    case Strucures.CommandTypes.Note:
                        //commandManager.UserCommands[commanname].Value;
                        break;
                    default:
                        break;
                }

                return true;
            }

            public static void AddCommand(string name,string value)
            {
                 Commandmanager.AddCommand(new UserCommand(name, value, CommandTypes.Address));
            }
            public static void AddCommand(string name, string value, CommandTypes type)
            {
                Commandmanager.AddCommand(new UserCommand(name, value, type));
            }

            public static void DeleteCommand(string name)
            {
                 Commandmanager.DeleteCommand(name);
            }

            public static void UpdateCommand(string name , string value)
            {
                UserCommand olddata = Commandmanager.GetUserCommand(name);

                if (olddata == null)
                    throw new Exception($"Name '{name}' does not exist.");
                else
                {
                    Commandmanager.UpdateCommand(new UserCommand(olddata.Name, value, olddata.CommandType));
                }
            }

            public static List<CommandData> GetSimilars(string name)
            {
                List<CommandData> newlist = new List<CommandData>();

                if (string.IsNullOrEmpty(name))
                    return newlist;

                Dictionary<string,StabelCommand> collection1 = Commandmanager.SystematicCommands;
                Dictionary<string,UserCommand> collection2 = Commandmanager.UserCommands;

                foreach (StabelCommand value in collection1.Values)
                {
                    if (!string.IsNullOrEmpty(value.Name))
                    {
                        string word = Melt(value.Name);
                        bool Compair = word.StartsWith(name);

                        if (Compair)
                            newlist.Add(value);
                    }
                }
                foreach (UserCommand value in collection2.Values)
                {
                    if (!string.IsNullOrEmpty(value.Name))
                    {
                        string word = Melt(value.Name);
                        bool Compair = word.StartsWith(Melt(name));

                        if (Compair)
                            newlist.Add(value);
                    }
                }

                return newlist;
            }

            /// <summary>
            /// استاندارد کرده یک کلمه 
            /// کلمه انگلیسی رو به عبارت کوچک تبدیل میکند و فاصله ان را میگید
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            static string Melt(string value)
            {
                return Commandmanager.Melt(value);
            }
        }
    }
