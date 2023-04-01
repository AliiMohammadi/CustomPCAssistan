using System;
using System.Collections.Generic;
using OneeChanRemake.Forms;
using System.Windows.Forms;
using System.Drawing;

/// <summary>
/// فضای نامی که کلاس های کنترول کننده فرم و کامپوننت های برنامه داخل اون هستند
/// کلاس هایی وجود دارند که وظیفه کنترل فرم و کامپوننت ها و یوزر کنترول هارو بر عهده دارند.
/// </summary>
namespace OneeChanRemake.FormControl
{
    /// <summary>
    /// کلاس کنترل کننده پنجره پیشنهاد خود کار دستور در هنگام نوشتن دستور در ترمینال دستور
    /// </summary>
    internal class AutoCompleteControler
    {
        public static AutoCompletePanelUserControl autoCompleteUserControl;

        /// <summary>
        /// پر کردن لیست بر اساس متنی که داخل ترمینال نوشته شده به صورت خود کار
        /// اگه چیزی تایپ شده باشه پیشنهاد میده
        /// اگه فقط اسپیس باشه کل دستورات رو پیشنهاد میده
        /// </summary>
        public static void FillListBox()
        {
            ListBox.ObjectCollection collection = autoCompleteUserControl.AutoCompleteListBox.Items;
            string command = TerminalControl.TerminalLineText;

            collection.Clear();

            //اخه خالی باشه بسته میشه کلا
            if(command == string.Empty)
            {
                autoCompleteUserControl.Hide();
                return;
            }

            //مشخص کردن موقعیت پنجره با توجه به نوشته ما
            SetControlPositionByTerminalTextLine();

            command = Application.LibraryCommand.Melt(command);
            List<Strucures.CommandData> result = AppActions.SearchCommand(command);

            //اگه هیچ دستور پیشنهادی وجود نداشته باشه بسته بشه
            if(result.Count == 0)
            {
                autoCompleteUserControl.Hide();
                return;
            }

            autoCompleteUserControl.Show();

            foreach (var item in result)
            {
                collection.Add(item.Name);
            }

            int recount = result.Count;
            
            //اگه کلا یه دستور پیشنهادی وجو دارد اون رو متمرکز میکنیم تو لیست
            if(recount == 1)
            {
                autoCompleteUserControl.AutoCompleteListBox.SelectedIndex = 0;
                return;
            }

            bool sort = false;

            //اگه دستوری تایپ شده باشه یعنی بجز فاضله خالی, لیست پیشنهادی ها مرتب میشه از بهترین 
            if (recount < Application.LibraryCommand.Commandmanager.UserCommands.Count)
                sort = true;

            autoCompleteUserControl.AutoCompleteListBox.Sorted = sort;
        }
        /// <summary>
        /// اجرا کردن ایتمی که تو لیست انتخواب شده
        /// </summary>
        public static void ExecuteSelectedItem()
        {
            ListBox autolistbox = autoCompleteUserControl.AutoCompleteListBox;

            if (!autolistbox.Visible)
                return;

            if (autolistbox.SelectedItems != null)
                ExecuteItem(autolistbox.SelectedIndex);
        }
        /// <summary>
        /// اجرا کردن دستور با اندیس از داخل لیست با مقدار لحظه ای
        /// </summary>
        /// <param name="itemindex"></param>
        public static void ExecuteItem(int itemindex)
        {
            int listcount = autoCompleteUserControl.AutoCompleteListBox.Items.Count;

            if (listcount == 0)
                return;
            if(itemindex >= listcount)
                return;

            TerminalControl.TerminalLineText = autoCompleteUserControl.AutoCompleteListBox.Items[itemindex].ToString();
            TerminalControl.Execute();
        }

        /// <summary>
        /// مشخص کردن موقعیت پنجره با توجه به اندازه متن
        /// </summary>
        static void SetControlPositionByTerminalTextLine()
        {
            Point InititialLocation = autoCompleteUserControl.Initiallocation;
            int TERMINALTEXTSIZEFONT = (int)(TerminalControl.TerminalLine.Font.Size * 0.77f);

            if (string.IsNullOrEmpty(TerminalControl.TerminalLineText))
                TERMINALTEXTSIZEFONT /= 4;

            int lengh = TerminalControl.Length;
            Point NewLocation = new Point(InititialLocation.X + (lengh * TERMINALTEXTSIZEFONT), InititialLocation.Y);
            SetControlPosition(NewLocation);
        }
        /// <summary>
        /// تنظیم موقعیت پنجره
        /// </summary>
        /// <param name="location"></param>
        static void SetControlPosition(Point location)
        {
            autoCompleteUserControl.Location = location;
        }
    }
}
