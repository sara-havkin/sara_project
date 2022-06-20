using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace DAL
{
    class PrayerContext:DbContext
    {
   
//         public partial class KabalotEntities : DbContext
//        {
//#if ZEHAVA
//        public KabalotEntities():base("name=csHome")
//#else
//            public KabalotEntities() : base("name=csSchool")
//#endif
//            {

//            }
//            static KabalotEntities()

//            {
//                Database.SetInitializer(new DBInitializer());
//            }
//            public PrayerContext() : base("name=Model1")
//        {

//        }
        public virtual DbSet<Importance> Importance { get; set; }
        public virtual DbSet<ChapterOfPrayer> ChapterOfPrayer { get; set; }
        public virtual DbSet<Prayer> Prayers { get; set; }
        public virtual DbSet<NusachOfChapter> NusachOfChapter { get; set; }
        public virtual DbSet<Nuschaut> Nuschaut { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Zmanin> Zmanin { get; set; }

    }
}
