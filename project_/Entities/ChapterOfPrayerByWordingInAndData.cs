using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    class ChapterOfPrayerByWordingInData:Attribute
    {
        [key]
        public int ChapterByWordingInDataId { get; set; }
        public int PrayerId { get; set; }
        public int WordingId { get; set; }
        public int ChapterId { get; set; }
        public int DataId { get; set; }
        public int levelOfImportance { get; set; }
    }
}
