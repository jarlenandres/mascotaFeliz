using System; // importacion de paquetes
namespace MascotaFeliz.App.Dominio // nombre del paquete y atributos de clase
{
    public class Persona
    {
        public int Id {get;set;} // {} propiedad que encapsula el atributo de la clase
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
    }
}