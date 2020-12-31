
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DatabaseContext
{
    class RemedyContext : DbContext
    {

        public RemedyContext(DbContextOptions options) : base(options)
        {

        }
    

    }
}
