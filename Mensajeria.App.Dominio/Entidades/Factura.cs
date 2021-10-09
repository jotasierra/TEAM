using System;

namespace Mensajeria.App.Dominio
{
    public class Factura
    {
        //geteamos y seteamos todos los atributos de la clase o tabla
        //ahora se llaman propiedades
        public int fac_id {get; set;}
        public string fac_num_factura {get; set;}
        public int fac_liquidacion {get; set;}
        public string fac_tipo_factura {get; set;}
    }
}