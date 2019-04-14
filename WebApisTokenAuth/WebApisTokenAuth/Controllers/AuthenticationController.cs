using System.Text;
using System.Web.Http;
using WebApisTokenAuth.Service.Account;
using WebApisTokenAuth.Service.Employee;
using WebApisTokenAuth.Model;
using VM = WebApisTokenAuth.Model.Model;
using System;

namespace WebApisTokenAuth.Controllers
{
    [RoutePrefix("api/Authentication")]
    public class AuthenticationController : ApiController
    {
        IAccountService accountService = new AccountService();
        IEmployeeService employeeService = new EmployeeService();
        [HttpGet]
        [Route("NoAuth")]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult NoAuth()
        {
            return Ok(accountService.GetUserRoles());
        }

        [HttpGet]
        [Route("AuthorizedUser")]
        [Authorize(Roles ="Admin")]
        public IHttpActionResult AuthorizedUser()
        {
            return Ok(accountService.GetUserRoles());
        }

        [HttpGet]
        [Route("AuthenticatedUser")]
        [Authorize]
        public IHttpActionResult AuthenticatedUser()
        {
            return Ok(employeeService.GetEmployees());
        }

        [HttpPost]
        [Route("PostUserData")]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult PostData([FromBody]Model.User userData)
        {
            ResponseMsg msgRes = new ResponseMsg();
            try
            {
                VM.ApplicationUser regData = new VM.ApplicationUser();
                regData.EmailID = userData.EmailID;
                //regData.Password = Encoding.UTF8.GetBytes(userData.Password);
                regData.Password = userData.Password;
                regData.UserName = userData.UserName;
                regData.RoleId = userData.RoleId;
                if (accountService.Register(regData))
                {
                    msgRes = new ResponseMsg { Message = "User registered successfully", Response = "success", ResponseCode = 101 };
                }
                else
                {
                    msgRes = new ResponseMsg { Message = "User already exists", Response = "failure", ResponseCode = 102 };

                }
            }
            catch(Exception ex)
            {
                msgRes.Message = ex.Message;
                msgRes.Response = "exception";
                msgRes.ResponseCode = 404;
                return Ok(msgRes);
            }

            return Ok(msgRes);
        }

    }
}
