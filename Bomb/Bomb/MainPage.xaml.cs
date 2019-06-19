using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bomb
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        static int Scores = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        async void Pindutin(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == bomb)
            {
                await DisplayAlert("Yari Ka", "Sabog", "Subuki Ulet");
                bomb = new Random().Next(1, 4).ToString();
                Scores = 0;
            }
            else
            {
                Scores += 1;
                await DisplayAlert("Galing", "Score:", +Scores + "Subuki Ulet");

            }
        }

    }
}
