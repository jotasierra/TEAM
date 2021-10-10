using System;

namespace ProyectoEnvios.App.Dominio.Entidades
{
    public class Paquete : Producto
    {
        //geteamos y seteamos todos los atributos de la clase o tabla
        //ahora se llaman propiedades
        public float paq_peso {get; set;}
        public float paq_liquidarTarifa {get; set;}
        public float paq_valorDeclarado {get; set;}
    }
}