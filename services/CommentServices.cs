using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_sharp_APIs.models;
using C_sharp_APIs.services.Iservices;
using Newtonsoft.Json;

namespace C_sharp_APIs.services
{
    public class CommentServices : Icomments
    {
         private readonly HttpClient httpCp1;
        private readonly string URL2="https://jsonplaceholder.typicode.com/users ";
        public async Task<List<Comments>> GetComments(string postId)
        {
            var res2 =await httpCp1.GetAsync(URL2);
            var content2= await res2.Content.ReadAsStringAsync();
            var Comments=JsonConvert.DeserializeObject<List<Comments>>(content2);
            Console.WriteLine($"{Comments}");
            

            if(res2.IsSuccessStatusCode && Comments!=null && Comments.Count >0){
                return Comments;
                // Console.WriteLine($"{comment}");
                
            }

            return new List<Comments>();
            
        }

        internal void GetComments()
        {
            throw new NotImplementedException();
        }
    }
}