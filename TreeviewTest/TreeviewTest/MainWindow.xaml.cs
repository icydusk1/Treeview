using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeviewTest {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel viewModel = new MainWindowViewModel();

            MyTreeItem item1 = new MyTreeItem("North America");
            MyTreeItem item11 = new MyTreeItem("USA");
            MyTreeItem item111 = new MyTreeItem("ABC");
            MyTreeItem item12 = new MyTreeItem("Canada");
            MyTreeItem item13 = new MyTreeItem("Mexico");

            item11.Children.Add(item111);

            item1.Children.Add(item11);
            item1.Children.Add(item12);
            item1.Children.Add(item13);

            viewModel.MyTreeItems.Add(item1);

            MyTreeItem item2 = new MyTreeItem("Sorth America");
            MyTreeItem item21 = new MyTreeItem("Argentina");
            MyTreeItem item22 = new MyTreeItem("Brazil");
            MyTreeItem item23 = new MyTreeItem("Uruguay");
            
            item2.Children.Add(item21);
            item2.Children.Add(item22);
            item2.Children.Add(item23);

            viewModel.MyTreeItems.Add(item2);

            DataContext = viewModel;
        }
    }
}
