using System;

namespace ProyectoEnvios.App.Dominio.Entidades
{
    public class Enviar
    {
        //geteamos y seteamos todos los atributos de la clase o tabla
        //ahora se llaman propiedades
        public Producto producto {get; set;}
        public Cliente cliente {get; set;}
        public int Id {get; set;}
        public string cli_fac_pro_fechaEnvio {get; set;}
        public string cli_fac_pro_origen {get; set;}
        public string cli_fac_pro_destino {get; set;}
        public string cli_fac_pro_fechaEntrega {get; set;}
        public string cli_fac_pro_contenido {get; set; }
        public string cli_fac_pro_remitente {get; set;}
        public string cli_fac_pro_tipoCliente {get; set;}
        public string cli_fac_pro_tiempoEnvio {get; set;}
        public string cli_fac_pro_trayecto {get; set;}
    } 
}