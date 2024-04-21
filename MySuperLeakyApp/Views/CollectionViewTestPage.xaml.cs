using MySuperLeakyApp.ViewModels;

namespace MySuperLeakyApp.Views;

public partial class CollectionViewTestPage : ContentPage
{
	public CollectionViewTestPage(AnyPageViewModel vm)
	{
		InitializeComponent();
		mainGrid.BindingContext = vm;
	}
}