using WhoYouAre.ViewModels.Base;

namespace WhoYouAre.ViewModels
{
	internal sealed class KotlinVM : BaseLanguageVM
	{
		public KotlinVM()
		{
			App.User.Language = "Kotlin";
		}
	}
}