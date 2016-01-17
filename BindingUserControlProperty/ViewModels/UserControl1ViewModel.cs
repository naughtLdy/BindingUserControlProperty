using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BindingUserControlProperty.Models;

namespace BindingUserControlProperty.ViewModels
{
	class UserControl1ViewModel : INotifyPropertyChanged
	{
		#region プロパティ変更通知

		// INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
		{
			if (object.Equals(storage, value)) return false;

			storage = value;
			this.OnPropertyChanged(propertyName);
			return true;
		}

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var eventHandler = this.PropertyChanged;
			if (eventHandler != null)
			{
				eventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region InputParameter 変更通知プロパティ

		private InputParameter _inputParameter;

		public InputParameter InputParameter
		{
			get { return _inputParameter; }
			set
			{
				SetProperty(ref _inputParameter, value);
			}
		}

		#endregion


		public UserControl1ViewModel ()
		{
			
		}
	}
}
