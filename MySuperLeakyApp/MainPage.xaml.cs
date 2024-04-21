using MySuperLeakyApp.ViewModels;
using MySuperLeakyApp.Views;

namespace MySuperLeakyApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Empty_Clicked(object sender, EventArgs e)
        {
            AnyPageViewModel vm = new AnyPageViewModel("Empty Test (controle test, should be OK)", "");
            Navigation.PushAsync(new EmptyTestPage(vm));
        }
        private void CollectionView_Clicked(object sender, EventArgs e)
        {
            AnyPageViewModel vm = new AnyPageViewModel("Collection View Test", "");
            Navigation.PushAsync(new CollectionViewTestPage(vm));
        }

        private void TitleView_Clicked(object sender, EventArgs e)
        {
            AnyPageViewModel vm = new AnyPageViewModel("Title View Test", "");
            Navigation.PushAsync(new TitleViewTestPage(vm));
        }
    }

}
