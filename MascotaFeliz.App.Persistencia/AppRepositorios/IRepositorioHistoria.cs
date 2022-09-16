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
        Historia AddHistoria(Historia Historia);
    }
}