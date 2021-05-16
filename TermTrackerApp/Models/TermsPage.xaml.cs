using System;
using System.Collections.Generic;
using TermTrackerApp.Models;

using Xamarin.Forms;

namespace TermTrackerApp.Views
{
    public partial class TermsPage : ContentPage
    {
        public IList<Term> AllTerms { get; set; }

        public TermsPage()
        {
            InitializeComponent();
            new Terms();

            AllTerms = Terms.AllTerms;

            BindingContext = this;
        }

        void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            Term selectedItem = e.CurrentSelection[0] as Term;
        }
    }
}
