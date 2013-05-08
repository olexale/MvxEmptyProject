using System;
using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;

namespace EmptyProject.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup (Context appContext) : base (appContext)
		{
		}

		protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp ()
		{
			return new EmptyProject.Core.App ();
		}
	}
}

