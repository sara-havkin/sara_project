using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Importance
    {
        [Key]

       // public int ImportanceLevelId { get; set; }
        public int ImpotanceId { get; set; }
        public int IdNusach { get; set; }
    }
}
