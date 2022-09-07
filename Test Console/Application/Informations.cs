using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Console
{
    namespace Application
    {
        internal class Informations
        {
            public static string DataFileAdress = @"D:\DataFileAdress";
            public static string AppConfigFileAdress = @"";

            public static void SaveData()
            {
                //var DataObject = Strucures.CommandManager.CommandCollections.UserCommands;

                //SaveAndRetrieve.JsonSaveData.SaveData(DataObject,DataFileAdress);
            }
            public static void LoadData()
            {
                //Strucures.CommandManager.CommandCollections.UserCommands = SaveAndRetrieve.JsonSaveData.LoadData<Dictionary<string,Strucures.CommandData>>(DataFileAdress);
            }
        }
    }
}
