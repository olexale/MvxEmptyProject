using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace EmptyProject.Droid
{
	[Activity(Label="Empty Project", MainLauncher = true, Icon = "@drawable/icon")]
	public class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen ()
			: base (Resource.Layout.SplashScreen)
		{
		}
	}
}

