using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformCodeFirstApp.Models;

namespace WinformCodeFirstApp.Data
{
    public class DataBaseContext : DbContext
    {

        public DbSet<StatusModel> Statuses { get; set; }
        public DbSet<DrivingModel> Drivings { get; set; }

        public DbSet<MonitorModel> Monitors { get; set; }

        public DbSet<DiagModel> Diags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Local DataBase 설정
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=VCU;Trusted_Connection=True;");

        }
    }

}
