using System.ComponentModel;
using Xamarin.Forms;
using CountYourselfApp.ViewModels;

namespace CountYourselfApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
