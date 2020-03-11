using MVVMAqua.Commands;
using MVVMAqua.Enums;
using MVVMAqua.ViewModels;

using WhoYouAre.Models;
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
					App.User = new User
					{
						FirstName = FirstName,
						LastName = LastName,
						DateOfBirth = DateOfBirth,
						PageId = PageId
					};

					ViewNavigator.NavigateTo(new Question1VM());
				}
				else
				{
					ViewNavigator.ShowDialog("Заполните все поля для продолжения", ModalIcon.Warning);
				}
			});
		}
	}
}