using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

using C_sharp_APIs.models;
using C_sharp_APIs.services.Iservices;

namespace C_sharp_APIs.services
{
    public class UserServices : Iuser
    {
        private readonly HttpClient httpC;
        private readonly string URL="https://jsonplaceholder.typicode.com/users ";

        public UserServices()
        {
            httpC=new HttpClient();
            
        }
        public async Task<List<Users>> GetUsers()
        {
            var res =await httpC.GetAsync(URL);
            var content= await res.Content.ReadAsStringAsync();
            var Users=JsonConvert.DeserializeObject<List<Users>>(content);

            if(res.IsSuccessStatusCode && Users!=null && Users.Count >0){
                return Users;
            }

            return new List<Users>();
        }
    }
}