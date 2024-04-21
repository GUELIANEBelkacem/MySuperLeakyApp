using MySuperLeakyApp.ViewModels;

namespace MySuperLeakyApp.Views;

public partial class TitleViewTestPage : ContentPage
{
	public TitleViewTestPage(AnyPageViewModel vm)
	{
		InitializeComponent();
		label.Text = vm.Title;
	}
}