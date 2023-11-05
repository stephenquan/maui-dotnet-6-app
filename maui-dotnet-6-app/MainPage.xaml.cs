namespace maui_dotnet_6_app;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel VM)
	{
		InitializeComponent();
		BindingContext = VM;
	}
}

