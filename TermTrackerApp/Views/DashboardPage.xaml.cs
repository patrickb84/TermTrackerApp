using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TermTrackerApp.Views
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        async void HandleViewAllTerms(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("termspage");
        }

        async void HandleAddATerm(System.Object sender, System.EventArgs e)
        {
            var newTermPage = new NewTermPage();
            await Navigation.PushModalAsync(newTermPage);
        }
    }
}
