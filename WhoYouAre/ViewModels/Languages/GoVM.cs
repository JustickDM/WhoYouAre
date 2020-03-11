namespace WhoYouAre.ViewModels
{
	internal sealed class GoVM : BaseLanguageVM
	{
		public GoVM()
		{
			App.User.Language = "Go";
		}
	}
}