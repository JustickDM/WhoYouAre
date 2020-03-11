using MVVMAqua.Commands;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question36VM : BaseLanguageVM
	{
		public RelayCommand NavigateTo1CCommand { get; }
		public RelayCommand NavigateToGoCommand { get; }
		public RelayCommand GoBackCommand { get; }

		public Question36VM()
		{
			NavigateTo1CCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new OneSVM());
			});
			NavigateToGoCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new GoVM());
			});
			GoBackCommand = new RelayCommand(() =>
			{
				ViewNavigator.CloseLastView();
			});
		}
	}
}