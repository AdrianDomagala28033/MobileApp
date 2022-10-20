using FirstPracticalTaskApp.View;
using FirstPracticalTaskApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstPracticalTaskApp
{
    public partial class MainPage : ContentPage
    {
        public PhotoInfoViewModel ViewModel { get; set; }
        private CarouselImagePage carouselImagePage;
        public MainPage()
        {
            ViewModel = new PhotoInfoViewModel();
            InitializeComponent();
            BindingContext = ViewModel;
            carouselImagePage = new CarouselImagePage(ViewModel);
        }

        private void buttonShowImageList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImageListPage(ViewModel));
        }

        private void buttonShowImageCarousel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(carouselImagePage);
        }

        private void buttonShowAddPhoto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPhotoPage(ViewModel));
        }
    }
}
