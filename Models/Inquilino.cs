using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace inmobiliariaULP_Gonzalez.Models
{
	public class Inquilino
	{
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
		
	}
}