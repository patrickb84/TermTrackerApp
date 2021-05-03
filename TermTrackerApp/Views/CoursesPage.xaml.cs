using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TermTrackerApp.Views
{
    public partial class CoursesPage : ContentPage
    {
        public CoursesPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Click me again!";
        }
    }
}
