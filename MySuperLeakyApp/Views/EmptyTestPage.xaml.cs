using MySuperLeakyApp.ViewModels;

namespace MySuperLeakyApp.Views;

public partial class EmptyTestPage : ContentPage
{
	public EmptyTestPage(AnyPageViewModel vm)
	{
		InitializeComponent();
		label.Text = vm.Title;
	}
}