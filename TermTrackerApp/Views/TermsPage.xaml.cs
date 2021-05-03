using System;
using System.Collections.Generic;
using TermTrackerApp.Models;

using Xamarin.Forms;

namespace TermTrackerApp.Views
{
    public partial class TermsPage : ContentPage
    {
        public IList<Term> Terms { get; set; }

        public TermsPage()
        {
            InitializeComponent();

            Terms = new List<Term>
            {
                new Term()
                {
                    TermTitle = "Term 1",
                    TermId = 0,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(3)
                },
                new Term()
                {
                    TermTitle = "Term 2",
                    TermId = 1,
                    StartDate = DateTime.Now.AddMonths(3),
                    EndDate = DateTime.Now.AddMonths(6)
                }
            };

            BindingContext = this;
        }

        void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            Term selectedItem = e.CurrentSelection[0] as Term;
        }
    }
}
