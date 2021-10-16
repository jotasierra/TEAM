using System.Collections.Generic;
using System.Linq;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia
{
    public class RepositorioEnviar:IRepositorioEnviar
    {
        private readonly AppContext _appContext;
        public RepositorioEnviar(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Enviar> IRepositorioEnviar.GetAllEnvios()
        {
            return _appContext.Envios;
        }

        Enviar IRepositorioEnviar.AddEnviar(Enviar enviar)
        {
            var enviarAgregado = _appContext.Envios.Add(enviar);
            _appContext.SaveChanges();
            return enviarAgregado.Entity;
        }

        
        Enviar IRepositorioEnviar.UpdateEnviar(Enviar enviar)
        {
            var enviarEncontrado = _appContext.Envios.FirstOrDefault(e => e.Id == enviar.Id);
            if (enviarEncontrado != null)
            {   
                enviarEncontrado.cli_fac_pro_fechaEnvio=enviar.cli_fac_pro_fechaEnvio;                
                enviarEncontrado.cli_fac_pro_origen=enviar.cli_fac_pro_origen;
                enviarEncontrado.cli_fac_pro_destino=enviar.cli_fac_pro_destino;
                enviarEncontrado.cli_fac_pro_fechaEntrega=enviar.cli_fac_pro_fechaEntrega;
                enviarEncontrado.cli_fac_pro_contenido=enviar.cli_fac_pro_contenido;
                enviarEncontrado.cli_fac_pro_remitente=enviar.cli_fac_pro_remitente;
                enviarEncontrado.cli_fac_pro_tipoCliente=enviar.cli_fac_pro_tipoCliente;
                enviarEncontrado.cli_fac_pro_tiempoEnvio=enviar.cli_fac_pro_tiempoEnvio;
                enviarEncontrado.cli_fac_pro_trayecto =enviar.cli_fac_pro_trayecto;
     
                _appContext.SaveChanges();
            }
            return enviarEncontrado;
        }

        
        void IRepositorioEnviar.DeleteEnviar(int idEnviar)
        {
            var enviarEncontrado = _appContext.Envios.FirstOrDefault(e => e.Id == idEnviar);
            if (enviarEncontrado == null)
                return;
            _appContext.Envios.Remove(enviarEncontrado);
            _appContext.SaveChanges();
        }

        
        Enviar IRepositorioEnviar.GetEnviar(int idEnviar)
        {
            return _appContext.Envios.FirstOrDefault(e => e.Id == idEnviar);
        }
    }
}