using WhoYouAre.ViewModels.Base;

namespace WhoYouAre.ViewModels
{
	internal sealed class CPlusPlusVM : BaseLanguageVM
	{
		public CPlusPlusVM()
		{
			App.User.Language = "C++";
		}
	}
}