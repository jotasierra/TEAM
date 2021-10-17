using System.Collections.Generic;
using System.Linq;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia.AppRepositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {

        public IEnumerable<Cliente> clientes {get; set;} 
        private readonly AppContext _appContext;
        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Implementa método "GetAllClientes" de IRepositorioCliente
        IEnumerable<Cliente> IRepositorioCliente.GetAllClientes(string? nombreCliente)
        {
            if (nombreCliente != null) {
              clientes = _appContext.Clientes.Where(c => c.cli_nombre.Contains(nombreCliente));
            }
            else 
               clientes = _appContext.Clientes;
            return clientes;
        }

        //Implementa método "AddCliente" de IRepositorioCliente
        Cliente IRepositorioCliente.AddCliente(Cliente cliente)
        {
            var clienteAgregado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAgregado.Entity;
        }

        //Implementa método "UpdateCliente" de IRepositorioCliente
        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.cli_tipo_documento = cliente.cli_tipo_documento;
                clienteEncontrado.cli_num_documento = cliente.cli_num_documento;
                clienteEncontrado.cli_nombre = cliente.cli_nombre;
                clienteEncontrado.cli_apellidos = cliente.cli_apellidos;
                clienteEncontrado.cli_direccion = cliente.cli_direccion;
                clienteEncontrado.cli_telefono = cliente.cli_telefono;
                clienteEncontrado.cli_email = cliente.cli_email;

                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }

        //Implementa método "DeleteCliente" de IRepositorioCliente
        void IRepositorioCliente.DeleteCliente(int idCliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
            if (clienteEncontrado == null)
                return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        //Implementa método "GetCliente" de IRepositorioCliente
        Cliente IRepositorioCliente.GetCliente(int? idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
        }
    }
}