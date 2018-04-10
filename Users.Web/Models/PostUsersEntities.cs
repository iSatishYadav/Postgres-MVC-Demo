using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Users.Web.Models
{
    public class PostUsersEntities : DbContext
    {
        public PostUsersEntities() : base("UserPostEntities")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}