using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrototypeEvaluation
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		async void OnLoginButtonClicked(object sender, EventArgs args)
		{
			var VersionPage = new MainPage();
			await Navigation.PushModalAsync(VersionPage);
		}
	}
}
