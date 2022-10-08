using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly LatinoNetContext latinoNetContext;
        public ProductRepository(LatinoNetContext latinoNetContext)
        {
            this.latinoNetContext = latinoNetContext;
        }
        public void Create(Product product)
        {
            this.latinoNetContext.Add(product);
        }

        public Product Get(int id)
        {
            return this.latinoNetContext.Products.Where(x => x.Id == id).First();
        }

        public IEnumerable<Product> GetAll()
        {
            return this.latinoNetContext.Products.AsEnumerable();
        }
    }
}
