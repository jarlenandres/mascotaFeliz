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
    public class EditarMascotaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;
        [BindProperty]
        public Mascota mascota { get; set; }
        public Veterinario veterinario { get; set; }
        public Dueno dueno { get; set; }
        public IEnumerable<Dueno> listaDuenos { get; set; }
        public IEnumerable<Veterinario> listaVeterinarios { get; set; }

        public EditarMascotaModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }

        public void OnGet(int? idMascota)
        {
            listaDuenos = _repoDueno.GetAllDuenos();
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();

            if (idMascota.HasValue)
            {
                mascota = _repoMascota.GetMascota(idMascota.Value);
            }
            else 
            {
                mascota = new Mascota();
            }
            if (mascota == null)
            {
                RedirectToPage("./NotFound");
            }
                Page();
            
        }

        public IActionResult OnPost(Mascota mascota, int idDueno, int idVeterinario)
        {
            if (ModelState.IsValid)
            {
                dueno = _repoDueno.GetDueno(idDueno);
                veterinario = _repoVeterinario.GetVeterinario(idVeterinario);

                if (mascota.Id > 0)
                {
                    
                    _repoMascota.AsignarDueno(mascota.Id,dueno.Id);
                    _repoMascota.AsignarVeterinario(mascota.Id,veterinario.Id);
                }
                else
                {                  
                    mascota = _repoMascota.AddMascota(mascota);  
                    mascota.Veterinario = veterinario;
                    mascota.Dueno = dueno;
                    mascota = _repoMascota.UpdateMascota(mascota);
                }
                return RedirectToPage("/Mascotas/ListaMascotas");

            }
            else
            {
               return Page();
            }
        }
    }
}