using System;
using System.Collections.Generic;
using CommandExecutor;

namespace Test_Console
{
    namespace Strucures
    {
        /// <summary>
        /// جایی که دستورات و مقدارشون داخلش هستش 
        /// </summary>
        public class CommandManager
        {
            /// <summary>
            /// کلاس مجموع دستورات
            /// </summary>
            public class CommandCollections
            {
                //لیست دستورات سیستمی
                /// <summary>
                /// لیست دستورات سیستمی
                /// </summary>
                public static Dictionary<string, CommandData> SystematicCommands = new Dictionary<string, CommandData>()
                {
                    {"ShutDownPC",new CommandData("ShutDownPC", delegate(){Console.WriteLine("Shutdown");},CommandData.CommandTypes.Systematic) },
                    {"RestartPC",new CommandData("RestartPC", delegate(){Console.WriteLine("Restart");},CommandData.CommandTypes.Systematic) },
                    {"SleepPC",new CommandData("SleepPC", delegate(){Console.WriteLine("Sleep");},CommandData.CommandTypes.Systematic) },
                    {"LockPC",new CommandData("LockPC", delegate(){Console.WriteLine("Lock");},CommandData.CommandTypes.Systematic) },
                };
                /// <summary>
                /// لیست دستوران و اطلاعات ان که بازیابی شده
                /// مقدار اسم کلید اصلی است و نباید تکراری باشد
                /// </summary>
                public static Dictionary<string, CommandData> UserCommands = new Dictionary<string, CommandData>();
            }
            /// <summary>
            /// تعداد دستورات
            /// </summary>
            public static int UserCommandsCount
            {
                get { return CommandCollections.UserCommands.Count; }
            }

            /// <summary>
            /// باز یابی دستوری با توجه به اسم ان از لیست
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public static CommandData GetCommand(string name)
            {
                CommandData data;

                if (!CommandCollections.UserCommands.TryGetValue(name, out data))
                    CommandCollections.SystematicCommands.TryGetValue(name, out data);

                return data;
            }
            /// <summary>
            /// اضافه کردن دستور جدید 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns></returns>
            public static CommandData AddCommand(string name, string value)
            {
                if (IsExist(name))
                    throw new InvalidOperationException($"The key {name} is alredy exist.");
                else
                {
                    CommandData newdata = new CommandData(name, value);
                    CommandCollections.UserCommands.Add(newdata.Name, newdata);
                    return newdata;
                }
            }
            /// <summary>
            /// حذف کردن یک دستور از لیست با اسم
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public static bool DeleteCommand(string name)
            {
                return CommandCollections.UserCommands.Remove(name);
            }
            /// <summary>
            /// بروز کردن دستور در لیست
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns> مقدار درست درصورت موفقیت</returns>
            public static bool UpdateCommand(string name, string value)
            {
                if (CommandCollections.UserCommands.ContainsKey(name))
                {
                    CommandCollections.UserCommands[name] = new CommandData(name, value);
                    return true;
                }
                else
                    return false;
            }

            /// <summary>
            /// برسی میکند که ایا اسم داخل لیست مجود دارد یا خیر
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public static bool IsExist(string name)
            {
                return (CommandCollections.UserCommands.ContainsKey(name) || CommandCollections.SystematicCommands.ContainsKey(name));
            }
        }
        /// <summary>
        /// کلاس اطلاعات دستور
        /// </summary> 
        public class CommandData
        {
            public enum CommandTypes
            {
                Systematic, Applicational , Address , Note
            }
            public CommandTypes CommandType { get; set; }

            public string Name { get; set; }
            public string Value { get; set; }
            /// <summary>
            /// درصورتی که دستور از نوع سیستماتیک یا اپلیکیشنی باشه این تابع انجام عملیات میده 
            /// </summary>
            public Action CommandOperation;

            public CommandData(string name, string value)
            {
                Name = name;
                Value = value;
                CommandType = CommandTypes.Address;
            }
            public CommandData(string name, string value,CommandTypes type)
            {
                Name = name;
                Value = value;
                CommandType = type;
            }
            public CommandData(string name, Action operation, CommandTypes type)
            {
                Name = name;
                CommandOperation = operation;
                CommandType = type;
            }
        }
    }
}

//نحوه اضافه کردن دستورات سیستمی یا اپلیکیشنی:
//به کلاس کنترلر کامند ها بروید
//به زیر کلاس مجموعه کامند ها بروید
//یک شعی با نام دستورات سیستمی وجود دارد که به صورت کالکشن هست
//انجا به لیست اضافه کنید.
//
//توضیحات کلاس کامنددیتا:
//این کلاس اطلاعات یک دستور برنامه هستش که شامل اسم دستور 
//مقدار ان
//نوع دستور و یک دلیگیت برای عملیات خاص انجام میشه.
//دقت داشته باشید که اگر نوع سیسستمی باشه دلیگیت عملیات باید پر بشه.

