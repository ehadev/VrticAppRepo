using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.Interfaces;
using VrticApp.API.Repositories;

namespace VrticApp.API.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGradeRepository GradeRepository { get; private set; }

        private readonly MyContext _context;
        public UnitOfWork(MyContext context)
        {
            _context = context;
            GradeRepository = new GradeRepository(_context);

        }
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
