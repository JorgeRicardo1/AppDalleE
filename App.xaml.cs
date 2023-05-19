using AppDalleE.Views;

namespace AppDalleE;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DashBoardView();
	}
}
