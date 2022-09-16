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
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddDueno();
            //BuscarDueno(1);
            //ListarDuenos();
            //EliminarDueno(1);
            //ListarDuenoFiltro();
            //ActualizarDueno(3);

            
            //AddMascota();
            //BuscarMascota(1);
            //ListarMascotas();
            //EliminarMascota(1);
            //ListarMascotaFiltro();
            //ActualizarMascota(2);

            //AddVeterinario();
            //BuscarVeterinario(2);
            //ListarVeterinarios();
            //EliminarVeterinario(2);
            //ListarVeterinarioFiltro();
            //ActualizarVeterinario(6);

            //AddHistoria();
            
        }

        //Agregar Historia
        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2020,09,16)
            };
            _repoHistoria.AddHistoria(historia);
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
            Console.WriteLine(dueno.Nombres +" "+ dueno.Apellidos);
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

        //Eliminar Dueño
        private static void EliminarDueno(int idDueno)
        {
            _repoDueno.DeleteDueno(idDueno);
            Console.WriteLine("Dieño eliminado");
        }

        //Filtar Dueño por texto
        private static void ListarDuenoFiltro()
        {
            var duenos = _repoDueno.GetDuenosPorFiltro("El");
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres +" "+ d.Apellidos);
            }
        }

        //Actualizar Dueño
        private static void ActualizarDueno(int idDueno)
        {
            var duenoEncontrado = _repoDueno.GetDueno(idDueno);
            if (duenoEncontrado != null)
            {
                duenoEncontrado.Nombres = "Pedro";
                duenoEncontrado.Apellidos = "El escamoso";
                duenoEncontrado.Direccion = "Cl Z # Z - Z";
                duenoEncontrado.Telefono = "5555555558";
                duenoEncontrado.Correo = "Pedro@gmail.com";
            }
            _repoDueno.UpdateDueno(duenoEncontrado);
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

        //Eliminar Mascota
        private static void EliminarMascota(int idMascota)
        {
            _repoMascota.DeleteMascota(idMascota);
            Console.WriteLine("Mascota eliminada");
        }

        //Filtrar Mascota por texto
        private static void ListarMascotaFiltro()
        {
            var mascotas = _repoMascota.GetMascotasPorFiltro("Misi");
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre);
            }
        }
        //Actualizar Mascota
        private static void ActualizarMascota(int idMascota)
        {
            var mascotaEncontrado = _repoMascota.GetMascota(idMascota);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = "Pepito";
                mascotaEncontrado.Color = "Azul";
                mascotaEncontrado.Especie = "pez";
                mascotaEncontrado.Raza = "Pez Dorado";
            }
            _repoMascota.UpdateMascota(mascotaEncontrado);
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
            Console.WriteLine(veterinario.Nombres +" "+ veterinario.TerjetaProfesional);
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

        //Eliminar Veterinario
        private static void EliminarVeterinario(int idVeterinario)
        {
            _repoVeterinario.DeleteVeterinario(idVeterinario);
            Console.WriteLine("Veterinario elminado");
        }

        //Filtrar Veterinario por texto
        private static void ListarVeterinarioFiltro()
        {
            var veterinarios = _repoVeterinario.GetVeterinariosPorFiltro("Javier");
            foreach (Veterinario v in veterinarios)
            {
                Console.WriteLine(v.Nombres +" "+ v.Apellidos);
            }
        }
        //Actualizar Veterinario
        private static void ActualizarVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _repoVeterinario.GetVeterinario(idVeterinario);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Nombres = "Diego";
                veterinarioEncontrado.Apellidos = "Amalla";
                veterinarioEncontrado.Direccion = "en las nubes";
                veterinarioEncontrado.Telefono = "5555555";
                veterinarioEncontrado.TerjetaProfesional = "GHY779";
            }
            _repoVeterinario.UpdateVeterinario(veterinarioEncontrado);
        }

    }
}


