using MVVMAqua.Commands;

namespace WhoYouAre.ViewModels.Questions
{
	internal sealed class Question34VM : BaseLanguageVM
	{
		public RelayCommand NavigateToPythonCommand { get; }
		public RelayCommand NavigateToPHPCommand { get; }
		public RelayCommand GoBackCommand { get; }

		public Question34VM()
		{
			NavigateToPythonCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new PythonVM());
			});
			NavigateToPHPCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new PHPVM());
			});
			GoBackCommand = new RelayCommand(() =>
			{
				ViewNavigator.CloseLastView();
			});
		}
	}
}