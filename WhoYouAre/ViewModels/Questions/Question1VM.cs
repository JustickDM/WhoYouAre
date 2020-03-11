using MVVMAqua.Commands;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question1VM : BaseLanguageVM
	{
		public RelayCommand NavigateTo21Command { get; }
		public RelayCommand NavigateTo22Command { get; }
		public RelayCommand NavigateTo23Command { get; }

		public Question1VM()
		{
			NavigateTo21Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question21VM());
			});
			NavigateTo22Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question22VM());
			});
			NavigateTo23Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question23VM());
			});
		}
	}
}