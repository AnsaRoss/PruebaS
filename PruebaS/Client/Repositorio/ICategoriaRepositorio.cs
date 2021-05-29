using PruebaS.Shared.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaS.Client.Repositorio
{
    public interface ICategoriaRepositorio
    {
        //Task<IEnumerable<Categoria>> GetCategorias();
        Task<HttpResponseWrapper<T>> GetCategoria<T>(string url);
        Task<HttpResponseWrapper<object>> PostCategoria<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> PutCategoria<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> DeleteCategoria(string url);
    }
}
