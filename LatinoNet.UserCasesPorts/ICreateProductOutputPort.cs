using LatinoNet.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UserCasesPorts
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDTO productDTO);
    }
}
