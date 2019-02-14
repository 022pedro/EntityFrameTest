using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameTest.Model;

namespace EntityFrameTest.DAL
{
    
    class SchoolContext : DbContext
    {
        //install sql server express: basic->instance name="SQLEXPRESS"; custom-> can choose instance name
        //view/SqlServerObjectExplorer  add SQLServer/ choose your instance server

        //in connection string
        //
        //Data Source= ./instanceName;
        //Data Source= Server/instanceName; (as seen in SQL Server Object Explorer)
        //

        public static string connectionString = @"Data Source=HP-022PEDRO;Initial Catalog=Pizza;Trusted_Connection=True;MultipleActiveResultSets=True;
";
        public SchoolContext() : base(connectionString)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}
