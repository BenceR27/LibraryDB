using LibraryGUI.Datas;
using LibraryGUI.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LibraryGUI.Views
{
    public partial class ShowDatas : Page
    {
        private readonly Read _read = new Read();

        public ShowDatas()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            dataGrid1.ItemsSource = _read.ReadBooks();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dataGrid1.SelectedItem == null)
                return;

            // Ha Books típus
            if (dataGrid1.SelectedItem is Books selectedBook)
            {
                var editWindow = new EditBooks(selectedBook.BookId)
                {
                    Owner = Application.Current.MainWindow
                };

                bool? result = editWindow.ShowDialog();

                if (result == true)
                {
                    LoadBooks(); 
                }
            }
            else
            {
                MessageBox.Show("Nincs ilyen típusú adat a táblában");
            }
        }
    }
}