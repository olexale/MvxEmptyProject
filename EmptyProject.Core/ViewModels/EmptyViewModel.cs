using Cirrious.MvvmCross.ViewModels;

namespace EmptyProject.Core.ViewModels
{
	public class EmptyViewModel : MvxViewModel
	{
		string _input;
		public string Input {
			get { return _input; }
			set {
				_input = value;
				RaisePropertyChanged (() => Output);
			}
		}

		public string Output {
			get { return _input; }
		}
	}
}

