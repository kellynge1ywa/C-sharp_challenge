using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_sharp_APIs.models;
using C_sharp_APIs.services.Iservices;
using Newtonsoft.Json;

namespace C_sharp_APIs.services
{
    public class UserPostServices : Iposts
    {
        private readonly HttpClient httpCp;
        private readonly string URL1="https://jsonplaceholder.typicode.com/posts  ";

        public UserPostServices()
        {
            httpCp=new HttpClient();
            
        }
       

        public async Task<List<Posts>> GetUserPosts(string userId)
        {
             var res1 =await httpCp.GetAsync(URL1);
            var content1= await res1.Content.ReadAsStringAsync();
            var Posts=JsonConvert.DeserializeObject<List<Posts>>(content1);

            if(res1.IsSuccessStatusCode && Posts!=null && Posts.Count >0){
                return Posts;
            }

            return new List<Posts>();
        }
    }
}