using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface INotificationRepository
    {
        Task<List<Notification>> Get();
        Task<List<Notification>> Get(int id);
        Task<Notification> Add(Notification notification);
        Task<Notification> Update(int id, Notification notification);
    }
}
