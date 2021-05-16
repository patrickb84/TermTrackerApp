using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TermTrackerApp.Views
{
    public partial class NewTermPage : ContentPage
    {
        public string termName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public NewTermPage()
        {
            InitializeComponent();
        }

        async void HandleClose(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        void TermName_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            //string oldText = e.OldTextValue;
            //string newText = e.NewTextValue;
            termName = e.NewTextValue;
        }

        void TermName_Completed(System.Object sender, System.EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }

        void FormSubmit_Clicked(System.Object sender, System.EventArgs e)
        {
            var fTermName = termName;
            var fStartDate = startDate;
            var fEndDate = endDate;
        }

        void StartDatePicker_DateSelected(System.Object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            startDate = startDatePicker.Date;
        }

        void EndDatePicker_DateSelected(System.Object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            endDate = endDatePicker.Date;
        }
    }
}
