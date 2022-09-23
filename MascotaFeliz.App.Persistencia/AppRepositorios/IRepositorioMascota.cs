using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    //Interfaz de Mascota
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
        Veterinario AsignarVeterinario(int idMascota, int idVeterinario);
        Dueno AsignarDueno(int idMascota, int idDueno);
        Historia AsignarHistoria(int idMascota, int idHistoria);

        //Filtrar Mascota por texto ej: nombre
        IEnumerable<Mascota> GetMascotasPorFiltro(string filtro);
    }
}