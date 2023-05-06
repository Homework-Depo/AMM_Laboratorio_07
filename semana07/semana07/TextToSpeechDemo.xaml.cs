using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace semana07
{	
	public partial class TextToSpeechDemo : ContentPage
	{	
		public TextToSpeechDemo ()
		{
			InitializeComponent ();

			btnSpeak.Clicked += async (sender, e) =>
			{
				await TextToSpeech.SpeakAsync(entryText.Text);
			};
		}
	}
}

