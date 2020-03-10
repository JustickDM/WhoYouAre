using MVVMAqua;
using MVVMAqua.Enums;

using System.Windows;

using WhoYouAre.ViewModels;

namespace WhoYouAre
{
	/// <summary>
	/// Логика взаимодействия для App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			var bootstrapperBuilder = new BootstrapperBuilder();
			var bootstrapper = bootstrapperBuilder.Build();

			bootstrapper.OpenNewWindow(
				new StartVM(),
				vm => vm.WindowTitle = "Приветствие",
				null,
				null,
				nav => nav.ViewNavigator.ShowDialog("Вы точно хотите выйти из программы?", ModalIcon.Question, "Выход", "Выйти", "Отмена"));
		}
	}
}
