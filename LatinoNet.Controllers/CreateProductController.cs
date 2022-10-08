using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UserCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        private readonly ICreatedProductInputPort inputPort;
        private readonly ICreateProductOutputPort outputPort;

        public CreateProductController(ICreatedProductInputPort inputPort, ICreateProductOutputPort outputPort) 
        {
            this.inputPort = inputPort;
            this.outputPort = outputPort;
        }

        [HttpPost]
        public async Task<ProductDTO> CreateProduct(CreateProductDTO product)
        {
            await inputPort.handle(product);
            return ((IPresenter<ProductDTO>)outputPort).Content;
        }
    }
}
