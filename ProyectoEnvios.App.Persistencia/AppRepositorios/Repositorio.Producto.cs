using System.Collections.Generic;
using System.Linq;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia
{
    public class RepositorioProducto : IRepositorioProducto  
    {
        private readonly AppContext _appContext;
        public RepositorioProducto(AppContext appContext)
        {
            _appContext = appContext;
        }

        
        IEnumerable<Producto> IRepositorioProducto.GetAllProductos()
        {
            return _appContext.Productos;
        }

        
        Producto IRepositorioProducto.AddProducto(Producto producto)
        {
            var productoAgregado = _appContext.Productos.Add(producto);
            _appContext.SaveChanges();
            return productoAgregado.Entity;
        }

        
        Producto IRepositorioProducto.UpdateProducto(Producto producto)
        {
            var productoEncontrado = _appContext.Productos.FirstOrDefault(d => d.Id == producto.Id);
            if (productoEncontrado != null)
            {
                producto.Encontrado.pro_nombre=producto.pro_nombre;
                _appContext.SaveChanges();
            }
            return productoEncontrado;
        }

        
        void IRepositorioProducto.DeleteProducto(int idProducto)
        {
            var productoEncontrado = _appContext.Productos.FirstOrDefault(d => d.Id == idProducto);
            if (productoEncontrado == null)
                return;
            _appContext.Productos.Remove(productoEncontrado);
            _appContext.SaveChanges();
        }

        
        Producto IRepositorioProducto.GetProducto(int idProducto)
        {
            return _appContext.Productos.FirstOrDefault(d => d.Id == idProducto);
        }
    }
}