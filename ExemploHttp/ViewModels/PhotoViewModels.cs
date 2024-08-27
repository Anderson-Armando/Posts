using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHttp.Models;
using ExemploHttp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace ExemploHttp.ViewModels
{
    public partial class PhotoViewModels : ObservableObject
    {


        [ObservableProperty]
        ObservableCollection<Photo> photos;

        public ICommand getPhotosCommand { get; }

        public PhotoViewModels()
        {
            getPhotosCommand = new Command(getPhotos);
        }

        public async void getPhotos()
        {
            PhotosService photosService = new PhotosService();
            Photos = await photosService.getPhotosAsync();
        }
    }
}
