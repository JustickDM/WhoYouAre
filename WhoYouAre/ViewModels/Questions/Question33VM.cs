using MVVMAqua.Commands;
using MVVMAqua.ViewModels;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question33VM : BaseVM
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