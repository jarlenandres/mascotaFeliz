using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    //Interfaz de dueño
    public interface IRepositorioDueno
    {
        //Lista de dueños
        IEnumerable<Dueno> GetAllDuenos();

        //Agregar dueños
        Dueno AddDueno(Dueno dueno);

        //Actualizar dueños
        Dueno UpdateDueno(Dueno dueno);

        //Eliminar dueños
        void DeleteDueno(int idDueno);

        //Buscar un dueño por id
        Dueno GetDueno(int idDueno);

        //Filtrar dueños por texto ej: nombre
        IEnumerable<Dueno> GetDuenosPorFiltro(string filtro);
    }
}