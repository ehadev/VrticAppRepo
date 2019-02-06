using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class KindergartenOfficeRepository : IKindergartenOfficeRepository
    {
        public Task<KindergartenOffice> Add(KindergartenOffice kindergartenOffice)
        {

            throw new NotImplementedException();
        }

        public Task<List<KindergartenOffice>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<KindergartenOffice>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<KindergartenOffice> Update(int id, KindergartenOffice kindergartenOffice)
        {
            throw new NotImplementedException();
        }
    }
}
