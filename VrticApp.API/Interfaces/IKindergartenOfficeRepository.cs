using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IKindergartenOfficeRepository
    {
        Task<List<KindergartenOffice>> Get();
        Task<List<KindergartenOffice>> Get(int id);
        Task<KindergartenOffice> Add(KindergartenOffice kindergartenOffice);
        Task<KindergartenOffice> Update(int id, KindergartenOffice kindergartenOffice);
    }
}
