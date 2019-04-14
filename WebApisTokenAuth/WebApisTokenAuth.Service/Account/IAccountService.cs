using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApisTokenAuth.Core.EntityModel;
using VM = WebApisTokenAuth.Model.Model;
namespace WebApisTokenAuth.Service.Account
{
    public interface IAccountService
    {

        /// <returns></returns>
        bool Login(string userName, string password);
        bool Register(VM.ApplicationUser userData);
        string GetUserRole(string userName);
        List<string> GetUserRoles();
    }
}
