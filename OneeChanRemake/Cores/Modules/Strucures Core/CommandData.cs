using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strucures
    {
        /// <summary>
        /// انواع نوع دستورات
        /// </summary>
        public enum CommandTypes
            {
                Systematic, Applicational, Address, Note
            }
        /// <summary>
        /// کلاس اطلاعات پایه یک دستور
        /// </summary> 
        public class CommandData
        {
            public CommandTypes CommandType { get; set; }
            public string Name { get; set; }
        }
        /// <summary>
        /// کلاس اطلاعات یک دستور نوع سیستمی
        /// دستورات نوع سیستمی شامل دستورات خود سیستم عامل و خود اپلیکیشن میشوند
        /// </summary>
        public class StabelCommand : CommandData
        {
            /// <summary>
            ///  تابع هایی که عملیات این دستور درون ان ریخته شده
            /// </summary>
            public Action Operation;

            public StabelCommand() { }
            public StabelCommand(string name, Action operation)
            {
                Name = name;
                Operation = operation;
            }
            public StabelCommand(string name, Action operation, CommandTypes commandtype)
            {
                Name = name;
                Operation = operation;
                CommandType = commandtype;
            }
        }
        /// <summary>
        /// کلاس اطلاعات یک دستور نوع کاربری.
        /// دستورات کاربری دستوراتی هستند که توسط کاربر اضافه یا حذف میشوند.
        /// معمولا یک مقدار رشته ای ورودی میگیرند
        /// </summary>
        public class UserCommand: CommandData
        {
            public string Value { get; set; }

            public UserCommand() { }
            public UserCommand(string name,string value)
            {
                Name=name;
                Value=value;
                CommandType=CommandTypes.Address;
            }
            public UserCommand(string name, string value,CommandTypes commandtype)
            {
                Name = name;
                Value = value;
                CommandType = commandtype;
            }
        }
    }

