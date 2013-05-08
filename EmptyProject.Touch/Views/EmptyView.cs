using System;
using MonoTouch.UIKit;

using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;

using EmptyProject.Core.ViewModels;

namespace EmptyProject.Touch.Views
{
	public class EmptyView : MvxViewController
	{
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var textInput = new UITextField (new System.Drawing.RectangleF (0f, 0f, 320f, 32f)) {
				BackgroundColor = UIColor.LightGray,
			};
			Add (textInput);

			var textOutput = new UILabel (new System.Drawing.RectangleF (0f, 35f, 320f, 32f)) {
				TextAlignment = UITextAlignment.Center,
			};
			Add (textOutput);

			var bingingSet = this.CreateBindingSet<EmptyView, EmptyViewModel> ();
			bingingSet.Bind (textInput).To (vm => vm.Input);
			bingingSet.Bind (textOutput).To (vm => vm.Output);
			bingingSet.Apply ();
		}
	}
}

