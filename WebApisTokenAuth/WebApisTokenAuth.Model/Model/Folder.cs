using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApisTokenAuth.Model
{
    public class Folder
    {

        public  System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; }
        public int Owner { get; set; }
       
    }
}