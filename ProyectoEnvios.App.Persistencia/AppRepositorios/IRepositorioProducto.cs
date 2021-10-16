using System.Collections.Generic;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia
{
    public interface IRepositorioProducto   
    {
        IEnumerable<Producto> GetAllProductos();

        Producto AddProducto(Producto producto);

        Producto UpdateProducto(Producto producto);

        void DeleteProducto(int idProducto);

        Producto GetProducto(int idProducto);

    }
}