using WhoYouAre.ViewModels.Base;

namespace WhoYouAre.ViewModels
{
	internal sealed class CVM : BaseLanguageVM
	{
		public CVM()
		{
			App.User.Language = "C";
		}
	}
}