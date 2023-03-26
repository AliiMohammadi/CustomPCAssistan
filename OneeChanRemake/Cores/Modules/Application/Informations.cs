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
            var DataObject = CommandExcuter.Commandmanager.UserCommands;

            SaveAndRetrieve.JsonSaveData.SaveData(DataObject, DataFileAdress);
        }
        public static void LoadData()
        {
            try
            {
                CommandExcuter.Commandmanager.UserCommands = SaveAndRetrieve.JsonSaveData.LoadData<Dictionary<string,Strucures.UserCommand>>(DataFileAdress);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to connect to data file: " + ex.Message);
            }
        }
    }
}

