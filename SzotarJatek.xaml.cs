using Adam_Zsombor_beadando.DataAccess;
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

namespace Adam_Zsombor_beadando
{
	/// <summary>
	/// Interaction logic for SzotarJatek.xaml
	/// </summary>
	public partial class SzotarJatek : Window, INotifyPropertyChanged
	{
		private DbSzotar Database;

		private Random _rn = new Random();

		private string _hungarianWord = string.Empty;
		private string _englishWord = string.Empty;

		private string _correctSolution = string.Empty;

		private Visibility _errorMessageVisibility = Visibility.Hidden;

		List<int> szotarIdList;

		private int _totalQuestionNumber;
		private int _currentQuestionNumber = 1;

		public string HungarianWord
		{
			get
			{
				return _hungarianWord;
			}
			set
			{
				_hungarianWord = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HungarianWord)));
			}
		}

		public string EnglishWord
		{
			get
			{
				return _englishWord;
			}
			set
			{
				_englishWord = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnglishWord)));
			}
		}

		public Visibility ErrorMessageVisibility
		{
			get
			{
				return _errorMessageVisibility;
			}
			set
			{
				_errorMessageVisibility = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ErrorMessageVisibility)));
			}
		}

		bool translateFromEnglish;

		public event PropertyChangedEventHandler? PropertyChanged;

		public SzotarJatek(int numberOfQuestions)
		{
			this.Database = new DbSzotar();

			InitializeComponent();

			szotarIdList = this.Database.Szotar.Select(e => e.Id).ToList();
			this._totalQuestionNumber = numberOfQuestions;

			GameReset();
		}

		private void Ellenorzes(object sender, RoutedEventArgs e)
		{
			bool isCorrect = this.translateFromEnglish
				? this.HungarianWord == this._correctSolution
				: this.EnglishWord == this._correctSolution;

			if(isCorrect)
			{
				this.ErrorMessageVisibility = Visibility.Hidden;
				this.GameReset();
				_currentQuestionNumber++;
				if(this._currentQuestionNumber > this._totalQuestionNumber)
				{
					this.Close();
				}
			}
			else
			{
				this.ErrorMessageVisibility = Visibility.Visible;
			}
		}
		private void GameReset()
		{
			this.HungarianWord = string.Empty;
			this.EnglishWord = string.Empty;

			translateFromEnglish = _rn.NextDouble() >= 0.5;

			int randIndex = _rn.Next(szotarIdList.Count);

			int chosenSzotarId = szotarIdList[randIndex];
			Szotar chosen = this.Database.Szotar.Find(chosenSzotarId)!;
			szotarIdList.RemoveAt(randIndex);

			if (translateFromEnglish)
			{
				this.EnglishWord = chosen.Eng;
				this._correctSolution = chosen.Hun;
				HunTextBox.IsReadOnly = false;
				EngTextBox.IsReadOnly = true;

			}
			else
			{
				this.HungarianWord = chosen.Hun;
				this._correctSolution = chosen.Eng;
				HunTextBox.IsReadOnly = true;
				EngTextBox.IsReadOnly = false;
			}
		}
	}
}
