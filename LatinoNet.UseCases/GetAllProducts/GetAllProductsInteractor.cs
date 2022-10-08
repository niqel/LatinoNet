using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.UserCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        private readonly IProductRepository repository;
        private readonly IGetAllProductsOutputPort outputPort;

        public GetAllProductsInteractor(IProductRepository repository, IGetAllProductsOutputPort outputPort)
        {
            this.repository = repository;
            this.outputPort = outputPort;
        }
        public Task Handle()
        {
            var products = this.repository.GetAll().Select(x => new ProductDTO
            {
                Id = x.Id,
                Name = x.Name,
            });
            outputPort.Handle(products);
            return Task.CompletedTask;
        }
    }
}
