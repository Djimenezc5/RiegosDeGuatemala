﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RiegosDeGuatemala;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    [DbContext(typeof(RGContext))]
    [Migration("20221030192930_TipoSensor")]
    partial class TipoSensor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sectores.HistoricoSectores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_HISTORICO_SECTOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdSector")
                        .HasColumnType("int")
                        .HasColumnName("ID_SECTOR");

                    b.Property<int>("cantidadAgua")
                        .HasColumnType("int")
                        .HasColumnName("CANTIDAD_AGUA");

                    b.Property<bool>("reigoActivo")
                        .HasColumnType("bit")
                        .HasColumnName("ESTADO_RIEGO");

                    b.Property<int>("tiempoRiego")
                        .HasColumnType("int")
                        .HasColumnName("TIEMPO_RIEGO");

                    b.Property<DateTime>("ultimoAccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ULTIMA_ACCION");

                    b.HasKey("Id");

                    b.ToTable("RG_HISTORICO_SECTOR");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sectores.sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_SECTOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("ESTADO");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMBRE_SECTOR");

                    b.Property<int>("UsuarioCreacion")
                        .HasColumnType("int")
                        .HasColumnName("USUARIO_CREACION");

                    b.Property<string>("descripcionSector")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPCION_SECTOR");

                    b.Property<DateTime>("fechaCreacionToken")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_CREACION");

                    b.Property<decimal>("humedadMaxima")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("HUMEDAD _MAXIMA");

                    b.Property<decimal>("humedadMinima")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("HUMEDAD _MINIMA");

                    b.Property<bool>("reigoActivo")
                        .HasColumnType("bit")
                        .HasColumnName("RIEGO_ACTIVO");

                    b.Property<int>("tiempoMaximoRiego")
                        .HasColumnType("int")
                        .HasColumnName("TIEMPO_MAXIMA");

                    b.Property<DateTime>("ultimoRiego")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ULTIMO_RIEGO");

                    b.HasKey("Id");

                    b.ToTable("RG_SECTOR");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sensores.TipoSensor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_SENSOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<bool>("estadoSensor")
                        .HasColumnType("bit")
                        .HasColumnName("ESTADO_SENSOR");

                    b.Property<string>("nombreTipoSensor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMBRE_TIPO_SENSOR");

                    b.HasKey("id");

                    b.ToTable("RG_TIPO_SENSOR");

                    b.HasData(
                        new
                        {
                            id = 1,
                            estadoSensor = true,
                            nombreTipoSensor = "Sensor humedad"
                        },
                        new
                        {
                            id = 2,
                            estadoSensor = true,
                            nombreTipoSensor = "Sensor luminosidad"
                        });
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.Usuario.TokenUsuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO_TOKEN");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("fechaCreacionToken")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_CREACION_TOKEN");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO");

                    b.Property<Guid>("token")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TOKEN");

                    b.HasKey("id");

                    b.ToTable("RG_USUARIO_TOKEN");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.Usuario.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CONTRASENIA");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("ESTADO");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMBRE");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EMAIL");

                    b.Property<DateTime>("fechaCreacionToken")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_CREACION_USUARIO");

                    b.HasKey("Id");

                    b.ToTable("RG_USUARIO");
                });
#pragma warning restore 612, 618
        }
    }
}
