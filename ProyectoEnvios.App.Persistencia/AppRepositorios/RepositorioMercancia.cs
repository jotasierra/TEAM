using System.Collections.Generic;
using System.Linq;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia
{
    public class RepositorioMercancia : IRepositorioMercancia   
    {
        private readonly AppContext _appContext;
        public RepositorioMercancia(AppContext appContext)
        {
            _appContext = appContext;
        }

        
        IEnumerable<Mercancia> IRepositorioMercancia.GetAllMercancias()
        {
            return _appContext.Mercancias;
        }

        
        Mercancia IRepositorioMercancia.AddMercancia(Mercancia mercancia)
        {
            var mercanciaAgregado = _appContext.Mercancias.Add(mercancia);
            _appContext.SaveChanges();
            return mercanciaAgregado.Entity;
        }

        
        Mercancia IRepositorioMercancia.UpdateMercancia(Mercancia cercancia)
        {
            var mercanciaEncontrado = _appContext.Mercancias.FirstOrDefault(m => m.Id == mercancia.Id);
            if (mercanciaEncontrado != null)
            {
                mercancia.Encontrado.mer_alto=mercancia.mer_alto;
                mercancia.Encontrado.mer_largo=mercancia.mer_largo;
                mercancia.Encontrado.mer_ancho=mercancia.mer_ancho;
                mercancia.Encontrado.mer_peso=mercancia.mer_peso;
                mercancia.Encontrado.mer_liquidarTarifa=mercancia.mer_liquidarTarifa;
                mercanciaEncontrado.mer_valorDeclarado=mercancia.mer_valorDeclarado;

                _appContext.SaveChanges();
            }
            return mercanciaEncontrado;
        }

        
        void IRepositorioMercancia.DeleteMercancia(int idMercancia)
        {
            var mercanciaEncontrado = _appContext.Mercancias.FirstOrDefault(m => m.Id == idMercancia);
            if (mercanciaEncontrado == null)
                return;
            _appContext.Mercancias.Remove(mercanciaEncontrado);
            _appContext.SaveChanges();
        }

        
        Mercancia IRepositorioMercancia.GetMercancia(int idMercancia)
        {
            return _appContext.Mercancias.FirstOrDefault(m => m.Id == idMercancia);
        }
    }
}