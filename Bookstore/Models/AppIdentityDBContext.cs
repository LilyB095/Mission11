using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class AppIdentityDBContext : IdentityDbContext<IdentityUser>
    {
        //set up constructor that sets up options for this file
        public AppIdentityDBContext(DbContextOptions options) : base(options)
        {


        }
    }
}
