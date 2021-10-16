﻿using System;
using ProyectoEnvios.App.Dominio;
using ProyectoEnvios.App.Persistencia;

namespace ProyectoEnvios.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repositorioCliente = new RepositorioCliente(new Persistencia.AppContext());
        private static IRepositorioFuncionario _repositorioFuncionario = new RepositorioFuncionario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Agregando funcionario [TESTING]...");
            //AddCliente();
            //DeleteCliente(1);
            AddFuncionario();
        }

        private static void AddFuncionario()
        {
            var funcionario = new Funcionario
            {
                fun_nombre = "[TEST]Javier",
                fun_apellidos = "[TEST]Testing"
            };
            _repositorioFuncionario.AddFuncionario(funcionario);
        }

        private static void AddCliente()
        {
            var cliente = new Cliente
            {
                cli_tipo_documento = "Pasaporte",
                cli_num_documento = "1234567891",
                cli_nombre = "[TEST]Nombre",
                cli_apellidos = "[TEST]Apellido",
                cli_direccion = "[TEST]CL 10 N 5 - 2.5",
                cli_telefono = "1987654321",
                cli_email = "[TEST]nombre.apellido@test.com"
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
