using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiPoduct_seguro.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [Display(Name="Nombre del Producto")]
        public string Name { get; set;}
        [Range(0,1000000,ErrorMessage ="El Valor debe ser mayor a cero")]
        public double Value { get; set; }

    }
}