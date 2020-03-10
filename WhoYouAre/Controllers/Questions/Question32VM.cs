using MVVMAqua.Commands;
using MVVMAqua.ViewModels;

namespace WhoYouAre.ViewModels.Questions
{
	class Question32VM : BaseVM
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