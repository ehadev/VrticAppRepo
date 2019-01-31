using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class DeletedMessageRepository : IDeletedMessageRepository
    {
        public Task<DeletedMessage> Add(DeletedMessage deletedMessage)
        {
            throw new NotImplementedException();
        }

        public Task<List<DeletedMessage>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<DeletedMessage>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DeletedMessage> Update(int id, DeletedMessage deletedMessage)
        {
            throw new NotImplementedException();
        }
    }
}
