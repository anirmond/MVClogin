using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccesLayer;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using Dapper;

namespace BusinessLayer
{
   public class UserUtil
    {
        LoginEntitiesCurrent loginContext = new LoginEntitiesCurrent();

        public LoggedInUser AuthenticateUser(string username, string password)
        {
            var result = loginContext.ValidateUser(username, password).Select(x =>
                                                                                 new LoggedInUser
                                                                                 {
                                                                                     FirstNAme = x.FirstName,
                                                                                     LastName = x.LastName,
                                                                                     UserName = x.User_Name,
                                                                                     IsMatched = x.IsPasswordMatch
                                                                                 }).SingleOrDefault();

            //List<LoggedInUser> loggedInUser = new List<LoggedInUser>();

            //foreach (var item in result)
            //{
            //    loggedInUser.Add(new LoggedInUser { LastName = item.LastName, FirstNAme = item.FirstName });

            //}

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginEntitiesCurrent1"].ConnectionString))
            {

                var exp =  con.Query<LoggedInUser>("ValidateUser", new { username = username, password = password },commandType: CommandType.StoredProcedure).First();
            }

            return result;
        }
        public void RegisterNewUser(RegisterUser user)
        {
            loginContext.sp_InsertUser(user.UserName,user.Password,user.FirstNAme,user.LastName);
        }

        public List<UserDisplayGrid> GridDisplayUser()
        {
            List<UserDisplayGrid> Result = loginContext.sp_DisplayUserInfo().Select(x =>
                                                              new UserDisplayGrid
                                                              {
                                                                  FirstName = x.FirstName,
                                                                  LastName = x.LastName,
                                                                  UserName = x.User_Name
                                                              }).ToList();
            return Result;





        } 

        
    }
}
