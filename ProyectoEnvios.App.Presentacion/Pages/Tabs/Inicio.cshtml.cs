using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ProyectoEnvios.App.Presentacion.Pages
{
    public class InicioModel : PageModel
    {
        private readonly ILogger<InicioModel> _logger;

        public InicioModel(ILogger<InicioModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
