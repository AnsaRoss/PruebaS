using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaS.Shared.Modelo
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"),Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(13)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Ruc { get; set; }
        [Column(TypeName = "varchar(100)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Direccion { get; set; }
        [Column(TypeName = "varchar(10)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Telefono { get; set; }
        [Column(TypeName = "varchar(100)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Correo { get; set; }
    }
}
