using System.ComponentModel;
using Xamarin.Forms;
using XamarinConcepts.ViewModels;

namespace XamarinConcepts.Views
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
