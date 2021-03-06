using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProyectoEnvios.App.Persistencia.AppRepositorios;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Presentacion.Pages
{
    public class InicioModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;

        public IEnumerable<Cliente> Clientes {get; set;}

        [BindProperty]
        public Cliente cliente { get; set; }
        public string buscarCliente;

        public InicioModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        //private readonly ILogger<InicioModel> _logger;

        //public InicioModel(ILogger<InicioModel> logger)
        //{
        //    _logger = logger;
        //}

        public void OnGet()
        {
            Clientes = repositorioCliente.GetAllClientes(buscarCliente);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (cliente.Id > 0)
            {
                cliente = repositorioCliente.UpdateCliente(cliente);
            }
            else
            {
                repositorioCliente.AddCliente(cliente);
            }
            return Page();
        }
    }
}
