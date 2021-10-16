﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoEnvios.App.Persistencia;

namespace ProyectoEnvios.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211013132736_Entidades")]
    partial class Entidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProyectoEnvios.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cli_apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_num_documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_tipo_documento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProyectoEnvios.App.Dominio.Enviar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cli_fac_pro_contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_fac_pro_destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_fac_pro_fechaEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_fac_pro_fechaEnvio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_fac_pro_origen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_fac_pro_remitente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_fac_pro_tiempoEnvio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_fac_pro_tipoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_fac_pro_trayecto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("clienteId")
                        .HasColumnType("int");

                    b.Property<int?>("productoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.HasIndex("productoId");

                    b.ToTable("Envios");
                });

            modelBuilder.Entity("ProyectoEnvios.App.Dominio.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("envioId")
                        .HasColumnType("int");

                    b.Property<int>("fac_liquidacion")
                        .HasColumnType("int");

                    b.Property<string>("fac_num_factura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fac_tipo_factura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("funcionarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("envioId");

                    b.HasIndex("funcionarioId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("ProyectoEnvios.App.Dominio.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("fun_apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fun_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ProyectoEnvios.App.Dominio.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pro_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Producto");
                });

            modelBuilder.Entity("ProyectoEnvios.App.Dominio.Mercancia", b =>
                {
                    b.HasBaseType("ProyectoEnvios.App.Dominio.Producto");

                    b.Property<float>("mer_alto")
                        .HasColumnType("real");

                    b.Property<float>("mer_ancho")
                        .HasColumnType("real");

                    b.Property<float>("mer_largo")
                        .HasColumnType("real");

                    b.Property<float>("mer_liquidarTarifa")
                        .HasColumnType("real");

                    b.Property<float>("mer_peso")
                        .HasColumnType("real");

                    b.Property<float>("mer_valorDeclarado")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Mercancia");
                });

            modelBuilder.Entity("ProyectoEnvios.App.Dominio.Paquete", b =>
                {
                    b.HasBaseType("ProyectoEnvios.App.Dominio.Producto");

                    b.Property<float>("paq_liquidarTarifa")
                        .HasColumnType("real");

                    b.Property<float>("paq_peso")
                        .HasColumnType("real");

                    b.Property<float>("paq_valorDeclarado")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Paquete");
                });

            modelBuilder.Entity("ProyectoEnvios.App.Dominio.Enviar", b =>
                {
                    b.HasOne("ProyectoEnvios.App.Dominio.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId");

                    b.HasOne("ProyectoEnvios.App.Dominio.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("productoId");

                    b.Navigation("cliente");

                    b.Navigation("producto");
                });

            modelBuilder.Entity("ProyectoEnvios.App.Dominio.Factura", b =>
                {
                    b.HasOne("ProyectoEnvios.App.Dominio.Enviar", "envio")
                        .WithMany()
                        .HasForeignKey("envioId");

                    b.HasOne("ProyectoEnvios.App.Dominio.Funcionario", "funcionario")
                        .WithMany()
                        .HasForeignKey("funcionarioId");

                    b.Navigation("envio");

                    b.Navigation("funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}