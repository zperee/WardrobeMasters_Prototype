using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WardrobeMasters_Prototype
{
	public class RegistrationViewModel : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;
		private string _email = "";
		private string _password1 = "";
		private string _password2 = "";
		private string _username = "";
		private bool _isBusy = false;

		public RegistrationViewModel()
		{
			RegisterCommand = new Command(Register, CanRegister);
		}

		public Command RegisterCommand { get; }

		void OnPropertyChanged([CallerMemberName] string name = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public string Username
		{
			get { return _username; }
			set
			{
				if (Equals(_username, value)) return;
				_username = value;
				OnPropertyChanged();
				RegisterCommand.ChangeCanExecute();
			}
		}

		public string Email
		{
			get { return _email; }
			set
			{
				if (Equals(_email, value)) return;
				_email = value;
				OnPropertyChanged();
				RegisterCommand.ChangeCanExecute();
			}
		}

		public string Password1
		{
			get { return _password1; }
			set
			{
				if (Equals(_password1, value)) return;
				_password1 = value;
				OnPropertyChanged();
				RegisterCommand.ChangeCanExecute();
			}
		}

		public string Password2
		{
			get { return _password2; }
			set
			{
				if (Equals(_password2, value)) return;
				_password2 = value;
				OnPropertyChanged();
				RegisterCommand.ChangeCanExecute();
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

		async void Register(object obj)
		{
			IsBusy = true;
			await Task.Delay(4000);
			await Application.Current.MainPage.DisplayAlert("Registration", "User is now registered", "OK");
			IsBusy = false;
		}

		bool CanRegister(object arg)
		{
			return IsInputValid();
		}

		private bool IsInputValid()
		{
			const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
									  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

			var isUsernameValid = Username.Length > 3 && Username.Length < 20;
			var regex = new Regex(emailRegex);
			var isEmailValid = regex.IsMatch(Email);
			var isPasswordValid = PasswordValid(Password1, Password2);
			return isPasswordValid && isUsernameValid && isEmailValid;
		}

		public static bool PasswordValid(string password1, string password2)
		{
			return Equals(password1, password2);
		}
	}
}
