using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicroservicesAnalisisUMG.Models
{
    public class Posit
    {
        [Key]
        public int PositId { get; set; }

        [StringLength(100)]
        public string Titulo { get; set; }
        
        [StringLength(300)]
        public string Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
