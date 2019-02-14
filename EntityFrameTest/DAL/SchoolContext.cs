using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameTest.Model;

namespace EntityFrameTest.DAL
{
   
    //[DbConfigurationType(typeof(MyDbConfiguration))]
    class SchoolContext : DbContext
    {
        //install sql server express: basic->instance name="SQLEXPRESS"; custom-> can choose instance name
        //view/SqlServerObjectExplorer  add SQLServer/ choose your instance server

        //in connection string
        //
        //Data Source= ./instanceName;
        //Data Source= Server/instanceName; (as seen in SQL Server Object Explorer)
        //

        private static string connectionString = @"Data Source=HP-022PEDRO;Initial Catalog=Pizza;Trusted_Connection=True;MultipleActiveResultSets=True;";

        static SchoolContext()
        {
            //Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>());

            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
            Console.WriteLine("i was used :))))");
        }
        public SchoolContext() : base(connectionString)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }

  
}
