﻿using System.Diagnostics;
using System.Text.Json.Serialization;

namespace webAPI.Models
{

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
