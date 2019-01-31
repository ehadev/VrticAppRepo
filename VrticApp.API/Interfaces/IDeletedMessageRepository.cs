using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IDeletedMessageRepository
    {
        Task<List<DeletedMessage>> Get();
        Task<List<DeletedMessage>> Get(int id);
        Task<DeletedMessage> Add(DeletedMessage deletedMessage);
        Task<DeletedMessage> Update(int id, DeletedMessage deletedMessage);
    }
}
