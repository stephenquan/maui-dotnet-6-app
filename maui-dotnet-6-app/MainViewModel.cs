using CommunityToolkit.Mvvm.ComponentModel;

namespace maui_dotnet_6_app;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    string firstName;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    string lastName;

    public string FullName =>
        $"{FirstName} {LastName}";
}
