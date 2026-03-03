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
using LibraryGUI.Datas;
using LibraryGUI.Views;

namespace LibraryGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Read read = new Read();
        Create create = new Create();
        ShowDatas showDatas = new ShowDatas();

        public MainWindow()
        {
            InitializeComponent();
            MainPage.Navigate(showDatas);
            var list = read.ReadBooks();
            showDatas.dataGrid1.ItemsSource = list;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(showDatas);
            var list = read.ReadAuthors();
            showDatas.dataGrid1.ItemsSource = list;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(showDatas);
            var list = read.ReadCategories();
            showDatas.dataGrid1.ItemsSource = list;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(showDatas);
            var list = read.ReadBooks();
            showDatas.dataGrid1.ItemsSource = list;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new CreateAuthors());

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new CreateCategory());
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new CreateBooks());
        }
    }
}
