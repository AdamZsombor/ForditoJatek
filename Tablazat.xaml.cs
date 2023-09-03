using Adam_Zsombor_beadando.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Adam_Zsombor_beadando
{
    /// <summary>
    /// Interaction logic for tablazat.xaml
    /// </summary>
    public partial class Tablazat : UserControl
    {
        public event EventHandler<Szotar> WordUpdated;
        public event EventHandler<Szotar> WordDeleted;

        public ObservableCollection<Szotar> DataSource { get; set; } = new ObservableCollection<Szotar>();



        public Tablazat()
        {
            InitializeComponent();
        }

		private void UpdateDictionaryRecord_Click(object sender, RoutedEventArgs e)
		{
			var updateWindow = new Adam_Zsombor_beadando.Views.Dialogs.DictianaryAdd();
			// to prevent two-way databinding from updating our Dictionary directly in the data source,
			// we need to give this window a copy that it can freely change without affecting the original in the collection
			Szotar toUpdate = (((Button)sender).DataContext as Szotar)!;
			updateWindow.Szotar = new Szotar() { Id = toUpdate.Id, Eng = toUpdate.Eng, Hun = toUpdate.Hun };
            updateWindow.DictionaryRecordChanged += this.DictionaryRecordUpdated;

            updateWindow.ShowDialog();
		}

        private void DictionaryRecordUpdated(object? sender, Szotar dict)
        {
            Szotar? updatedItem = this.DataSource.FirstOrDefault(e => e.Id == dict.Id);

            if(updatedItem != null && updatedItem.Id != 0) // item was already in the datagrid
            {
                updatedItem.Hun = dict.Hun;
                updatedItem.Eng = dict.Eng;
            }

            this.WordUpdated?.Invoke(this, dict);
        }

        // To ensure that we add it before the dummy item
        public void AddItem(Szotar item)
        {
            this.DataSource.Insert(this.DataSource.Count - 1, item);
        }

		private void DeleteDictionaryRecord_Click(object sender, RoutedEventArgs e)
		{
            if(MessageBox.Show("Biztosan szeretnéd törölni a sort?", "Törlés megerősítése", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Szotar? toDelete = (((Button)sender).DataContext as Szotar);
                if(toDelete != null)
                {
                    this.DataSource.Remove(toDelete);
                    this.WordDeleted?.Invoke(this, toDelete);
                }
            }
		}
	}
}
