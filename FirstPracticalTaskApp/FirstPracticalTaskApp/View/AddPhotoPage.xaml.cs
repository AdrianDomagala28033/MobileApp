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
    public partial class AddPhotoPage : ContentPage
    {
        public PhotoInfoViewModel ViewModel { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public AddPhotoPage(PhotoInfoViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Url = "https://d-tm.ppstatic.pl/kadry/53/69/ee870911e18b949cae47f7e8e4b8.1000.jpg";
            ViewModel.AddPhoto(Name, Url);
            Navigation.PopAsync();
        }
    }
}