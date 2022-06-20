using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Zmanin
    {
        [Key]
        public int ZmanId { get; set; }
        public string ZmanName { get; set; }
        public int IdPrayer { get; set; }
    }
}
