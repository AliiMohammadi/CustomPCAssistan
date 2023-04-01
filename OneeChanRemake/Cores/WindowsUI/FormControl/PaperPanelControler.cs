using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneeChanRemake.FormControl
{
    /// <summary>
    /// کلاس کنترل کننده کامپوننت کنترل پنل پنجره های برنامه 
    /// به اصطلاح به ان پیپر پنل میگوییم
    /// کل کار های پنجره ها و مدیریت ان ها در این کلاس در زیر کلاس ها انجام میشه
    /// </summary>
    internal class PaperPanelControler
    {

        public static TabControl panelControl;
        public static sbyte SelectedPanelIndex
        {
            get { return (sbyte)panelControl.SelectedIndex; }
            set { panelControl.SelectedIndex = value; }
        }


        public class AddPanel
        {
            static OpenFileDialog browsAddressFileDialog = new OpenFileDialog();

            public static void ShowAddPanel()
            {
                SelectedPanelIndex = 1;
            }
            public static void AddNewCommand()
            {
                string address = MainForm.mainform.AdressTextBox.Text;
                string command = MainForm.mainform.NewNameCommand.Text;

                if(string.IsNullOrEmpty(command) && string.IsNullOrEmpty(address))
                {
                    Log.PrintError("Pleas fill the address and command name.");
                    return;
                }
                if (string.IsNullOrEmpty(address))
                {
                    Log.PrintError("Pleas fill the address.");
                    return;
                }
                if (string.IsNullOrEmpty(command))
                {
                    Log.PrintError("Pleas fill the command name.");
                    return;
                }


                try
                {
                    Application.LibraryCommand.AddCommand(command, address,Strucures.CommandTypes.Address);
                    Application.Informations.SaveData();

                    MainForm.mainform.AdressTextBox.Clear();
                    MainForm.mainform.NewNameCommand.Clear();
                }
                catch (InvalidOperationException ex)
                {
                    Log.PrintError("Can not add this command. Command name " + command + " is already exist. Choose another name.");
                }
                catch(Exception ex)
                {
                    Log.PrintError("Can not add this command. Details: " + ex.Message);
                }
            }
            public static void BrowsAddress()
            {
                DialogResult res = browsAddressFileDialog.ShowDialog();

                if(res == DialogResult.OK)
                    MainForm.mainform.AdressTextBox.Text = browsAddressFileDialog.FileName;
            }

        }
        public class CommandBookPanel
        {

            public static void ShowAddressSelectedItem()
            {
                TextBox addresstextbox = MainForm.mainform.PreviewAddressTextbox;
                ListBox listbox = MainForm.mainform.BookCommandListBox;

                if (listbox.SelectedItem == null)
                {
                    addresstextbox.Clear();
                    return;
                }

                string commandname = listbox.SelectedItem.ToString();
                addresstextbox.Text = Application.LibraryCommand.Commandmanager.UserCommands[commandname].Value;
            }
            public static void FillCommandBookListBox()
            {
                string searchfill = MainForm.mainform.SearchNameTextBox.Text;
                ListBox BookCommandListBox = MainForm.mainform.BookCommandListBox;

                BookCommandListBox.Items.Clear();

                if (string.IsNullOrWhiteSpace(searchfill))
                {
                    Dictionary<string, Strucures.UserCommand> collection = Application.LibraryCommand.Commandmanager.UserCommands;

                
                    foreach (var item in collection)
                    {
                        BookCommandListBox.Items.Add(item.Key);
                    }
                }
                else
                {
                    List<Strucures.UserCommand> collection = Application.LibraryCommand.FindUserCommandSimilars(searchfill);

                
                    foreach (Strucures.UserCommand item in collection)
                    {
                        BookCommandListBox.Items.Add(item.Name);
                    }
                }
            }
            public static void DeleteCommand()
            {
                ListBox box = MainForm.mainform.BookCommandListBox;

                if(box.SelectedItem == null)
                {
                    Log.PrintError("Please select a command from list.");
                    return;
                }

                string selected = box.SelectedItem.ToString();
                Application.LibraryCommand.DeleteCommand(selected);
                Application.Informations.SaveData();
                BookCommandPanelRefresh();
            }
            public static void DeleteAllCommandData()
            {
                AppActions.DeleteAllData();
                Application.Informations.LoadData();
                BookCommandPanelRefresh();
            }
            public static void ShowCommandCount()
            {
                MainForm.mainform.CountCommandLabel.Text = Application.LibraryCommand.Commandmanager.UserCommands.Count.ToString();
            }
            public static void BookCommandPanelRefresh()
            {
                FillCommandBookListBox();
                ShowAddressSelectedItem();
                ShowCommandCount();
            }
        }
    }
}
