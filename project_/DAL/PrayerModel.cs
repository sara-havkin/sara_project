using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class PrayerModel : DbContext
    {
        public PrayerModel()
            : base("name=PrayerContext ")
        {
        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
