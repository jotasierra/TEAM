using System.Collections.Generic;
using System.Linq;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia.AppRepositorios
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

        
        Mercancia IRepositorioMercancia.UpdateMercancia(Mercancia mercancia)
        {
            var mercanciaEncontrado = _appContext.Mercancias.FirstOrDefault(m => m.Id == mercancia.Id);
            if (mercanciaEncontrado != null)
            {
                mercanciaEncontrado.mer_alto=mercancia.mer_alto;
                mercanciaEncontrado.mer_largo=mercancia.mer_largo;
                mercanciaEncontrado.mer_ancho=mercancia.mer_ancho;
                mercanciaEncontrado.mer_peso=mercancia.mer_peso;
                mercanciaEncontrado.mer_liquidarTarifa=mercancia.mer_liquidarTarifa;
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