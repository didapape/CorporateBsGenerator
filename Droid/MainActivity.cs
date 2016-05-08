﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace CorporateBsGenerator.Droid
{
	[Activity (Label = "Corporate BS Generator", Icon = "@drawable/ic_launcher", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}
	}
}

