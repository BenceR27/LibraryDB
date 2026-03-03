using System;
using System.Linq;
using System.Windows;
using LibraryGUI.Datas;
using LibraryGUI.Models;

namespace LibraryGUI.Views
{
    public partial class EditBooks : Window
    {
        private readonly int _bookId;
        private readonly Read _read = new Read();
        private readonly UpdateDelete _updateDelete = new UpdateDelete();

        public EditBooks(int bookId)
        {
            InitializeComponent();
            _bookId = bookId;
            Loaded += EditBooks_Loaded;
        }

        private void EditBooks_Loaded(object sender, RoutedEventArgs e)
        {
            cbAuthors.ItemsSource = _read.ReadAuthors();
            cbCategories.ItemsSource = _read.ReadCategories();

            using (var context = new librarydbContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookId == _bookId);

                if (book == null)
                {
                    MessageBox.Show("A könyv nem található.");
                    DialogResult = false;
                    Close();
                    return;
                }

                tbTitle.Text = book.Title;
                dpPublishDate.SelectedDate = book.PublishDate;

                cbAuthors.SelectedValue = book.AuthorId;
                cbCategories.SelectedValue = book.CategoryId;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbAuthors.SelectedValue == null ||
                cbCategories.SelectedValue == null ||
                dpPublishDate.SelectedDate == null)
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            int newAuthorId = (int)cbAuthors.SelectedValue;
            int newCategoryId = (int)cbCategories.SelectedValue;
            DateTime newPublishDate = dpPublishDate.SelectedDate.Value;

            var result = _updateDelete.UpdateBookAuthorCategory(
                _bookId,
                newAuthorId,
                newCategoryId,
                newPublishDate);

            MessageBox.Show(result.Message);

            DialogResult = true;
            Close();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var confirm = MessageBox.Show(
                "Biztos törölni akarod ezt a könyvet?",
                "Törlés megerősítése",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (confirm != MessageBoxResult.Yes)
                return;

            var result = _updateDelete.DeleteBook(_bookId);

            MessageBox.Show(result.Message);

            DialogResult = true;
            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}