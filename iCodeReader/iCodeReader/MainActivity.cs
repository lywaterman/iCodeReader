using System;
using System.Runtime.InteropServices;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

using LibGit2Sharp;
using LibGit2Sharp.Core;

namespace iCodeReader
{

	[Activity (Label = "iCodeReader", MainLauncher = true)]
	public class MainActivity : Activity {
		[DllImport("git2")]
		internal static extern void giterr_set_oom();

		[DllImport("git2")]
		internal static extern int git_libgit2_capabilities();

		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.aButton);

			EditText edit = FindViewById<EditText> (Resource.Id.editText1);

			Console.WriteLine (System.Environment.Version);

			Console.WriteLine (System.Environment.OSVersion);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
				System.Console.WriteLine("i call giterr_set_oom");
				giterr_set_oom();
				var x = git_libgit2_capabilities();

				var dir = this.BaseContext.GetDir("test", FileCreationMode.WorldWriteable);

				System.Console.WriteLine(dir);
				System.Console.WriteLine(x);

				System.Console.WriteLine(dir.AbsolutePath);

				Intent intent = new Intent(this, typeof(CodeViewActivity)); 

				StartActivity(intent);

				//Repository.CloneNoCheckCer("https://github.com/lywaterman/testlibgit2sharp.git", dir.AbsolutePath+"/test");
			};

			WebView browser = FindViewById<WebView> (Resource.Id.webView1);

			browser.Settings.JavaScriptEnabled = true;

			browser.LoadUrl ("http://www.bing.com");
		
		}
	}
}


