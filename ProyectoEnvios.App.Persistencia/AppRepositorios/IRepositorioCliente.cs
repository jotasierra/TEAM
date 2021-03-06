using System.Collections.Generic;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia.AppRepositorios
{
    public interface IRepositorioCliente
    {
         //Método para obtener TODOS los clientes
         IEnumerable<Cliente> GetAllClientes(string? nombreCliente);

         //Método para agregar un nuevo cliente
         Cliente AddCliente(Cliente cliente);

         //Método para actualizar un cliente existente
         Cliente UpdateCliente(Cliente cliente);

         //Método para eliminar un cliente
         void DeleteCliente(int idCliente);

         //Método para obtener 1 cliente específico
         Cliente GetCliente(int? idCliente);

    }
}