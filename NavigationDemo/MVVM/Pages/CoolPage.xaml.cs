using NavigationDemo.Utilities;

namespace NavigationDemo.MVVM.Pages;

public partial class CoolPage : ContentPage
{
	public CoolPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }
}