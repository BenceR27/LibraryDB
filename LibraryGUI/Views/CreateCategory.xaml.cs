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
    /// Interaction logic for CreateCategory.xaml
    /// </summary>
    public partial class CreateCategory : Page
    {
        Create create = new Create();
        public CreateCategory()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var categoryResult = create.CreateCategory(categoryText.Text) as LibraryResults;
            MessageBox.Show(categoryResult.Message);
        }
    }
}
