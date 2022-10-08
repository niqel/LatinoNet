using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Entities.Interfaces
{
    public interface IUnityOfWork
    {
        Task<int> SaveChange();
    }
}
