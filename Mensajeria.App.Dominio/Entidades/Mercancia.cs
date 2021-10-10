using System;

namespace ProyectoEnvios.App.Dominio.Entidades
{
    public class Mercancia:Producto
    {
        //geteamos y seteamos todos los atributos de la clase o tabla
        //ahora se llaman propiedades
        public float mer_alto {get; set;}
        public float mer_largo {get; set;}
        public float mer_ancho {get; set;}
        public float mer_peso {get; set;}
        public float mer_liquidarTarifa {get; set;}
        public float mer_valorDeclarado {get; set;}
    }
}