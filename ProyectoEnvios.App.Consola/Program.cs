using System;
using ProyectoEnvios.App.Dominio;
using ProyectoEnvios.App.Persistencia;
using ProyectoEnvios.App.Persistencia.AppRepositorios;

namespace ProyectoEnvios.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repositorioCliente = new RepositorioCliente(new Persistencia.AppRepositorios.AppContext());
        //private static IRepositorioFuncionario _repositorioFuncionario = new RepositorioFuncionario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Cliente... ");
            //AddCliente();
            DeleteCliente(8);
            //AddFuncionario();
            //GetCliente(2);
        }

        private static void AddFuncionario()
        {
            var funcionario = new Funcionario
            {
                fun_nombre = "[TEST]Javier",
                fun_apellidos = "[TEST]Testing"
            };
            //_repositorioFuncionario.AddFuncionario(funcionario);
        }

        private static void GetCliente(int idCliente)
        {
            var cliente = _repositorioCliente.GetCliente(idCliente);
            Console.WriteLine("Consultando cliente... " + cliente.cli_nombre);
        }

        private static void AddCliente()
        {
            var cliente = new Cliente
            {
                cli_tipo_documento = "Cédula de Ciudadania",
                cli_num_documento = "1111111111",
                cli_nombre = "[TEST]Laura",
                cli_apellidos = "[TEST]Avendaño",
                cli_direccion = "[TEST]CL X N Y - Z",
                cli_telefono = "2222222222",
                cli_email = "[TEST]laura.aven@test.com"
            };
            _repositorioCliente.AddCliente(cliente);
        }

        private static void DeleteCliente(int idCliente)
        {
            _repositorioCliente.DeleteCliente(idCliente);
            Console.WriteLine("Cliente eliminado correctamente");
        }
    }
}
