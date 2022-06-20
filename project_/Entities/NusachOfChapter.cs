using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class NusachOfChapter
    {
        [Key]
        public int NusachOfChapterId { get; set; }
        public int IdChapter { get; set; }

    }
}
