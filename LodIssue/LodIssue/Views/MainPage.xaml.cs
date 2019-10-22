using LodIssue.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LodIssue.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MainPageViewModel();
        }
    }
}