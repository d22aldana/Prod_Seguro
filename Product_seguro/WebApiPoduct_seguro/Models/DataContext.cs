﻿

namespace WebApiPoduct_seguro.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }
    }
}