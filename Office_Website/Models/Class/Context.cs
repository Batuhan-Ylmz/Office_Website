﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Office_Website.Models.Class
{
    public class Context : DbContext
    {
        public DbSet <About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<ReplyClass> ReplyClasses { get; set; }
    }
}