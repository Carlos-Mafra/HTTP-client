using HTTPclient.ViewModels;

namespace HTTPclient.Views;

public partial class PostView : ContentPage
{
    public PostView()
    {
        InitializeComponent();
        BindingContext = new PostViewModel();
    }
}