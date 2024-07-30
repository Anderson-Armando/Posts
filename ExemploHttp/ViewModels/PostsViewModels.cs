using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHttp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHttp.ViewModels
{
    public partial class PostsViewModels : ObservableObject
    {
        [ObservableProperty]
        List<Post> posts;
    }
}
