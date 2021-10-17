using System.Collections.Generic;
using System.Linq;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia.AppRepositorios
{
    public class RepositorioFactura : IRepositorioFactura   
    {
        private readonly AppContext _appContext;
        public RepositorioFactura(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Factura> IRepositorioFactura.GetAllFacturas()
        {
            return _appContext.Facturas;
        }

        
        Factura IRepositorioFactura.AddFactura(Factura factura)
        {
            var facturaAgregado = _appContext.Facturas.Add(factura);
            _appContext.SaveChanges();
            return facturaAgregado.Entity;
        }

        
        Factura IRepositorioFactura.UpdateFactura(Factura factura)
        
        {
            var facturaEncontrado = _appContext.Facturas.FirstOrDefault(f => f.Id == factura.Id);
            if (facturaEncontrado != null)
            {
                facturaEncontrado.fac_num_factura=factura.fac_num_factura;
                facturaEncontrado.fac_liquidacion=factura.fac_liquidacion;
                facturaEncontrado.fac_tipo_factura=factura.fac_tipo_factura;
                
                _appContext.SaveChanges();
            }
            return facturaEncontrado;
        }

        
        void IRepositorioFactura.DeleteFactura(int idFactura)
        {
            var facturaEncontrado = _appContext.Facturas.FirstOrDefault(t => t.Id == idFactura);
            if (facturaEncontrado == null)
                return;
            _appContext.Facturas.Remove(facturaEncontrado);
            _appContext.SaveChanges();
        }

        Factura IRepositorioFactura.GetFactura(int idFactura)
        {
            return _appContext.Facturas.FirstOrDefault(t => t.Id == idFactura);
        }
    }
}