using Adam_Zsombor_beadando.DataAccess;
using Adam_Zsombor_beadando.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Adam_Zsombor_beadando
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		// INotifyPropertyChanged is needed to notify WPF after updating a value that the UI should also update
		public event PropertyChangedEventHandler? PropertyChanged;

		private bool isForditas = false;

		private DbSzotar Database;

		private string _numberOfRounds = 3.ToString();

		private int _totalDictionaryCount = 0;
		private int _totalWordFormCount = 0;

		public string NumberOfRounds
		{
			get { return _numberOfRounds; }
			set
			{
				_numberOfRounds = value;
				// after we change anything, notify WPF about UI update needed
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NumberOfRounds)));
			}
		}

		public MainWindow()
		{
			this.Database = new DbSzotar();

			InitializeComponent();

			this._totalDictionaryCount = this.Database.Szotar.Count();
			Forditas.IsChecked = true;

			foreach(var entry in this.Database.Szotar)
			{
				this.TranslationTable.DataSource.Add(entry);
			}
			this.TranslationTable.DataSource.Add(new Szotar());
		}

		private void Forditas_Checked(object sender, RoutedEventArgs e)
		{
			isForditas = true;
			SzoFormak.IsChecked = false;
		}
		private void SzoFormak_Checked(object sender, RoutedEventArgs e)
		{
			isForditas = false;
			Forditas.IsChecked = false;
		}
		private void Start_Click(object sender, RoutedEventArgs e)
		{
			int numOfRounds;
			bool isCorrectInteger = int.TryParse(this.NumberOfRounds, out numOfRounds);

			int maxCount = this.isForditas
				? this._totalDictionaryCount
				: this._totalWordFormCount;

			if(!isCorrectInteger || numOfRounds < 1 || numOfRounds > maxCount)
			{
				MessageBox.Show($"A megadott körök száma nem megfelelő. Adj meg 0-nál nagyobb és legfeljebb {maxCount} egész számot!");
				return;
			}

			// we need showdialog to disable the main window while a game is taking place
			if (isForditas)
			{
				SzotarJatek szotarJatek = new SzotarJatek(numOfRounds);
				szotarJatek.ShowDialog();
			}
			else
			{
				RagozasJatek ragozasJatek = new RagozasJatek();
				ragozasJatek.ShowDialog();
			}
		}

		private void TranslationTable_WordUpdated(object sender, Szotar e)
		{
			if(e.Id == 0)
			{
				this.Database.Szotar.Add(e);
				this.TranslationTable.AddItem(e);
			}
			else
			{
				Szotar? original = this.Database.Szotar.Find(e.Id);
				if(original != null)
				{
					original.Hun = e.Hun;
					original.Eng = e.Eng;
				}
			}

			this.Database.SaveChanges();
			this._totalDictionaryCount = this.Database.Szotar.Count();
		}

		private void TranslationTable_WordDeleted(object sender, Szotar e)
		{
			this.Database.Szotar.Remove(e);
			this.Database.SaveChanges();
			this._totalDictionaryCount = this.Database.Szotar.Count();
		}
	}
}
