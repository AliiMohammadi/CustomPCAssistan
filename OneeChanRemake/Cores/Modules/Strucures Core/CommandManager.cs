using System;
using System.Collections.Generic;


namespace OneeChanRemake.Strucures
{
    /// <summary>
    /// کلاس نگه دارنده لیست دستورات سیستمی و کاربری و عملیات برای انان
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
        /// باز یابی  اطلاعات دستوری با توجه به اسم ان از لیست
        /// اسم ذوب میشود و هر حالتی باشد از داخل لیست مشابه پیدا میشود.
        /// اسم کامل مورد قبول است اما به هر فرمی
        ///مثال:
        /// => CommandlistsName: (Amir , amir ali , Amin , Ali , Mahdi)
        /// => GetSimilars("amir") = (Amir و اطلاعات ان)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public CommandData GetCommand(string name)
            {
                try
                {
                    foreach (StabelCommand key in SystematicCommands.Values)
                    {
                        if (string.Equals(Melt(key.Name), Melt(name)))
                            return key;
                    }
                    foreach (UserCommand key in UserCommands.Values)
                    {
                        if (string.Equals(Melt(key.Name), Melt(name)))
                            return key;
                    }
                }
                catch { }

                return null;
            }
        /// <summary>
        /// باز یابی دستوری با توجه به اسم ان از لیست
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserCommand GetUserCommand(string name)
        {
            foreach (UserCommand key in UserCommands.Values)
            {
                if (string.Equals(Melt(key.Name), Melt(name)))
                    return key;
            }

            return null;
        }
        /// <summary>
        /// باز یابی دستوری با توجه به اسم ان از لیست
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public StabelCommand GetStabelCommand(string name)
        {
            foreach (StabelCommand key in SystematicCommands.Values)
            {
                if (string.Equals(Melt(key.Name), Melt(name)))
                    return key;
            }

            return null;
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
                throw new InvalidOperationException($"The key '{name}' is already exist.");
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
        public void DeleteCommand(string name)
        {
            UserCommand userCommand = GetUserCommand(name);
            bool suc = UserCommands.Remove(userCommand.Name);
            if (!suc)
                throw new Exception("Key not found.");
        }

            //بروزرسانی
        /// <summary>
        /// بروز کردن دستور در لیست
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void UpdateCommand(CommandData commanddata)
        {
            string name = commanddata.Name;

            if (UserCommands.ContainsKey(name))
            {
                UserCommands[name].Name = commanddata.Name;
            }
            else if (SystematicCommands.ContainsKey(name))
            {
                SystematicCommands[name].Name = commanddata.Name;
            }
            else
                throw new Exception("Key not found.");
        }
        /// <summary>
        /// بروز کردن دستور در لیست
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void UpdateCommand(StabelCommand newcommanddata)
        {
            string name = newcommanddata.Name;

            if (SystematicCommands.ContainsKey(name))
            {
                SystematicCommands[name].Operation = newcommanddata.Operation;
            }
            else
                throw new Exception("Key not found.");
        }
        /// <summary>
        /// بروز کردن دستور در لیست
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void UpdateCommand(UserCommand newcommanddata)
        {
            string name = newcommanddata.Name;

            if (UserCommands.ContainsKey(name))
            {
                UserCommands[name].Value = newcommanddata.Value;
            }
            else
                throw new Exception("Key not found.");
        }


        /// <summary>
        /// برسی میکند که ایا اسم داخل لیست مجود دارد یا خیر
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsExist(string name)
        {
            foreach (string key in SystematicCommands.Keys)
            {
                if (string.Equals(Melt(key), Melt(name)))
                    return true;
            }
            foreach (string key in UserCommands.Keys)
            {
                if (string.Equals(Melt(key), Melt(name)))
                    return true;
            }

            return false;
        }
        /// <summary>
        /// استاندارد کرده یک کلمه 
        /// کلمه انگلیسی رو به عبارت کوچک تبدیل میکند و فاصله ان را میگید
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string Melt(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            string melted = value;

            try
            {
                melted = melted.ToLower();
            }
            catch { }
            try
            {
                melted = melted.Replace(" ", "");
            }
            catch { }

            return melted;
        }
    }
}


