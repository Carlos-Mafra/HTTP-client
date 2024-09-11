using CommunityToolkit.Mvvm.ComponentModel;
using HTTPclient.Models;
using HTTPclient.Services;
using System.Windows.Input;

namespace HTTPclient.ViewModels
{
    internal partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Post> posts;

        private ICommand getPostsCommand { get; }

        public PostViewModel()
        {
            getPostsCommand = new Command(getPosts);
        }
        public async void getPosts()
        {
            PostService postService = new PostService();
            posts = await postService.getPosts();
        }
    }
}
