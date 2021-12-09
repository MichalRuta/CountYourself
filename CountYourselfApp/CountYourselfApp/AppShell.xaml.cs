using System;
using System.Collections.Generic;
using CountYourselfApp.ViewModels;
using CountYourselfApp.Views;
using Xamarin.Forms;

namespace CountYourselfApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
