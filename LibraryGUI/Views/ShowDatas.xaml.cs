using LibraryGUI.Datas;
using LibraryGUI.Models;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for ShowDatas.xaml
    /// </summary>
    public partial class ShowDatas : Page
    {

        public ShowDatas()
        {
            InitializeComponent();
        }

        private void dataGrid1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType.IsClass && e.PropertyType != typeof(string))
            {
                e.Cancel = true;
            }
        }
    }
}