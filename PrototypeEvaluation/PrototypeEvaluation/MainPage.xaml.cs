using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrototypeEvaluation
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async void GoLoginButtonClicked(object sender, EventArgs args)
		{
			await Navigation.PopModalAsync();
		}

	}
}
