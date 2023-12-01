
using C_sharp_APIs.services;

namespace C_sharp_APIs.controllers
{
    public class UserController
    {
        UserServices userServices=new UserServices();

        public  async Task Init(){
            await showUsers();

        }

        public async Task PageRedirect(){
            // await showUsers();
        }

        public async Task showUsers(){
            var users= await userServices.GetUsers();
            foreach (var user in users){
                 Console.WriteLine($"id:{user.id} \n Username:{user.username} \n Email:{user.email } \n Phone: {user.phone}");
    

            }
            
        }


    }

}
