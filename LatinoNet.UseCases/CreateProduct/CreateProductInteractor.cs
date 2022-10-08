using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.UserCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreatedProductInputPort
    {
        private readonly IProductRepository repository;
        private readonly IUnityOfWork unityOfWork;
        private readonly ICreateProductOutputPort outputPort;

        public CreateProductInteractor(IProductRepository productRepository, IUnityOfWork unityOfWork, ICreateProductOutputPort createProductOutputPort) =>
            (this.repository, this.unityOfWork, this.outputPort) = 
            (productRepository, unityOfWork, createProductOutputPort);
        
        public async Task handle(CreateProductDTO createProductDTO)
        {
            Product newProduct = new Product()
            {
                Name = createProductDTO.ProductName
            };
            this.repository.Create(newProduct);
            await this.unityOfWork.SaveChange();
            await outputPort.Handle(new ProductDTO 
            { 
                Id = newProduct.Id, 
                Name = newProduct.Name 
            });
        }
    }
}
