using MVVMAqua.Commands;
using MVVMAqua.ViewModels;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question22VM : BaseVM
	{
		public RelayCommand NavigateTo33Command { get; }
		public RelayCommand NavigateTo34Command { get; }
		public RelayCommand GoBackCommand { get; }

		public Question22VM()
		{
			NavigateTo33Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question33VM());
			});
			NavigateTo34Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question34VM());
			});
			GoBackCommand = new RelayCommand(() =>
			{
				ViewNavigator.CloseLastView();
			});
		}
	}
}