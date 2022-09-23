using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    //Interfaz de Historia
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia> GetAllHistorias();
        Historia AddHistoria(Historia historia);
        Historia UpdateHistoria(Historia historia);
        Historia GetHistoria(int idHistoria);
        void DeleteHistoria(int idHistoria);
        //Historia GetVisitasHistoria (int idHistoria);
        //VisitaPyP AsignarVisitaPyP(int idHistoria, int idVisitaPyP);
        
    }
}