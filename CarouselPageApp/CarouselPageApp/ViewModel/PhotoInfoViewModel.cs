using CarouselPageApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarouselPageApp.ViewModel
{
    class PhotoInfoViewModel
    {

        public List<PhotoInfo> ListOfPhoto { get; set; }
        public PhotoInfoViewModel()
        {
            ListOfPhoto = new List<PhotoInfo>();
            
            ListOfPhoto.Add(new PhotoInfo()
            {
                Name = "Wilk",
                PhotoUrl = "https://d-tm.ppstatic.pl/kadry/53/69/ee870911e18b949cae47f7e8e4b8.1000.jpg"
            });
            ListOfPhoto.Add(new PhotoInfo()
            {
                Name = "Zaic",
                PhotoUrl = "https://img.joemonster.org/i/2015/10/zajac_wilk12.jpg"
            });
            ListOfPhoto.Add(new PhotoInfo()
            {
                Name = "Szrek",
                PhotoUrl = "https://assets.puzzlefactory.pl/puzzle/281/223/original.webp"
            });
        }
    }
}
