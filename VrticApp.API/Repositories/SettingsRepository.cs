using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class SettingsRepository : ISettingsRepository
    {
        public Task<Settings> Add(Settings settings)
        {
            throw new NotImplementedException();
        }

        public Task<List<Settings>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Settings>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Settings> Update(int id, Settings settings)
        {
            throw new NotImplementedException();
        }
    }
}
