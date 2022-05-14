using Srez.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Srez.Views
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