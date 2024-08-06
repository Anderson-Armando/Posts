using ExemploHttp.ViewModels;
namespace ExemploHttp.View;

public partial class PostsView : ContentPage
{
	public PostsView()
	{
		BindingContext = new PostsViewModels();
		InitializeComponent();
	}
}