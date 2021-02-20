﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPI.Models
{
    public class Course
    {
        
        public int courseId { get; set; }
        public string Title { get; set; }
        public int CHr { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
