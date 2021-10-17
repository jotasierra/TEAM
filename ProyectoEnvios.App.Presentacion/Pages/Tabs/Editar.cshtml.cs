using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ProyectoEnvios.App.Dominio;
using ProyectoEnvios.App.Persistencia.AppRepositorios;

namespace ProyectoEnvios.App.Presentacion.Pages
{
    public class EditarModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;

        [BindProperty]
        public Cliente cliente { get; set; }

        public EditarModel()
        {
            this.repositorioCliente = new RepositorioCliente(new ProyectoEnvios.App.Persistencia.AppRepositorios.AppContext());
        }

        public IActionResult OnGet(int? idCliente)
        {
            if (idCliente.HasValue)
            {
                cliente = repositorioCliente.GetCliente(idCliente.Value);
            }
            else
            {
                cliente = new Cliente();
            }
            if (cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

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

