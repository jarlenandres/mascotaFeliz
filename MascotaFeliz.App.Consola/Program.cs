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
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddDueno();
            //BuscarDueno(1);
            //ListarDuenos();
            //EliminarDueno(1);
            //ListarDuenoFiltro();
            //EditarDueno(3);
            
            //AddMascota();
            //BuscarMascota(1);
            //ListarMascotas();
            //EliminarMascota(1);
            //ListarMascotaFiltro();
            //EditarMascota(2);
            //AsignarVeterinario();
            //AsignarDueno();
            //AsignarHistoria();

            //AddVeterinario();
            //BuscarVeterinario(2);
            //ListarVeterinarios();
            //EliminarVeterinario(2);
            //ListarVeterinarioFiltro();
            //EditarVeterinario(6);

            //AddHistoria();
            //AsignarVisitaPyP();
            AsignarVisitaPyPF(2);

            //AddVisitaPyP();
            //BuscarVisitaPyP(1);
            //ListarVisitaPyP();
            //EliminarVisitaPyP(1);
            //EditarVisitaPyP(1);
            
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

        //Editar Dueño
        private static void EditarDueno(int idDueno)
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
        //Editar Mascota
        private static void EditarMascota(int idMascota)
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
        //Asignar Veterinario a la Mascota
        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(3,6);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        //Asignar Dueno a la Mascota
        private static void AsignarDueno()
        {
            var dueno = _repoMascota.AsignarDueno(3,5);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }

        //Asignar Historia a la Mascota
        private static void AsignarHistoria()
        {
            var historia = _repoMascota.AsignarHistoria(3,1);
            Console.WriteLine(historia.FechaInicial);
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
                TarjetaProfesional = "002334"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        //Buscar Veterinario
        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario =  _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres +" "+ veterinario.TarjetaProfesional);
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
        //Editar Veterinario
        private static void EditarVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _repoVeterinario.GetVeterinario(idVeterinario);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Nombres = "Diego";
                veterinarioEncontrado.Apellidos = "Amalla";
                veterinarioEncontrado.Direccion = "en las nubes";
                veterinarioEncontrado.Telefono = "5555555";
                veterinarioEncontrado.TarjetaProfesional = "GHY779";
            }
            _repoVeterinario.UpdateVeterinario(veterinarioEncontrado);
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

        //Asignar VisitaPyP a la Histora
        /*
        private static void AsignarVisitaPyP()
        {
            var visitaPyP = _repoHistoria.AsignarVisitaPyP(1,2);
            Console.WriteLine(visitaPyP.Temperatura);
        }
        */

        private static void AsignarVisitaPyPF(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if(historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP {FechaVisita = new DateTime (2022, 09, 22), Temperatura = 40.2F, Peso = 20.3F,FrecuenciaRespiratoria = 55.2F,FrecuenciaCardiaca = 10.5F,EstadoAnimo ="Euforico",Recomendaciones ="Reposo en casa",});
                }
                else
                {
                    historia.VisitasPyP = new List <VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime (2000, 01, 15), Temperatura = 25.2F, Peso = 21.3F,FrecuenciaRespiratoria = 33.2F,FrecuenciaCardiaca = 88.5F,EstadoAnimo ="Trise",Recomendaciones ="Reposo Total",}
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
        }



        
        //Agregar VisitaPyP
        private static void AddVisitaPyP()
        {
            var visitaPyP = new VisitaPyP

            {
                FechaVisita = new DateTime(2022,09,15),
                Temperatura = 37.2F,
                Peso = 55.3F,
                FrecuenciaRespiratoria = 33.2F,
                FrecuenciaCardiaca = 80.5F,
                EstadoAnimo ="Alegre",
                Recomendaciones ="Reposo en casa",

            };
            _repoVisitaPyP.AddVisitaPyP(visitaPyP);
        }

        //Buscar VisitaPyP
        private static void BuscarVisitaPyP(int idVisitaPyP)
        {
            var visitaPyP = _repoVisitaPyP.GetVisitaPyP(idVisitaPyP);
            Console.WriteLine(visitaPyP.Id +" "+ visitaPyP.FechaVisita);
        }

        //Listar VisitaPyP
        private static void ListarVisitaPyP()
        {
            var visitaPyP = _repoVisitaPyP.GetAllVisitasPyP();
            foreach (VisitaPyP v in visitaPyP)
            {
                Console.WriteLine(v.FechaVisita);
            }
        }

         //Eliminar VisitaPyP
        private static void EliminarVisitaPyP(int idVisitaPyP)
        {
            _repoVisitaPyP.DeleteVisitaPyP(idVisitaPyP);
            Console.WriteLine("VisitaPyP eliminada");
        }

        //Editar VisitaPyP
        private static void EditarVisitaPyP(int idVisitaPyP)
        {
            var visitaPyPEncontrado = _repoVisitaPyP.GetVisitaPyP(idVisitaPyP);
            if (visitaPyPEncontrado != null)
            {
                visitaPyPEncontrado.FechaVisita = new DateTime(2022,09,16);
                visitaPyPEncontrado.Temperatura = 20.5F;
                visitaPyPEncontrado.Peso = 30.3F;
                visitaPyPEncontrado.FrecuenciaRespiratoria = 50.2F;
                visitaPyPEncontrado.FrecuenciaCardiaca = 15.5F;
                visitaPyPEncontrado.EstadoAnimo= "Triste";
                visitaPyPEncontrado.Recomendaciones= "Vacaciones";
            }
            _repoVisitaPyP.UpdateVisitaPyP(visitaPyPEncontrado);
        }
    }
}




