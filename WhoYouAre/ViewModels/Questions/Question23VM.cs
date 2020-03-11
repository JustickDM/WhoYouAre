using MVVMAqua.Commands;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question23VM : BaseLanguageVM
	{
		public RelayCommand NavigateTo35Command { get; }
		public RelayCommand NavigateTo36Command { get; }
		public RelayCommand GoBackCommand { get; }

		public Question23VM()
		{
			NavigateTo35Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question35VM());
			});
			NavigateTo36Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question36VM());
			});
			GoBackCommand = new RelayCommand(() =>
			{
				ViewNavigator.CloseLastView();
			});
		}
	}
}