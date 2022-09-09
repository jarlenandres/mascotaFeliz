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
        //Lista de Mascotas
        IEnumerable<Mascota> GetAllMascotas();

        //Agregar Mascota
        Mascota AddMascota(Mascota mascota);

        //Actualizar Mascota
        Mascota UpdateMascota(Mascota mascota);

        //Eliminar Mascota
        void DeleteMascota(int idMascota);

        //Buscar Mascota por id
        Mascota GetMascota(int idMascota);

        //Filtrar Mascota por texto ej: nombre
        IEnumerable<Mascota> GetMascotasPorFiltro(string filtro);
    }
}