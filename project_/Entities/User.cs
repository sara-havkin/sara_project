using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities
{
    public class User:Attribute
    {[Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int SpeedOfSpeak { get; set; }
        public Nusach Nusach { get; set; }
        public Min Min { get; set; }

    }
}
