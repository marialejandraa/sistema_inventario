using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioEquipo.BL
{
    public class DatosEquipo
    {
            public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el equipo")]
        [MinLength(5, ErrorMessage = "Ingrese mínimo 5 caracteres")]
        public string Equipo { get; set; }

        [Required(ErrorMessage = "Ingrese marca del equipo")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Ingrese modelo del equipo")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Ingrese el serial del equipo")]
        [MinLength(5, ErrorMessage = "Ingrese mínimo 5 caracteres")]
        public string Serial { get; set; }

        [Required(ErrorMessage = "Ingrese CPU del equipo")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        [MaxLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string CPU { get; set; }

        [Required(ErrorMessage = "Ingrese RAM del equipo")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string RAM { get; set; }

        [Required(ErrorMessage = "Ingrese Disco Duro del equipo")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Disco { get; set; }

        public bool Activo { get; set; }

    }
}