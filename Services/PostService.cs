using HTTPclient.Models;
using System.Diagnostics;
using System.Text.Json;

namespace HTTPclient.Services
{
    internal class PostService
    {
        private HttpClient httpClient;
        private Post post;
        private List<Post> posts;
        private JsonSerializerOptions jsonSerializerOptions;
        private object httpClind;

        public PostService()
        {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions{
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        public async Task<List<Post>> getPosts()
        {
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");
            List<Post> items = new List<Post>();
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items =  JsonSerializer.Deserialize<List<Post>>(content, jsonSerializerOptions);
                    
                }
            }
            catch (Exception ex){
                Debug.WriteLine(ex.Message);
            }
            return items;
        }
    }
}
