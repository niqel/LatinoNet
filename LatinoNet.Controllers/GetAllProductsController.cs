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
    public class GetAllProductsController
    {
        private readonly IGetAllProductsInputPort inputPort;
        private readonly IGetAllProductsOutputPort outputPort;

        public GetAllProductsController(IGetAllProductsInputPort inputPort, IGetAllProductsOutputPort outputPort)
        {
            this.inputPort = inputPort;
            this.outputPort = outputPort;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await this.inputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDTO>>)outputPort).Content;
        }
    }
}
