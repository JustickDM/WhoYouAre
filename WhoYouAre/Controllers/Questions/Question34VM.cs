using MVVMAqua.Commands;
using MVVMAqua.ViewModels;

namespace WhoYouAre.ViewModels.Questions
{
	class Question34VM : BaseVM
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