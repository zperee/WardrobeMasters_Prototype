using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WardrobeMasters_Prototype
{
	public class RegistrationViewModel : INotifyPropertyChanged
	{
		private String _username;
		private String _password;
		private String _email;

		public event PropertyChangedEventHandler PropertyChanged;


		void OnPropertyChanged([CallerMemberName] string name = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

	}
}
