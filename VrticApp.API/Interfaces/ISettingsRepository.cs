using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.DTOs.Settings;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface ISettingsRepository
    {
        Task<List<SettingsGetDTO>> Get();
        Task<SettingsGetDTO> Get(int id);
        Task<SettingsGetDTO> Add(SettingsCreateDTO settings);
        Task<SettingsGetDTO> Update(int id, SettingsUpdateDTO settings);
    }
}
