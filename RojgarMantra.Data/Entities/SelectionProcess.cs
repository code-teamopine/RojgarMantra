﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RojgarMantra.Data.Entities
{
    public class SelectionProcess 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
