using System;
using System.IO;
using System.Web.Script.Serialization;

namespace Test_Console
{
    namespace SaveAndRetrieve
    {
        /// <summary>
        /// ذخیره و یا بازیابی اطلاعات با استفاده از تکنولوژی جیسون
        /// </summary>
        public class JsonSaveData
        {
            static JavaScriptSerializer Jss = new JavaScriptSerializer();

            public static void SaveData(object value,string path)
            {
                File.WriteAllText(path, Jss.Serialize(value));
            }
            public static void AppendData(object value, string path)
            {
                File.AppendAllText(path, Jss.Serialize(value));
            }
            public static T LoadData<T>(string path)
            {
                if (File.Exists(path))
                    return Jss.Deserialize<T>(File.ReadAllText(path));
                else
                    throw new Exception("File not found.");
            }
            public static string ReadFile(string path)
            {
                return File.ReadAllText(path);
            }
        }
    }
}
