namespace MyAngularLearning.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyFirstAppDBContext : DbContext
    {
        public MyFirstAppDBContext()
            : base("name=MyFirstAppDBContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
