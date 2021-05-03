using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TermTrackerApp.Views
{
    public partial class NewTermPage : ContentPage
    {
        public NewTermPage()
        {
            InitializeComponent();
        }

        async void HandleClose(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
