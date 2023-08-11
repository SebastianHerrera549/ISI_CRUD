using System;
using System.Collections.Generic;

namespace ISI_CRUD.Models;

public partial class AnálisisDePrecio
{
    public string NombreDelProducto { get; set; } = null!;

    public decimal? PrecioUnitario { get; set; }

    public decimal? PrecioPromedioDeTodosLosProductos { get; set; }

    public decimal? DiferenciaEntreElPrecioPromedioYElPrecioDelProducto { get; set; }
}
