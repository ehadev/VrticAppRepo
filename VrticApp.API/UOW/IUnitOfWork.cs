using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;

namespace VrticApp.API.UOW
{
    public interface IUnitOfWork: IDisposable
    {
        IGradeRepository GradeRepository { get; }
        Task<int> Complete();

    }
}
