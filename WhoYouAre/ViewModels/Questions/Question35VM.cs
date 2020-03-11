using MVVMAqua.Commands;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question35VM : BaseLanguageVM
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