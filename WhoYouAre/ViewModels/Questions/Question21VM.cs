using MVVMAqua.Commands;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question21VM : BaseLanguageVM
	{
		public RelayCommand NavigateTo31Command { get; }
		public RelayCommand NavigateTo32Command { get; }
		public RelayCommand GoBackCommand { get; }

		public Question21VM()
		{
			NavigateTo31Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question31VM());
			});
			NavigateTo32Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question32VM());
			});
			GoBackCommand = new RelayCommand(() =>
			{
				ViewNavigator.CloseLastView();
			});
		}
	}
}