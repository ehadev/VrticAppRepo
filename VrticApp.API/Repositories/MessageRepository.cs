using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        public Task<Message> Add(Message message)
        {
            throw new NotImplementedException();
        }

        public Task<List<Message>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Message>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Message> Update(int id, Message message)
        {
            throw new NotImplementedException();
        }
    }
}
