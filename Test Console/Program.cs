﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

using Test_Console;
using Test_Console.Application;
using Test_Console.SaveAndRetrieve;
using Test_Console.Strucures;
using JSonSingleObject;

namespace Test_Console.SaveAndRetrieve
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            GetSimilarsTest();
            Console.ReadKey();
        }
        
        static void GetSimilarsTest()
        {
            CommandExcuter.Commandmanager.AddCommand(new StabelCommand("Shutdown", Shutdown));
            CommandExcuter.AddCommand("MyName", "Ali Mohammadi");
            CommandExcuter.AddCommand("Brother", "Mohammad Mohammadi");
            CommandExcuter.AddCommand("broad", "My sisi");
            CommandExcuter.AddCommand("Bababoy", "My sisi");

            ShowList(CommandExcuter.GetSimilars("b"));
            Console.WriteLine();
            ShowList(CommandExcuter.GetSimilars("my"));
        }
        static void AddDeleteUpdateTest()
        {
            CommandExcuter.Commandmanager.AddCommand(new StabelCommand("Shutdown", Shutdown));
            CommandExcuter.AddCommand("MyName", "Ali Mohammadi");
            CommandExcuter.AddCommand("Brother", "Mohammad Mohammadi");
            CommandExcuter.AddCommand("broad", "My sisi");
            CommandExcuter.AddCommand("Bababoy", "My sisi");

            ShowList(CommandExcuter.Commandmanager.UserCommands.ToList<KeyValuePair<string,UserCommand>>());
            ShowList(CommandExcuter.Commandmanager.SystematicCommands.ToList<KeyValuePair<string,StabelCommand>>());
            Console.WriteLine();

            CommandExcuter.DeleteCommand("brother");
            CommandExcuter.DeleteCommand("broad");

            ShowList(CommandExcuter.Commandmanager.UserCommands.ToList<KeyValuePair<string, UserCommand>>());
            ShowList(CommandExcuter.Commandmanager.SystematicCommands.ToList<KeyValuePair<string, StabelCommand>>());
            Console.WriteLine();

            CommandExcuter.UpdateCommand("myname", "Ali Mohammadi Alkaran");

            ShowList(CommandExcuter.Commandmanager.UserCommands.ToList<KeyValuePair<string, UserCommand>>());
            ShowList(CommandExcuter.Commandmanager.SystematicCommands.ToList<KeyValuePair<string, StabelCommand>>());
        }

        static void ShowList(List<KeyValuePair<string, UserCommand>> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Value.Name + ": " + item.Value.Value + ": " + item.Value.CommandType.ToString());
            }
        }
        static void ShowList(List<KeyValuePair<string, StabelCommand>> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Value.Name + ": " + item.Value.Operation.ToString() + ": " + item.Value.CommandType.ToString());
            }
        }
        static void ShowList(List<CommandData> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }

        static void Shutdown()
        {
            Console.WriteLine("ShutdownPC");
        }
    }
}
