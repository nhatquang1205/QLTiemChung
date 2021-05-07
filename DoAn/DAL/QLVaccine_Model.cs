using System;
using System.Data.Entity;
using System.Linq;

namespace DoAn
{
    public class QLVaccine_Model : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DoAn.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public QLVaccine_Model()
            : base("name=QLTiemChung")
        {
            Database.SetInitializer<QLVaccine_Model>(new Create_DB());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Vaccine> Vaccines { get; set; }
        public virtual DbSet<LichTiem> LichTiems { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}