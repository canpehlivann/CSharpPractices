﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaFunctions
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int ID { get; set; }
        
        public string FullName { get { return $"{FirstName} {LastName}";  } }
    }
}
