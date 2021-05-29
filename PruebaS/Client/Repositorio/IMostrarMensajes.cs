using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaS.Client.Repositorio
{
    interface IMostrarMensajes
    {
        Task MostrarMensajeError(string mensaje);
    }
}
