using FirstPracticalTaskApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace FirstPracticalTaskApp.ViewModel
{
    public class PhotoInfoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        public ObservableCollection<PhotoInfo> ListOfPhoto { get; set; }
        /*private List<PhotoInfo> _listOfPhoto;
        public List<PhotoInfo> ListOfPhoto 
        { 
                get 
                {
                    return _listOfPhoto;
                } 
                set 
                {
                    _listOfPhoto = value;
                    OnPropertyChanged(nameof(ListOfPhoto));
                }
        }*/

        public PhotoInfoViewModel()
        {
            Title = "Photo list";

            ListOfPhoto = new ObservableCollection<PhotoInfo>();

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

        public void AddPhoto(string name, string url)
        {
            ListOfPhoto.Add(new PhotoInfo()
            {
                Name = name,
                PhotoUrl = url
            });

        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
