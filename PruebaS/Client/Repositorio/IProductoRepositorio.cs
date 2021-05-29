using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaS.Client.Repositorio
{
    public interface IProductoRepositorio
    {
        Task<HttpResponseWrapper<T>> GetProducto<T>(string url);
        Task<HttpResponseWrapper<object>> PostProducto<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> PutProducto<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> DeleteProducto(string url);
    }
}
