using System;
using System.Collections.Generic;
using WardrobeMasters_Prototype.Model;
using Xamarin.Forms;

namespace WardrobeMasters_Prototype
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
			BindingContext = new HomeViewModel();
		}

	}
}
