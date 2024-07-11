using CoderApp.PropertyChanges;
using CoderApp.Views;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.youtube.com/watch?v=G6XYDc8tPw0
// 3:00

namespace CoderApp.Implement
{
    public class TextImplement : TextPropChng
    {
        private int selectedItem;
        private string defaultName = "New Item";
        // Holding the tab items
        public List<TabViewItem> items { get; set; }
        // holding the path
        public List<string> FilePath { get; set; }  // Hold file path to autoSave.
        // holding data from opened file
        public List<string> FileData { get; set; }  // Hold text from poened files

        public int SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        public TextImplement()
        {
            items = new List<TabViewItem>();
            FilePath = new List<string>();
            FileData = new List<string>();
        }
        // add a new tab with default sitting
        public void AddNewTabItem(string text, string header)
        {
            TabViewItem TVitems = new TabViewItem();
            TextBox textBox = new TextBox();
            // Add a custom context menu to the textbox for custom feature
            MenuFlyout menuFlyout = new MenuFlyout();

            MenuFlyoutItem menuFlyoutTXBX = new MenuFlyoutItem();
            menuFlyoutTXBX.Tag = "0";
            menuFlyoutTXBX.Text = "Sellect All Text";
            menuFlyoutTXBX.Click += TxBxMenu_Click;

            MenuFlyoutItem menuFlyoutTxBx1 = new MenuFlyoutItem();
            menuFlyoutTxBx1.Tag = "1";
            menuFlyoutTxBx1.Text = "Save file";
            menuFlyoutTxBx1.Click += TxBxMenu_Click;

            menuFlyout.Items.Add(menuFlyoutTXBX);
            menuFlyout.Items.Add(menuFlyoutTxBx1);
            // Add the context menu to the textbox
            textBox.ContextFlyout = menuFlyout;
            textBox.Text = text;
            // To allows to press enter on the textbox.
            textBox.AcceptsReturn = true;

            TVitems.Header = header;
            TVitems.Content = textBox;

            

            hiwn.RefreshList();
        }
        public CodeEditorBlock hiwn => (Application.Current as App)?.Window as CodeEditorBlock;
        private void TxBxMenu_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuFlyoutItem)sender;
            int id = int.Parse(menuItem.Tag.ToString());

            switch (id)
            {
                case 0: // select all text
                    break;
                case 1: // save file
                    break;
            }

        }
    }
}
