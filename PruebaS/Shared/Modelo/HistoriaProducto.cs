using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaS.Shared.Modelo
{
    public class HistoriaProducto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(18,0)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public decimal PrecioUnitario { get; set; }
        [Column(TypeName = "Date"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public DateTime fechaRegistro { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
