using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.DTOs.Office;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IOfficeRepository
    {
        Task<List<OfficeGetDTO>> Get();
        Task<OfficeGetDTO> Get(int id);
        Task<OfficeGetDTO> Add(OfficeCreateDTO office);
        Task<OfficeGetDTO> Update(int id, OfficeUpdateDTO office);
    }
}
