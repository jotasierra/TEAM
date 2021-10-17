using System.Collections.Generic;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPaquete  
    {
        IEnumerable<Paquete> GetAllPaquetes();

        Paquete AddPaquete(Paquete paquete);

        Paquete UpdatePaquete(Paquete paquete);

        void DeletePaquete(int idPaquete);

        Paquete GetPaquete(int idPaquete);

    }
}