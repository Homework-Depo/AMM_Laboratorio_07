using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace semana07
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnTextToSpeech.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TextToSpeechDemo());
            };

            btnBatterChargeStatus.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BatteryChargeStatusDemo());
            };

            btnQRCodeReader.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new QRCodeReader());
            };
        }
    }
}