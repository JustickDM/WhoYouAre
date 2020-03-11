using WhoYouAre.ViewModels.Base;

namespace WhoYouAre.ViewModels
{
	internal sealed class CSharpVM : BaseLanguageVM
	{
		public CSharpVM()
		{
			App.User.Language = "C#";
		}
	}
}