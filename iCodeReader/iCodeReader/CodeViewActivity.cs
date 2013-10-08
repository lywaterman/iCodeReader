using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Android.Webkit;

namespace iCodeReader
{
	[Activity (Label = "CodeViewActivity")]			
	public class CodeViewActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.CodeView);

			WebView browser = FindViewById<WebView> (Resource.Id.webView1);

			browser.Settings.JavaScriptEnabled = true;
			browser.Settings.JavaScriptCanOpenWindowsAutomatically = true;

			browser.SetWebViewClient (new WebViewClient ());

			browser.Settings.BuiltInZoomControls = true;
			browser.Settings.SetSupportZoom (true);

			browser.LoadUrl ("http://www.bing.com");
			// Create your application here
		}
	}
}

