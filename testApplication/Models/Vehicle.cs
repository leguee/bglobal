using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testApplication.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="varchar(8)")]
        [Required]
        public string Patente { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Marca { get; set; }

        [Column(TypeName = "varchar(60)")]
        [Required]
        public string Modelo { get; set; }

        public int Puertas { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Titular { get; set; }
    }
}
