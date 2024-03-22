namespace MultipleClicks;

public partial class SelectPage : ContentPage
{
	public SelectPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..?Parameter=test");
    }
}