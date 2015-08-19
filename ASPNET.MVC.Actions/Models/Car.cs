using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET.MVC.Actions.Models
{
    public class Car
    {
        public int Id { get; set; }

        [DisplayName("Marca")]
        [DataType(DataType.Text)]
        [Required]
        public string Brand { get; set; }

        [DisplayName("Modelo")]
        [DataType(DataType.Text)]
        [Required]
        public string Model { get; set; }

        [DisplayName("Color")]
        [DataType(DataType.Text)]
        [Required]
        public string Color { get; set; }

        [DisplayName("Unidades")]
        [DataAnnotationsExtensions.Integer]
        [Required]
        public int Units { get; set; }

        [DisplayName("Estado")]
        [DataType(DataType.Text)]
        public string Status { get; set; }
    }
}
