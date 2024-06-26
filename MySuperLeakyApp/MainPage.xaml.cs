﻿using MySuperLeakyApp.ViewModels;
using MySuperLeakyApp.Views;

namespace MySuperLeakyApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Empty_Clicked(object sender, EventArgs e)
        {
            AnyPageViewModel vm = new AnyPageViewModel("Empty Test (controle test, should be OK)", "");
            await Navigation.PushAsync(new EmptyTestPage(vm));
        }
        private async void CollectionView_Clicked(object sender, EventArgs e)
        {
            AnyPageViewModel vm = new AnyPageViewModel("Collection View Test", "");
            await Navigation.PushAsync(new CollectionViewTestPage(vm));
        }

        private async void TitleView_Clicked(object sender, EventArgs e)
        {
            //AnyPageViewModel vm = new AnyPageViewModel("Title View Test", "");
            await Navigation.PushAsync(new TitleViewTestPage());// (vm));
        }
    }

}
