using Adam_Zsombor_beadando.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Adam_Zsombor_beadando.Views.Dialogs
{
	/// <summary>
	/// Interaction logic for DictianaryAdd.xaml
	/// </summary>
	public partial class DictianaryAdd : Window , INotifyPropertyChanged
	{
		public event EventHandler<Szotar> DictionaryRecordChanged;

		private Szotar _szotar;
		
		public Szotar Szotar
		{
			get { return _szotar; }
			set
			{
				_szotar = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Szotar)));
				this.Szotar.PropertyChanged += NotifyAboutDictionaryContentChanged;
			}
		}

		public DictianaryAdd()
		{
			this.Szotar = new Szotar();
			InitializeComponent();
		}

		private void NotifyAboutDictionaryContentChanged(object? sender, PropertyChangedEventArgs e)
		{
			this.PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs(nameof(Szotar)));
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		private void SaveButton_Click(object sender, RoutedEventArgs e)
		{
			if(string.IsNullOrEmpty(this.Szotar.Eng) || string.IsNullOrEmpty(this.Szotar.Hun))
			{
				MessageBox.Show("Mindkét mezőt ki kell tölteni értékkel!", "Hibás érték", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}

			this.Close();
			this.DictionaryRecordChanged?.Invoke(this, this.Szotar);
		}

		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
