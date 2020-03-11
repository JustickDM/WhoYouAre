using WhoYouAre.ViewModels.Base;

namespace WhoYouAre.ViewModels
{
	internal sealed class PythonVM : BaseLanguageVM
	{
		public PythonVM()
		{
			App.User.Language = "Python";
		}
	}
}