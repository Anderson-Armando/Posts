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

namespace ExemploHttp.ViewModels
{
    public partial class PostsViewModels : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Post> posts;

        public ICommand getPostsCommand;

        public PostsViewModels() {
            getPostsCommand = new Command(getPosts);
        }

        public async void getPosts()
        {
            RestService restService = new RestService();
            posts = await restService.getPostAsync();
        }
    }
}
