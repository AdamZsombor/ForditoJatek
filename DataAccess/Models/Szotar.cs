using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Zsombor_beadando.DataAccess.Models
{
	public class Szotar : INotifyPropertyChanged, ICloneable
	{
		private int _id;
		private string _hun, _eng;

		public int Id
		{
			get { return this._id; }
			set
			{
				this._id = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
			}
		}

		public string Hun
		{
			get { return this._hun; }
			set
			{
				this._hun = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Hun)));
			}
		}

		public string Eng
		{
			get { return this._eng; }
			set
			{
				this._eng = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Eng)));
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		public object Clone()
		{
			return new Szotar()
			{
				Id = this.Id,
				Eng = this.Eng,
				Hun = this.Hun
			};
		}
	}
}
