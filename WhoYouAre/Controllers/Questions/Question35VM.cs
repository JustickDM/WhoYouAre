using MVVMAqua.Commands;
using MVVMAqua.ViewModels;

namespace WhoYouAre.ViewModels.Questions
{
	class Question35VM : BaseVM
	{
		public RelayCommand NavigateToJavaScriptCommand { get; }
		public RelayCommand NavigateToTypeScriptCommand { get; }
		public RelayCommand GoBackCommand { get; }

		public Question35VM()
		{
			NavigateToJavaScriptCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new JavaScriptVM());
			});
			NavigateToTypeScriptCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new TypeScriptVM());
			});
			GoBackCommand = new RelayCommand(() =>
			{
				ViewNavigator.CloseLastView();
			});
		}
	}
}