using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        public Task<Notification> Add(Notification notification)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notification>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Notification>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Notification> Update(int id, Notification notification)
        {
            throw new NotImplementedException();
        }
    }
}
