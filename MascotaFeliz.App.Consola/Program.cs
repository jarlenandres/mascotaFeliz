using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    { 
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Agregar Dueño
            //AddDueno();

            //Buscar Dueño
            //BuscarDueno(1);

            //Agregar Mascota
            //AddMascota();

            //Buscar Dueño
            //BuscarMascota(1);

            //Agregar Veterinario
            //AddVeterinario();

            //Buscar Veterinario
            BuscarVeterinario(2);
        }

        //Agregar Dueño
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        //Buscar Dueño
        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " "+ dueno.Apellidos);
        }

        //Agregar Mascota
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Firulay",
                Color = "Blanco",
                Especie = "Golden",
                Raza = "Labrador",
            };
            _repoMascota.AddMascota(mascota);
        }

        //Buscar Mascota
        private static void BuscarMascota(int idMascota)
        {
            var mascota =  _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " "+ mascota.Raza);
        }

        //Agregar Veterinario
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Carlos",
                Apellidos = "Moreno",
                Direccion = "de bajo del río",
                Telefono = "09080907",
                TerjetaProfesional = "2130459"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        //Buscar Mascota
        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario =  _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " "+ veterinario.TerjetaProfesional);
        }
    }
}


