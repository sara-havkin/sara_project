﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Nuschaut
    {
        [Key]
        public int NusachId { get; set; }
        public string NusachName { get; set; }
    }
}
