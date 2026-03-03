using LibraryGUI.Datas;
using LibraryGUI.Models;
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
    /// Interaction logic for CreateAuthors.xaml
    /// </summary>
    public partial class CreateAuthors : Page
    {
        Create create = new Create();
        public CreateAuthors()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var authorResult = create.CreateAuthor(authorText.Text) as LibraryResults;
            MessageBox.Show(authorResult.Message);
        }
    }
}