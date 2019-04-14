using ExpressMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Entity;
using WebApisTokenAuth.Core.EntityModel;
using WebApisTokenAuth.Model;

namespace WebApisTokenAuth.Service.OrderCollectionService
{
    public class OrderCollectionService : IOrderCollectionService
    {
       
        private AuthenticationEntities _Context = new AuthenticationEntities();
        #region Public_Methods
        public dynamic GetOrderCollection()
        {
            try
            {
                OrderCollection ordercollection = new OrderCollection();
                var result= _Context.Collections.FirstOrDefault();
               
                Mapper.Map(result, ordercollection);
                return ordercollection;

            }
            catch(Exception ex)
            {
                return null;
            }
           

        }
        #endregion
    }
}
