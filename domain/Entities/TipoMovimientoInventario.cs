using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain.Entities;
public class TipoMovimientoInventario : BaseEntity
{
    public string Nombre { get; set; }
    public ICollection<MovimientoInventario> MovimientoInventarios { get; set; }
}