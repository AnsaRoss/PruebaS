using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaS.Client.Repositorio
{
    public interface IProveedorRepositorio
    {
        Task<HttpResponseWrapper<T>> GetProveedor<T>(string url);
        Task<HttpResponseWrapper<object>> PostProveedor<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> PutProveedor<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> DeleteProveedor(string url);
    }
}
