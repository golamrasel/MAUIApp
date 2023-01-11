using MyFirstMAUIApp;

namespace MyFirstMAUIApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var navigation = new NavigationPage(new MainPage());
        navigation.BarBackground = Colors.MediumSeaGreen;
        navigation.BarTextColor = Colors.White;
        MainPage = new GridPageDemo();
	}
}
