﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace new_crud.Models
{
    public class movie
    {
        [Key]
        public int Mid { get; set; }
        public string Moviename { get; set; }
        public DateTime DateofRelease { get; set; }
    }
}