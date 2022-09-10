using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    //Interfaz de Mascota
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios();

        Veterinario AddVeterinario(Veterinario veterinario);

        Veterinario UpdateVeterinario(Veterinario veterinario);

        void DeleteVeterinario(int idVeterinario);

        Veterinario GetVeterinario(int idVeterinario);

        //Filtrar Veterinario por texto ej: nombre
        IEnumerable<Veterinario> GetVeterinariosPorFiltro(string filtro);
    }
}