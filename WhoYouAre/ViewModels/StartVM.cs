using MVVMAqua.Commands;
using MVVMAqua.ViewModels;

namespace WhoYouAre.ViewModels
{
	class StartVM : BaseVM
	{
		public RelayCommand NavigateToLoginCommand { get; }

		public StartVM()
		{
			NavigateToLoginCommand = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new LoginVM());
			});
		}
	}
}