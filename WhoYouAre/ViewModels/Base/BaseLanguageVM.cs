using MVVMAqua.Commands;
using MVVMAqua.ViewModels;

using System.IO;
using System.Text;

using WhoYouAre.ViewModels.Questions;

namespace WhoYouAre.ViewModels.Base
{
	internal abstract class BaseLanguageVM : BaseVM
	{
		public RelayCommand NavigateTo1Command { get; }
		public RelayCommand NavigateToStartCommand { get; }

		public BaseLanguageVM()
		{
			NavigateTo1Command = new RelayCommand(() =>
			{
				ViewNavigator.NavigateTo(new Question1VM());
			});
			NavigateToStartCommand = new RelayCommand(() =>
			{
				var user = App.User;
				var result = $"{user.FirstName} {user.LastName} {user.DateOfBirth} {user.Language}";
				var sb = new StringBuilder();

				sb.AppendLine(result);

				File.AppendAllText("Users", sb.ToString());

				ViewNavigator.NavigateTo(new StartVM());
			});
		}
	}
}
