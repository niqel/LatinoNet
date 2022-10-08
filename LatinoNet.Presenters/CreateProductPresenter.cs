using LatinoNet.DTOs;
using LatinoNet.UserCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Presenters
{
    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; set; }

        public Task Handle(ProductDTO productDTO)
        {
            this.Content = productDTO;
            return Task.CompletedTask;
        }
    }
}
