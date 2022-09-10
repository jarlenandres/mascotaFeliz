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

            //AddDueno();
            //BuscarDueno(1);
            //ListarDuenos();

            //AddMascota();
            //BuscarMascota(1);
            //ListarMascotas();

            //AddVeterinario();
            //BuscarVeterinario(2);
            //ListarVeterinarios();
            
        }

        //Agregar Dueño
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "El",
                Apellidos = "profe",
                Direccion = "Barranquilla",
                Telefono = "02312230",
                Correo = "elprofe@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        //Buscar Dueño
        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " "+ dueno.Apellidos);
        }

        //Listar Dueños
        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres);
            }
        }

        //Agregar Mascota
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Misi",
                Color = "negro",
                Especie = "lindo",
                Raza = "Persa",
            };
            _repoMascota.AddMascota(mascota);
        }

        //Buscar Mascota
        private static void BuscarMascota(int idMascota)
        {
            var mascota =  _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " "+ mascota.Raza);
        }

        //Listar Mascota
        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre);
            }
        }

        //Agregar Veterinario
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Javier",
                Apellidos = "Vasquez",
                Direccion = "Colombia",
                Telefono = "33333333",
                TerjetaProfesional = "002334"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        //Buscar Veterinario
        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario =  _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " "+ veterinario.TerjetaProfesional);
        }

        //Listar Veterinario
        private static void ListarVeterinarios()
        {
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario v in veterinarios)
            {
                Console.WriteLine(v.Nombres);
            }
        }

        

        

        
    }
}


