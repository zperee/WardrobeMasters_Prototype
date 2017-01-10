﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WardrobeMasters_Prototype
{
	public partial class MasterPage : MasterDetailPage
	{
		public MasterPage()
		{
			InitializeComponent();

			NavPage.ListView.ItemSelected += NavListViewOnItemSelected;
			NavPage.ListView.Footer = string.Empty;
		}

		private async void NavListViewOnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
			var item = (Startscreen)e.SelectedItem;

			switch (item.Title)
			{
				case "Home":
					Detail = new NavigationPage(new HomePage());
					break;
				default:
					await DisplayAlert("Fehler", "Fehler beim Laden der Seite", "OK");
					break;
			}
			((ListView)sender).SelectedItem = null;
			IsPresented = false;
		}

		/*private async Task PushAsync(ContentPage page, bool clearStack = true)
		{
			if (clearStack)
			{
				await NavigationStack.PopToRootAsync(true);
			}
			await NavigationStack.PushAsync(page);
		}*/
	}
}
