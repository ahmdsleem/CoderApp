using CoderApp.PropertyChanges;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderApp.Implement
{
    public class TextImplement : TextProCh
    {
        private int selectedItem;
        private string defaultName = "New Item";
        // Holding the tems
        public List<TabViewItem> items {  get; set; }
        // for path
        public List<string> FilePath { get; set; }

        public List<string> FileData { get; set; }

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

        public void AddNewTabItem()
        {
            TabViewItem TVitems = new TabViewItem();
        }
        private void NewFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
