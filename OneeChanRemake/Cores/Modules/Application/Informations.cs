using System;
using System.Collections.Generic;

namespace OneeChanRemake.Application
{
    /// <summary>
    /// کلاس در باره ذخیره اطلاعات و بازیابی
    /// </summary>
    internal class Informations
    {
        public static string DataFileAdress = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OneeChanApplicationData.Oneedat";
        public static string AppConfigFileAdress = @"";

        public static void SaveData()
        {
            var DataObject = LibraryCommand.Commandmanager.UserCommands;

            SaveAndRetrieve.JsonSaveData.SaveData(DataObject, DataFileAdress);
        }
        public static void LoadData()
        {
            try
            {
                if(System.IO.File.Exists(DataFileAdress))
                    LibraryCommand.Commandmanager.UserCommands = SaveAndRetrieve.JsonSaveData.LoadData<Dictionary<string,Strucures.UserCommand>>(DataFileAdress);
                else
                    LibraryCommand.Commandmanager.UserCommands.Clear();
            }
            catch (Exception ex)
            {
                LibraryCommand.Commandmanager.UserCommands.Clear();
                throw new Exception("Failed to connect to data file: " + ex.Message);
            }
        }
        public static void DeleteAllData()
        {
            Operation_System.OSactions.DeletePath(DataFileAdress);
            LoadData();
        }
    }
}

