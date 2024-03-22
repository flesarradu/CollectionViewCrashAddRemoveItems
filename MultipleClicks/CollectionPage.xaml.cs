namespace MultipleClicks;

public partial class CollectionPage : ContentPage
{
    public CollectionPage()
    {
        InitializeComponent();
        BindingContext = new CollectionViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        //We are calling the method with Task.Run as Microsoft suggested that it would be a proper way of loading data
        Task.Run(() =>
        {
            (BindingContext as CollectionViewModel)?.OnAppearing();
        });
    }
}