using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaS.Shared.Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Descripcion { get; set; }
        [Column(TypeName = "varchar(50)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Marca { get; set; }
        [Column(TypeName = "varchar(15)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public string Medida { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(9,2)"), Required(ErrorMessage = "El campo {0} no puede estar vacío")]
        public decimal PrecioUnitario { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
