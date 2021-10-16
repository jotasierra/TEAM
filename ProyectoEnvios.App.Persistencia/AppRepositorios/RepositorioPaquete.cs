using System.Collections.Generic;
using System.Linq;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia
{
    public class RepositorioPaquete : IRepositorioPaquete
    {
        private readonly AppContext _appContext;
        public RepositorioPaquete(AppContext appContext)
        {
            _appContext = appContext;
        }

        
        IEnumerable<Paquete> IRepositorioPaquete.GetAllPaquetes()
        {
            return _appContext.Paquetes;
        }

        
        Paquete IRepositorioPaquete.AddPaquete(Paquete paquete)
        {
            var paqueteAgregado = _appContext.Paquetes.Add(paquete);
            _appContext.SaveChanges();
            return paqueteAgregado.Entity;
        }

        
        Paquete IRepositorioPaquete.UpdatePaquete(Paquete paquete)
        {
            var paqueteEncontrado = _appContext.Paquetes.FirstOrDefault(q => q.Id == paquete.Id);
            if (paqueteEncontrado != null)
            {
                paqueteEncontrado.paq_peso=paquete.paq_peso;
                paqueteEncontrado.paq_liquidarTarifa=paquete.paq_liquidarTarifa;
                paqueteEncontrado.paq_valorDeclarado=paquete.paq_valorDeclarado;

                _appContext.SaveChanges();
            }
            return paqueteEncontrado;
        }

        
        void IRepositorioPaquete.DeletePaquete(int idPaquete)
        {
            var paqueteEncontrado = _appContext.Paquetes.FirstOrDefault(q => q.Id == idPaquete);
            if (paqueteEncontrado == null)
                return;
            _appContext.Paquetes.Remove(paqueteEncontrado);
            _appContext.SaveChanges();
        }

        
        Paquete IRepositorioPaquete.GetPaquete(int idPaquete)
        {
            return _appContext.Paquetes.FirstOrDefault(q => q.Id == idPaquete);
        }
    }
}