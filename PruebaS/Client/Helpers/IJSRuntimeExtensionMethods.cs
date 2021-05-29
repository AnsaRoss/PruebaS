using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaS.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async Task<bool> Confirm(this IJSRuntime js, string titulo, string mensaje, TipoMensajeSweetAlert tipoMensajeSweetAlert)
        {
            return await js.InvokeAsync<bool>("CustomConfirm",titulo,mensaje, tipoMensajeSweetAlert.ToString());
        }
        public static ValueTask Respuesta(this IJSRuntime js, string titulo, string mensaje, TipoMensajeSweetAlert tipoMensajeSweetAlert)
        {
            return js.InvokeVoidAsync("Swal.fire",titulo,mensaje,tipoMensajeSweetAlert.ToString());
        }


    }
    public enum TipoMensajeSweetAlert
    {
        question, warning, error, success, info
    }
}
