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
        //Lista de Mascotas
        IEnumerable<Veterinario> GetAllVeterinarios();

        //Agregar Veterinario
        Veterinario AddVeterinario(Veterinario veterinario);

        //Actualizar Veterinario
        Veterinario UpdateVeterinario(Veterinario veterinario);

        //Eliminar Veterinario
        void DeleteVeterinario(int idVeterinario);

        //Buscar Veterinario por id
        Veterinario GetVeterinario(int idVeterinario);

        //Filtrar Veterinario por texto ej: nombre
        IEnumerable<Veterinario> GetVeterinariosPorFiltro(string filtro);
    }
}