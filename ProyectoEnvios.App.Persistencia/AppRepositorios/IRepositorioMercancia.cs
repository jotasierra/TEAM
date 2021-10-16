using System.Collections.Generic;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia
{
    public interface IRepositorioMercancia  
    {
        IEnumerable<Mercancia> GetAllMercancias();

        Mercancia AddMercancia(Mercancia mercancia);

        Mercancia UpdateMercancia(Mercancia mercancia);

        void DeleteMercancia(int idMercancia);

        Mercancia GetMercancia(int idMercancia);

    }
}