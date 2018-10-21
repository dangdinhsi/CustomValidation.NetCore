﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomVladiationDotNetCore.Models
{
    public class Member
    {
        public int id { get; set; }

        [CustomValidateName, Required]
        public string Name { get; set; }

        [Required,Range(0,9999)]
        public decimal Price { get; set; }

    }
}
