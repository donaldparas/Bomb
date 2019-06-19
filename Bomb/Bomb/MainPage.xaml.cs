using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bomb
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        static string bomb = new Random().Next(1, 4).ToString();
        static int Scores = 0;
        public MainPage ()
		{
			InitializeComponent ();
		}

        async void Pindutin(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == bomb)
            {
                await DisplayAlert("Yari Ka", "Sabog", "Subukan mo Ulit");
                bomb = new Random().Next(1, 4).ToString();
                Scores = 0;
            }
            else
            {
                Scores += 1;
                await DisplayAlert("Galing", "Score:", +Scores + "Subukan mo Ulit");

            }
        }
    }
}