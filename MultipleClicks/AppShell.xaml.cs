namespace MultipleClicks
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CollectionPage), typeof(CollectionPage));
            Routing.RegisterRoute(nameof(SelectPage), typeof(SelectPage));
        }
    }
}
