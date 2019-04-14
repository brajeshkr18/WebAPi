using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApisTokenAuth.Core.EntityModel;

namespace WebApisTokenAuth.Service.OrderCollectionService
{
    public interface IOrderCollectionService
    {

        /// <returns></returns>
        dynamic GetOrderCollection();
    }
}
