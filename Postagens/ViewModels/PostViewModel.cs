using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Postagens.Services;
using Postagens.Models;
using System.Linq;
using System.Text;
using System;

namespace Postagens.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        List<PostModel> postagens;

        [ObservableProperty]
        private string titulo;

        [ObservableProperty]
        private string corpo;

        public ICommand DisplayPostsCommand { get; private set; }
        public PostViewModel() {
        
            DisplayPostsCommand = new Command(DisplayPosts);
        }

        public async void DisplayPosts()
        {
            PostsService postsservices = new PostsService();
            postagens = await postsservices.getPosts();
            Titulo = postagens[0].Title;
            Corpo = postagens[0].Body;
        }
    }
}
