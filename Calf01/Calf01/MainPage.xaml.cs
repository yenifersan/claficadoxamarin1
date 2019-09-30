using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calf01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new StackLayoutDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Grid());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Datapicker());

            };
            Item7.Clicked += async (sender, e) =>
            {
                //await Navigation.PushAsync(new CarouselPageCode());

            };
            Item5.Clicked += async (sender, e) =>
            {
                //Call Popup
              //  await Navigation.PushModalAsync(new ModalPage1());

            };

            Item6.Clicked += async (sender, e) =>
            {
                //Call Popup
                var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
                Debug.WriteLine("Answer: " + answer);

            };
        }
    }
}




