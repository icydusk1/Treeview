using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeviewTest
{
    class MyTreeItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MyTreeItem(string name)
        {
            Name = name;
        }
        
        public ObservableCollection<MyTreeItem> Children { get; } = new ObservableCollection<MyTreeItem>();
        
        private bool? isChecked = false;
        public bool? IsChecked
        {
            get
            {
                return isChecked;
            }
            set
            {
                isChecked = value;
                SetRecursiveCheck(value);
            }
        }

        public string Name { get; set; }

        private void SetRecursiveCheck(bool? isChecked)
        {
            foreach (var item in Children)
            {
                item.isChecked = isChecked;
                PropertyChanged?.Invoke(item, new PropertyChangedEventArgs("IsChecked"));
                item.SetRecursiveCheck(isChecked);
            }
        }
    }
}