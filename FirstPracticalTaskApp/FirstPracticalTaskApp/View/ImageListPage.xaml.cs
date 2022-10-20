using FirstPracticalTaskApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstPracticalTaskApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageListPage : ContentPage
    {
        public PhotoInfoViewModel ViewModel { get; set; }
        public ImageListPage(PhotoInfoViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            BindingContext = ViewModel;
        }

        private void buttonReturn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}