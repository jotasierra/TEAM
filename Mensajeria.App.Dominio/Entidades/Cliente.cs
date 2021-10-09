using System;

namespace Mensajeria.App.Dominio
{
    public class Cliente
    {
        //geteamos y seteamos todos los atributos de la clase o tabla
        //ahora se llaman propiedades
        public int cli_id {get; set;}
        public string cli_tipo_documento {get; set;}
        public string cli_num_documento {get; set;}
        public string cli_nombre {get; set;}
        public string cli_apellidos {get; set;}
        public string cli_direccion {get; set;}
        public string cli_telefono {get; set;}
        public string cli_email {get; set;}
    }
}