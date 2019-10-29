using LodIssue.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LodIssue.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentView
    {
        MasterPageViewModel context;
        public MainPage()
        {
            InitializeComponent();
            //BindingContext = viewModel = new MainPageViewModel();
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            context = (MasterPageViewModel)Parent.BindingContext;
        }
    }
}