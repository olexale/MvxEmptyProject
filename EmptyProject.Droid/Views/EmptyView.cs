using System;
using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace EmptyProject.Droid.Views
{
	[Activity(Label="Empty View")]
	public class EmptyView : MvxActivity
	{
		protected override void OnCreate (Android.OS.Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.EmptyView);
		}
	}
}

