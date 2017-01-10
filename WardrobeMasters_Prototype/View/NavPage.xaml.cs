using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WardrobeMasters_Prototype
{
	public partial class NavPage : ContentPage
	{
		public ListView ListView => NavListView;

		public NavPage()
		{
			InitializeComponent();

			NavListView.ItemsSource = new List<Startscreen> {
				new Startscreen {Image = "home.png", Title = "Home"},
				new Startscreen {Image = "warning.png", Title = "Test"},
				new Startscreen {Image = "association.png", Title = "ujkasdfh"}
			};
		}
	}
}
