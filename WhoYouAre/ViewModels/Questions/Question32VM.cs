using MVVMAqua.Commands;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question32VM : BaseLanguageVM
	{
		public RelayCommand NavigateToCSharpCommand { get; }
		public RelayCommand NavigateToCPlusPlusCommand { get; }
		public RelayCommand GoBackCommand { get; }

		public Question32VM()
		{
			NavigateToCSharpCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new CSharpVM());
			});
			NavigateToCPlusPlusCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new CPlusPlusVM());
			});
			GoBackCommand = new RelayCommand(() =>
			{
				ViewNavigator.CloseLastView();
			});
		}
	}
}