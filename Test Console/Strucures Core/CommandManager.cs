using System;
using System.Collections.Generic;
using CommandExecutor;

namespace Test_Console
{
    namespace Strucures
    {
        /// <summary>
        /// کلاس نگه دارنده لیست دستورات سیستمی یو کاربری و عملیات برای انان
        /// </summary>
        public class CommandManager
        {
                //لیست ها
            /// <summary>
            /// لیست دستورات سیستمی
            /// مقدار اسم کلید اصلی است و نباید تکراری باشد
            /// </summary>
            public Dictionary<string, StabelCommand> SystematicCommands;
            /// <summary>
            /// لیست دستوران و اطلاعات ان که بازیابی شده
            /// مقدار اسم کلید اصلی است و نباید تکراری باشد
            /// </summary>
            public Dictionary<string, UserCommand> UserCommands;

            public CommandManager()
            {
                SystematicCommands = new Dictionary<string, StabelCommand>();
                UserCommands = new Dictionary<string, UserCommand>();   
            }
            /// <summary>
            /// تعداد کل دستورات موجود
            /// </summary>
            public uint CommandsCount
            {
                get { return (uint)(UserCommands.Count + SystematicCommands.Count); }
            }
                //بازیابی
            /// <summary>
            /// باز یابی دستوری با توجه به اسم ان از لیست
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public CommandData GetCommand(string name)
            {
                CommandData data = null;

                try
                {
                    data = UserCommands[name];
                }
                catch { }

                try
                {
                    if (data == null)
                        data = SystematicCommands[name];
                }
                catch { }


                return data;
            }
            /// <summary>
            /// باز یابی دستوری با توجه به اسم ان از لیست
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public UserCommand GetUserCommand(string name)
            {
                UserCommand data = null;
                UserCommands.TryGetValue(name,out data);
                return data;
            }
            /// <summary>
            /// باز یابی دستوری با توجه به اسم ان از لیست
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public StabelCommand GetStabelCommand(string name)
            {
                StabelCommand data = null;
                SystematicCommands.TryGetValue(name,out data);
                return data;
            }
                //اضافه
            /// <summary>
            /// اضافه کردن دستور جدید 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns></returns>
            public void AddCommand(StabelCommand stabelCommand)
            {
                string name = stabelCommand.Name;
                if (IsExist(name))
                    throw new InvalidOperationException($"The key '{name}' is alredy exist.");
                else
                {
                    StabelCommand newdata = stabelCommand;
                    SystematicCommands.Add(newdata.Name, newdata);
                }
            }
            /// <summary>
            /// اضافه کردن دستور جدید 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns></returns>
            public void AddCommand(UserCommand userCommand)
            {
                string name = userCommand.Name;
                if (IsExist(name))
                    throw new InvalidOperationException($"The key '{name}' is alredy exist.");
                else
                {
                    UserCommand newdata = userCommand;
                    UserCommands.Add(newdata.Name, newdata);
                }
            }

            /// <summary>
            /// اضافه کردن دستور جدید 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns></returns>
            public StabelCommand AddCommand(string name,Action operation,CommandTypes commandType)
            {
                if (IsExist(name))
                    throw new InvalidOperationException($"The key {name} is alredy exist.");
                else
                {
                    StabelCommand newdata = new StabelCommand(name, operation , commandType);
                    SystematicCommands.Add(newdata.Name, newdata);
                    return newdata;
                }
            }
            /// <summary>
            /// اضافه کردن دستور جدید 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns></returns>
            public UserCommand AddCommand(string name, string value, CommandTypes commandType)
            {
                if (IsExist(name))
                    throw new InvalidOperationException($"The key {name} is alredy exist.");
                else
                {
                    UserCommand newdata = new UserCommand(name, value, commandType);
                    UserCommands.Add(newdata.Name, newdata);
                    return newdata;
                }
            }
                //حذف
            /// <summary>
            /// حذف کردن یک دستور از لیست با اسم
            /// </summary>
            /// <param name="name"></param>
            /// <returns>صحیح برگردانده میشود اگر موفق باشد</returns>
            public bool DeleteCommand(string name)
            {
                bool suc = UserCommands.Remove(name);

                if (!suc)
                    suc = SystematicCommands.Remove(name);

                return suc;
            }
                //بروزرسانی
            /// <summary>
            /// بروز کردن دستور در لیست
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns> مقدار درست درصورت موفقیت</returns>
            public bool UpdateCommand(CommandData commanddata)
            {
                string name = commanddata.Name;

                if (UserCommands.ContainsKey(name))
                {
                    UserCommand userCommand = UserCommands[name];
                    userCommand.Name = commanddata.Name;
                    userCommand.CommandType = commanddata.CommandType;

                    return true;
                }
                else if (SystematicCommands.ContainsKey(name))
                {
                    StabelCommand stabelCommand = SystematicCommands[name];
                    stabelCommand.Name = commanddata.Name;
                    stabelCommand.CommandType = commanddata.CommandType;

                    return true;
                }
                else
                    return false;
            }
            /// <summary>
            /// بروز کردن دستور در لیست
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns> مقدار درست درصورت موفقیت</returns>
            public bool UpdateCommand(StabelCommand commanddata)
            {
                string name = commanddata.Name;

                if (SystematicCommands.ContainsKey(name))
                {
                    SystematicCommands[name] = commanddata;
                    return true;
                }
                else
                    return false;
            }
            /// <summary>
            /// بروز کردن دستور در لیست
            /// </summary>
            /// <param name="name"></param>
            /// <param name="value"></param>
            /// <returns> مقدار درست درصورت موفقیت</returns>
            public bool UpdateCommand(UserCommand commanddata)
            {
                string name = commanddata.Name;

                if (UserCommands.ContainsKey(name))
                {
                    UserCommands[name] = commanddata;
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
            public bool IsExist(string name)
            {
                return (UserCommands.ContainsKey(name) || SystematicCommands.ContainsKey(name));
            }
        }
    }
}

//نحوه اضافه کردن دستورات سیستمی یا اپلیکیشنی:
//به کلاس کنترلر کامند ها بروید
//یک شعی با نام دستورات سیستمی وجود دارد که به صورت کالکشن هست
//انجا به لیست اضافه کنید.
//
//توضیحات کلاس کامنددیتا:
//این کلاس اطلاعات یک دستور برنامه هستش که شامل اسم دستور 
//مقدار ان
//نوع دستور و یک دلیگیت برای عملیات خاص انجام میشه.
//دقت داشته باشید که اگر نوع سیسستمی باشه دلیگیت عملیات باید پر بشه.

