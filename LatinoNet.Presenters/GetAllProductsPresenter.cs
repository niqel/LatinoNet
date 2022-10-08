using LatinoNet.DTOs;
using LatinoNet.UserCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Presenters
{
    public class GetAllProductsPresenter : IGetAllProductsOutputPort, IPresenter<IEnumerable<ProductDTO>>
    {
        public IEnumerable<ProductDTO> Content { get; set; }

        public Task Handle(IEnumerable<ProductDTO> products)
        {
            Content = products;
            return Task.CompletedTask;
        }
    }
}
