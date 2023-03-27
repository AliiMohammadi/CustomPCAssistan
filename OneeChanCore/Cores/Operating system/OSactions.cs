using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// کلاس برای حرکت ها از سوی سیستم 
/// </summary>
namespace OneeChanRemake.Operating_system
{
    public static class OSactions
    {
        [DllImport("user32")]
        public static extern void LockWorkStation();
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        public static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

        public static bool IsDVDromOpen;

        /// <summary>
        /// یک ادرس دایرکتوری یا فایل یا یک وبسایت رو اجرا میکنه
        /// </summary>
        /// <param name="path">ادرس یا لینک دایرکتوری یا فایل</param>
        public static void OpenPath(string path)
        {
            try
            {
                if (System.IO.Path.GetExtension(path) == ".exe")
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.FileName = path;
                    processStartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(path);
                    Process.Start(processStartInfo);
                }
                else
                    Process.Start(path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// خاموش کردن سیستم
        /// </summary>
        public static void ShutDown()
        {
            StartProcess(new ProcessStartInfo("shutdown", "/s /t 0"));
        }
        /// <summary>
        /// ریستارت کردن سیستم
        /// </summary>
        public static void Restart()
        {
            StartProcess(new ProcessStartInfo("shutdown", "/r /t 0"));
        }
        /// <summary>
        /// لاک کردن یوزر
        /// </summary>
        public static void LockWindows()
        {
            LockWorkStation();
        }
        /// <summary>
        /// حالت خواب سیستم
        /// </summary>
        public static void Sleep()
        {
            SetSuspendState(false, true, true);
        }
        public static void OpenOrCloseDVDRom()
        {
            IsDVDromOpen = ProcessCDTray(!IsDVDromOpen);
        }

        public static void ChangeInputLanguageToEnglish()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName.ToLower() == "us")
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }

        /// <summary>
        /// یک فایل تکست روی دکستاپ درست  میکنه
        /// </summary>
        public static void CreatTextFile()
        {
            string Location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string Name = @"\new Text file";
            string Format = ".txt";

            string path = Location + Name + Format;

            if (File.Exists(path))
            {
                for (int i = 1; i < byte.MaxValue; i++)
                {
                    if (!File.Exists(Location + Name + i + Format))
                    {
                        Name = Name + i;
                        path = Location + Name + Format;
                        break;
                    }
                }
            }

            File.Create(path);
        }
        /// <summary>
        /// یک فایل پی ان جی روی دکستاپ درست  میکنه
        /// </summary>
        public static void CreatPngFile()
        {
            string Location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string Name = @"\new Png file";
            string Format = ".png";

            string path = Location + Name + Format;

            if (File.Exists(path))
            {
                for (int i = 1; i < byte.MaxValue; i++)
                {
                    if (!File.Exists(Location + Name + i + Format))
                    {
                        Name = Name + i;
                        path = Location + Name + Format;
                        break;
                    }
                }
            }

            Bitmap b = new Bitmap(512, 512);
            b.Save(path, ImageFormat.Png);
        }
        public static void DeletePath(string Path)
        {
            try
            {
                File.Delete(Path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DiableNetWork()
        {
            Process.Start("ipconfig", "/release");
        }
        public static void EnableNetWork()
        {
            Process.Start("ipconfig", "/renew");
        }

        static void StartProcess(ProcessStartInfo PSI)
        {
            PSI.CreateNoWindow = true;
            PSI.UseShellExecute = false;
            Process.Start(PSI);
        }
        static bool ProcessCDTray(bool open)
        {
            int ret = 0;

            switch (open)
            {
                case true:
                    ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
                    return true;
                //break;
                case false:
                    ret = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
                    return false;
                //break;
                default:
                    ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
                    return true;
                    //break;
            }
        }
    }   
}
