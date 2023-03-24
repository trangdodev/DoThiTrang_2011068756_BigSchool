﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BigSchool.Models;

namespace BigSchool.ViewModels
{
   
    public class CourseViewModel
    {
        internal bool ShowAction;
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IQueryable<Course> UpcommingCourses { get; internal set; }
        public DateTime GetDateTime() 
        { 
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }

        
    }
}