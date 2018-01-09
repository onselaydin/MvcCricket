using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcCricket.Models
{
    public class Cricketer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int ODI { get; set; }
        public int Test { get; set; }
    }

    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string SureName { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }

    }

    public class Cricketers : DbContext {
        public DbSet<Cricketer> Cricketer { get; set; }
        public DbSet<Employee> Employeers { get; set; }
    }
}