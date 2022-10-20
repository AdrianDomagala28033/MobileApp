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
    public partial class CarouselImagePage : CarouselPage
    {
        public PhotoInfoViewModel ViewModel { get; set; }
        public CarouselImagePage(PhotoInfoViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            BindingContext = viewModel;
        }
    }
}