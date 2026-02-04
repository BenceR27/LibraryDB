using LibraryGUI.Datas;
using Org.BouncyCastle.Asn1.X509;
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

namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for ShowDatas.xaml
    /// </summary>
    public partial class ShowDatas : Page
    {
        Read read = new Read();
        public ShowDatas()
        { 
            InitializeComponent();

        }

        private void szerzok_Click(object sender, RoutedEventArgs e)
        {
            var list = read.ReadAuthors();
            dataGrid1.ItemsSource = read.ReadAuthors();
        }

        private void konyvek_Click(object sender, RoutedEventArgs e)
        {
            var list = read.ReadBooks();
            dataGrid1.ItemsSource = read.ReadBooks();
        }

        private void kategoriak_Click(object sender, RoutedEventArgs e)
        {
            var list = read.ReadCategories();
            dataGrid1.ItemsSource = read.ReadCategories();
        }
    }
}
