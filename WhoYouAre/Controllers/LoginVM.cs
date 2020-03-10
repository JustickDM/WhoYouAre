using MVVMAqua.Commands;
using MVVMAqua.ViewModels;

using System.IO;
using System.Text;

using WhoYouAre.ViewModels.Questions;

namespace WhoYouAre.ViewModels
{
	class LoginVM : BaseVM
	{
		private string firstName;
		public string FirstName
		{
			get => firstName;
			set
			{
				firstName = value;
				OnPropertyChanged();
			}
		}

		private string lastName;
		public string LastName
		{
			get => lastName;
			set
			{
				lastName = value;
				OnPropertyChanged();
			}
		}

		private string dateOfBirth;
		public string DateOfBirth
		{
			get => dateOfBirth;
			set
			{
				dateOfBirth = value;
				OnPropertyChanged();
			}
		}

		private string pageId;
		public string PageId
		{
			get => pageId;
			set
			{
				pageId = value;
				OnPropertyChanged();
			}
		}

		public RelayCommand NavigateTo1Command { get; }

		public LoginVM()
		{
			NavigateTo1Command = new RelayCommand(() =>
			{
				var isValid = !string.IsNullOrWhiteSpace(FirstName) &&
							  !string.IsNullOrWhiteSpace(LastName) &&
							  !string.IsNullOrWhiteSpace(DateOfBirth) &&
							  !string.IsNullOrWhiteSpace(PageId);

				if(isValid)
				{
					var userInfo = $"{FirstName} {LastName} {DateOfBirth} {PageId}";

					File.WriteAllText("Users.txt", userInfo);

					ViewNavigator.NavigateTo(new Question1VM());
				}
				else
				{
					ViewNavigator.ShowDialog("Заполните все поля для продолжения:)");
				}
			});
		}
	}
}