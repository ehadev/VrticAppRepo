using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.DTOs.Kindergarten;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IKindergartenRepository
    {
        Task<List<KindergartenGetDTO>> Get();
        Task<KindergartenGetDTO> Get(int id);
        Task<KindergartenGetDTO> Add(KindergartenCreateDTO kindergarten);
        Task<KindergartenGetDTO> Update(int id, KindergartenUpdateDTO kindergarten);
    }
}
