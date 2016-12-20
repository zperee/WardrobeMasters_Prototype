using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WardrobeMasters_Prototype
{
	public class LoginViewModel : INotifyPropertyChanged
	{
		private string _username;
		private string _password;
		public bool _isBusy;
		public event PropertyChangedEventHandler PropertyChanged;

		public Command LoginCommand { get; }
		public Command RegisterCommand { get; }

		public LoginViewModel()
		{
			LoginCommand = new Command(async () => await Login(), CanLogin);
			RegisterCommand = new Command(Register, () => !IsBusy);
		}

		public bool CanLogin()
		{
			return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !IsBusy;
		}

		public string Username
		{
			get { return _username; }
			set
			{
				if (Equals(_username, value)) return;
				_username = value;
				OnPropertyChanged();
				LoginCommand.ChangeCanExecute();
			}
		}

		public string Password
		{
			get { return _password; }
			set
			{
				if (Equals(_password, value)) return;
				_password = value;
				OnPropertyChanged();
				LoginCommand.ChangeCanExecute();
			}
		}

		public bool IsBusy
		{
			get { return _isBusy; }
			set
			{
				_isBusy = value;

				OnPropertyChanged();
				RegisterCommand.ChangeCanExecute();
			}
		}

		void OnPropertyChanged([CallerMemberName] string name = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public async Task Login()
		{
			IsBusy = true;
			await Task.Delay(4000);

			if (Username.Equals("Test") && Password.Equals("1234"))
			{
				new NotImplementedException();
			}
			else
			{
				await Application.Current.MainPage.DisplayAlert("Error", "Username or Password are wrong", "OK");
			}

			IsBusy = false;
		}

		public void Register()
		{
			Application.Current.MainPage = new RegistrationPage();
		}

	}
}
