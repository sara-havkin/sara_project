using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Prayer:Attribute
    {
        [Key]
        public int PrayerId { get; set; }
        public int IdChapterOfPrayer { get; set; }
        public int IdChapter { get; set; }
        public int IdImportanceLevel { get; set; }
        public int TimeChapter{ get; set; }
    }
}
