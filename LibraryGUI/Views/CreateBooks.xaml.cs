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
using LibraryGUI.Models;

namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for CreateBooks.xaml
    /// </summary>
    public partial class CreateBooks : Page
    {
        Create create = new Create();
        public CreateBooks()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var bookResult = create.CreateBooks(konyvCim.Text, DateTime.Parse(konyvLetrejotte.Text), int.Parse(szerzoId.Text), int.Parse(kategoriaId.Text)) as LibraryResults;
            MessageBox.Show(bookResult.Message);
        }
    }
}
