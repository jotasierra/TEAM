using System.Collections.Generic;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia
{
    public interface IRepositorioEnviar

    {
        
         IEnumerable<Enviar> GetAllEnvios();

         Enviar AddEnviar(Enviar enviar);

         Enviar UpdateEnviar(Enviar enviar);

         void DeleteEnviar(int idEnviar);

        Enviar GetEnviar(int idEnviar);

    }
}