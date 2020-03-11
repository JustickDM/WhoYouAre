using MVVMAqua.Commands;
using MVVMAqua.ViewModels;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question31VM : BaseVM
	{
		public RelayCommand NavigateToJavaCommand { get; }
		public RelayCommand NavigateToKotlinCommand { get; }
		public RelayCommand GoBackCommand { get; }

		public Question31VM()
		{
			NavigateToJavaCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new JavaVM());
			});
			NavigateToKotlinCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new KotlinVM());
			});
			GoBackCommand = new RelayCommand(() =>
			{
				ViewNavigator.CloseLastView();
			});
		}
	}
}