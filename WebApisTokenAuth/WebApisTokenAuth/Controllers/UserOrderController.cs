using System.Text;
using System.Web.Http;
using WebApisTokenAuth.Model;
using VM = WebApisTokenAuth.Model.Model;
using System;
using WebApisTokenAuth.Service.OrderCollectionService;

namespace WebApisTokenAuth.Controllers
{
    [RoutePrefix("api/Authentication")]
    public class UserOrderController : ApiController
    {

        IOrderCollectionService orderservice = new OrderCollectionService();
        
        [HttpGet]
        [Route("UserOrder")]
        [Authorize]
        public IHttpActionResult UserOrder()
        {
            
            
            return Ok(orderservice.GetOrderCollection());
        }

        
    }
}
