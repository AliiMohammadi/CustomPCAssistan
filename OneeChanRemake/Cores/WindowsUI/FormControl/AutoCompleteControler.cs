using System;
using System.Collections.Generic;
using OneeChanRemake.Forms;
using System.Windows.Forms;
using System.Drawing;

namespace OneeChanRemake.FormControl
{
    internal class AutoCompleteControler
    {
        
        public static AutoCompletePanelUserControl autoCompleteUserControl;

        public static void FillListBox()
        {
            ListBox.ObjectCollection collection = autoCompleteUserControl.AutoCompleteListBox.Items;
            string command = TerminalControl.TerminalLineText;

            collection.Clear();

            if(command == string.Empty)
            {
                autoCompleteUserControl.Hide();
                return;
            }

            SetControlPositionByTerminalTextLine();

            command = Application.LibraryCommand.Melt(command);
            List<Strucures.CommandData> result = AppActions.SearchCommand(command);

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

            if(recount == 1)
            {
                autoCompleteUserControl.AutoCompleteListBox.SelectedIndex = 0;
                return;
            }

            bool sort = false;

            if (recount < Application.LibraryCommand.Commandmanager.UserCommands.Count)
                sort = true;

            autoCompleteUserControl.AutoCompleteListBox.Sorted = sort;
        }
        public static void ExecuteSelectedItem()
        {
            ListBox autolistbox = autoCompleteUserControl.AutoCompleteListBox;

            if (!autolistbox.Visible)
                return;

            if (autolistbox.SelectedItems != null)
                ExecuteItem(autolistbox.SelectedIndex);
        }
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
        private static void SetControlPosition(Point location)
        {
            autoCompleteUserControl.Location = location;
        }
    }
}
