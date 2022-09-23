using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class DeleteVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVererinario;
        [BindProperty]

        public Veterinario veterinario {get; set;}

        public DeleteVeterinarioModel()
        {
            this._repoVererinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }

        public IActionResult OnGet(int? idVeterinario)
        {
            if (idVeterinario.HasValue)
            {
                veterinario = _repoVererinario.GetVeterinario(idVeterinario.Value);
            }
            if (veterinario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (veterinario.Id > 0)
            {
                _repoVererinario.DeleteVeterinario(veterinario.Id);
            }
            else
            {
                _repoVererinario.AddVeterinario(veterinario);
            }
            return Page();
        }
    }
}
