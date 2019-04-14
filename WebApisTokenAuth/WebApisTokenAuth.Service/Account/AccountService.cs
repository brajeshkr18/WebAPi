using ExpressMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Entity;
using WebApisTokenAuth.Core.EntityModel;
using VM = WebApisTokenAuth.Model.Model;
namespace WebApisTokenAuth.Service.Account
{
    public class AccountService : IAccountService
    {
       
        private AuthenticationEntities _Context = new AuthenticationEntities();
        #region Public_Methods

        //Varifying user credentials
        public bool Login(string userName, string password)
        {
            try
            {

                var userInfo = _Context.ApplicationUsers.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
                if (userInfo != null)
                {
                    byte[] random = new Byte[100];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //regitering new 
        public bool Register(VM.ApplicationUser userData)
        {
            bool result = false;
            try
            {
                //register new user
                var userInfo = _Context.ApplicationUsers.Where(x => x.EmailID == userData.EmailID || x.UserName == userData.UserName).FirstOrDefault();
                if (userInfo == null)
                {
                    ApplicationUser User = new ApplicationUser();
                    Mapper.Map(userData, User);
                    User.CreatedOn = DateTime.Now;
                    _Context.ApplicationUsers.Add(User);
                    _Context.SaveChanges();
                    result= true;
                }
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        //To get user role provided with username
        public string GetUserRole(string userName)
        {
            return _Context.ApplicationUsers.Where(x => x.UserName == userName).Select(y => y.UserRole.RoleName).FirstOrDefault();
        }

        public List<string> GetUserRoles()
        {
            return _Context.UserRoles.Select(x => x.RoleName).ToList();
        }
        #endregion
    }
}
