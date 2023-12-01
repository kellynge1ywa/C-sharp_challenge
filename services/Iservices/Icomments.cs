using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_sharp_APIs.models;

namespace C_sharp_APIs.services.Iservices
{
    public interface Icomments
    {
        Task <List<Comments>> GetComments(string postId);

        
    }
}