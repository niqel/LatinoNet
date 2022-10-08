using LatinoNet.Entities.Interfaces;
using LatinoNet.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly LatinoNetContext latinoNetContext;

        public UnityOfWork(LatinoNetContext latinoNetContext)
        {
            this.latinoNetContext = latinoNetContext;
        }

        public Task<int> SaveChange()
        {
             return this.latinoNetContext.SaveChangesAsync();
        }
    }
}
