﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Models
{
    public class Student
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
