using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface ISettingsRepository
    {
        Task<List<Settings>> Get();
        Task<List<Settings>> Get(int id);
        Task<Settings> Add(Settings settings);
        Task<Settings> Update(int id, Settings settings);
    }
}
