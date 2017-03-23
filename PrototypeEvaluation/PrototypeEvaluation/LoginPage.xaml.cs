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
            var authData = string.Format("{0}:{1}", usernameEntry.Text, passwordEntry.Text);
            var VersionPage = new MainPage(authData);
			await Navigation.PushModalAsync(VersionPage);
		}
	}
}
