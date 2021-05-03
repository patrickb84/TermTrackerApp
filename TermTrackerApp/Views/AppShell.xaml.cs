using System;
using System.Collections.Generic;
using TermTrackerApp.Views;
using Xamarin.Forms;

namespace TermTrackerApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("termspage", typeof(TermsPage));
        }

    }
}
