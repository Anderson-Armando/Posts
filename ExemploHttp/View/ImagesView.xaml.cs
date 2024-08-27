using ExemploHttp.ViewModels;

namespace ExemploHttp.View;

public partial class ImagesView : ContentPage
{
	public ImagesView()
	{
        BindingContext = new PhotoViewModels();
		InitializeComponent();

	}
}