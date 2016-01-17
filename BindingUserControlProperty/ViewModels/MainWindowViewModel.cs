using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingUserControlProperty.ViewModels
{
	class MainWindowViewModel : INotifyPropertyChanged
	{
		#region プロパティ変更通知

		// INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
		{
			if (object.Equals(storage, value)) return false;

			storage = value;
			OnPropertyChanged(propertyName);
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

		#region Title 変更通知プロパティ

		private string _title;

		public string Title
		{
			get { return _title; }
			set
			{
				SetProperty(ref _title, value);
			}
		}

		#endregion

		#region UserControl1ViewModel 変更通知プロパティ

		private UserControl1ViewModel _userControl1ViewModel;

		public UserControl1ViewModel UserControl1ViewModel
		{
			get { return _userControl1ViewModel; }
			set
			{
				SetProperty(ref _userControl1ViewModel, value);
			}
		}

		#endregion

		#region UserControl2ViewModel 変更通知プロパティ

		private UserControl2ViewModel _userControl2ViewModel;

		public UserControl2ViewModel UserControl2ViewModel
		{
			get { return _userControl2ViewModel; }
			set
			{
				SetProperty(ref _userControl2ViewModel, value);
			}
		}

		#endregion

		public MainWindowViewModel()
		{
			Title = "MainWindow";
		}
	}
}
