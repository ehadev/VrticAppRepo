using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IMessageRepository
    {
        Task<List<Message>> Get();
        Task<List<Message>> Get(int id);
        Task<Message> Add(Message message);
        Task<Message> Update(int id, Message message);
    }
}
