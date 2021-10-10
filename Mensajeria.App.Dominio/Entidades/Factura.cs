using System;

namespace ProyectoEnvios.App.Dominio.Entidades
{
    public class Factura
    {
        //geteamos y seteamos todos los atributos de la clase o tabla
        //ahora se llaman propiedades
        public Enviar envio {get; set;}
        public int Id {get; set;}
        public string fac_num_factura {get; set;}
        public int fac_liquidacion {get; set;}
        public string fac_tipo_factura {get; set;}
        public Funcionario funcionario {get; set;}
    }
}