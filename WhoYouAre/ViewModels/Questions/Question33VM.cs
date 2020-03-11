using MVVMAqua.Commands;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question33VM : BaseLanguageVM
	{
		public RelayCommand NavigateToAssemblerCommand { get; }
		public RelayCommand NavigateToCCommand { get; }
		public RelayCommand GoBackCommand { get; }

		public Question33VM()
		{
			NavigateToAssemblerCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new AssemblerVM());
			});
			NavigateToCCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new CVM());
			});
			GoBackCommand = new RelayCommand(() =>
			{
				ViewNavigator.CloseLastView();
			});
		}
	}
}