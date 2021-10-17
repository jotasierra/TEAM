using System.Collections.Generic;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia.AppRepositorios
{
    public interface IRepositorioFactura   
    {
        IEnumerable<Factura> GetAllFacturas();

        Factura AddFactura(Factura factura);

        Factura UpdateFactura(Factura factura);

        void DeleteFactura(int idFactura);

        Factura GetFactura(int idFactura);

    }
}