using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DAL
{
    public class Department
    {
        [Required]
        [Key]
        public int deptno
        {
            get;
            set;
        }
        [MaxLength(50, ErrorMessage = "can't be more than 50")]
        public string deptname
        {
            get;
            set;
        }
        [MaxLength(50, ErrorMessage = "can't be more than 50")]
        public string location
        {
            get;
            set;
        }
        public ICollection<Department> Getdepts
        {
            get;
            set;
        }

    }
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }
        public virtual DbSet<Department> Departments
        {
            get;
            set;
        }
    }
}
