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

        //Filtrar Mascota por texto ej: nombre
        IEnumerable<Mascota> GetMascotasPorFiltro(string filtro);
    }
}