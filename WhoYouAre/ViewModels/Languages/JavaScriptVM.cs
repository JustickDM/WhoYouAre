using WhoYouAre.ViewModels.Base;

namespace WhoYouAre.ViewModels
{
	internal sealed class JavaScriptVM : BaseLanguageVM
	{
		public JavaScriptVM()
		{
			App.User.Language = "JavaScript";
		}
	}
}