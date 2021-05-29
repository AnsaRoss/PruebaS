using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaS.Shared.Modelo
{
    public class Categoria
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"),Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Nombre { get; set; }
        
    }
}
