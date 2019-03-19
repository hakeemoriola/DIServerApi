using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using NHPApiSec.Models;
using Owin;

[assembly: OwinStartup(typeof(NHPApiSec.Startup))]

namespace NHPApiSec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        private void createRolesandUsers()
        {
            SAPAPIContext context = new SAPAPIContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User
            if (!roleManager.RoleExists("ApiUser"))
            {

                // first we create Admin role
                var role = new IdentityRole
                {
                    Name = "ApiUser"
                };
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website

                var user = new ApplicationUser
                {
                    FirstName = "Hakeem",
                    LastName = "Oriola",
                    UserName = "oriolaakeem@outlook.com",
                    Email = "oriolaakeem@outlook.com"
                };

                string userPWD = "123abcABC,./";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "ApiUser");

                }

                var user1 = new ApplicationUser
                {
                    FirstName = "Samuel",
                    LastName = "Adeleke",
                    UserName = "adelekesamuel_tst@yahoo.com",
                    Email = "adelekesamuel_tst@yahoo.com"
                };

                string userPWD1 = "123xyzXYZ,./";

                var chkUser1 = UserManager.Create(user1, userPWD1);

                //Add default User to Role Admin
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user1.Id, "ApiUser");
                }
            }

        }
    }
}
