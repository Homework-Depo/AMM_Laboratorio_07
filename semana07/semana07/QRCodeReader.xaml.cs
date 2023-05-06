using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace semana07
{	
	public partial class QRCodeReader : ContentPage
	{	
		public QRCodeReader ()
		{
			InitializeComponent ();
		}

        void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                scanResultText.Text = result.Text + " (type: " + result.BarcodeFormat.ToString() + ")";
            });
        }
    }
}

