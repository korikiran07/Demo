using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using System.Collections.Generic;
using Android.Util;

namespace Demo
{
	[Activity(Label = "Demo", MainLauncher = false, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		WebView webview;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			FnInitialization();
			FnCliCKEvent();
		}

		void FnInitialization()
		{
			webview = FindViewById<WebView>(Resource.Id.webView1);

			try
			{
				webview.LoadUrl("https://developer.xamarin.com/recipes/android/controls/webview/load_local_content/");


				//List<int> list = new List<int>();

				//int kjhf = list[0];

				//int a = 10;
				//int b = 0;

				//int x = a/b;
			}
			catch (System.Exception ex)
			{
				throw ex;
			}
			//webview.LoadUrl(string.Format("javascript: {0}", script));
		
		}

		void FnCliCKEvent()
		{ 
		
		}


	}
}

