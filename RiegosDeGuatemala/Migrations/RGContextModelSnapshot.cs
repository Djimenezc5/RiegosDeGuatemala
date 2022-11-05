﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RiegosDeGuatemala;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    [DbContext(typeof(RGContext))]
    partial class RGContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.procedures.SP_RG_CONSUMOS_SECTOR", b =>
                {
                    b.Property<int>("CATIDAD_AGUA")
                        .HasColumnType("int");

                    b.Property<int>("ID_SECTOR")
                        .HasColumnType("int");

                    b.Property<string>("NOMBRE_SECTOR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TIEMPO_RIEGO")
                        .HasColumnType("int");

                    b.ToView(null);
                });

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

                    b.Property<Guid>("codigoRiego")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CODIGO_RIEGO");

                    b.Property<bool>("esUltimo")
                        .HasColumnType("bit")
                        .HasColumnName("ULTIMO_HISTORIAL");

                    b.Property<bool>("riegoActivo")
                        .HasColumnType("bit")
                        .HasColumnName("ESTADO_RIEGO");

                    b.Property<int>("tiempoRiego")
                        .HasColumnType("int")
                        .HasColumnName("TIEMPO_RIEGO");

                    b.Property<DateTime>("ultimoAccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_ULTIMA_ACCION");

                    b.HasKey("Id");

                    b.HasIndex("IdSector");

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

                    b.Property<decimal>("luminosidadMaxima")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("LUMINOSIDAD _MAXIMA");

                    b.Property<decimal>("luminosidadMinima")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("LUMINOSIDAD _MINIMA");

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

                    b.HasIndex("UsuarioCreacion");

                    b.ToTable("RG_SECTOR");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sensores.HistorialSensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_HISTORIAL_SENSOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("esUltimo")
                        .HasColumnType("bit")
                        .HasColumnName("ULTIMO_HISTORIAL");

                    b.Property<DateTime>("fechaMedida")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_MEDIDA");

                    b.Property<int>("idSensor")
                        .HasColumnType("int")
                        .HasColumnName("RG_ID_SENSOR");

                    b.Property<decimal>("medidaSensor")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("MEDIDA_SENSOR");

                    b.HasKey("Id");

                    b.HasIndex("idSensor");

                    b.ToTable("RG_HISTORIAL_SENSOR");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sensores.Sensores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_SENSOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("CodigoSendor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CODIGO_SENSOR");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_CREACION");

                    b.Property<int>("IdTipoSensor")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_SENSOR");

                    b.Property<bool>("estadoSendor")
                        .HasColumnType("bit")
                        .HasColumnName("ESTADO_SENSOR");

                    b.Property<int>("idSector")
                        .HasColumnType("int")
                        .HasColumnName("ID_SECTOR");

                    b.Property<int>("idUsarioCreacion")
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO_CREACION");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoSensor");

                    b.HasIndex("idUsarioCreacion");

                    b.ToTable("RG_SENSORES");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sensores.TipoSensor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_SENSOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("DescripcionTipoSensor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPCION_TIPO_SENSOR");

                    b.Property<string>("Icono")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ICONO_TIPO_SENSOR");

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
                            DescripcionTipoSensor = "Sensores para la medición de humedad",
                            Icono = "water",
                            estadoSensor = true,
                            nombreTipoSensor = "Sensor humedad"
                        },
                        new
                        {
                            id = 2,
                            DescripcionTipoSensor = "Sensores para la medición de humedad",
                            Icono = "white-balance-sunny",
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

                    b.HasIndex("idUsuario");

                    b.ToTable("RG_USUARIO_TOKEN");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.Usuario.UsuarioEntidad", b =>
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

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sectores.HistoricoSectores", b =>
                {
                    b.HasOne("RiegosDeGuatemala.Entidades.sectores.sector", "sector")
                        .WithMany()
                        .HasForeignKey("IdSector")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sector");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sectores.sector", b =>
                {
                    b.HasOne("RiegosDeGuatemala.Entidades.Usuario.UsuarioEntidad", "UsuarioEntidad")
                        .WithMany()
                        .HasForeignKey("UsuarioCreacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioEntidad");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sensores.HistorialSensor", b =>
                {
                    b.HasOne("RiegosDeGuatemala.Entidades.sensores.Sensores", "Sensores")
                        .WithMany()
                        .HasForeignKey("idSensor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sensores");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.sensores.Sensores", b =>
                {
                    b.HasOne("RiegosDeGuatemala.Entidades.sensores.TipoSensor", "TipoSensor")
                        .WithMany()
                        .HasForeignKey("IdTipoSensor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RiegosDeGuatemala.Entidades.Usuario.UsuarioEntidad", "UsuarioEntidad")
                        .WithMany()
                        .HasForeignKey("idUsarioCreacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoSensor");

                    b.Navigation("UsuarioEntidad");
                });

            modelBuilder.Entity("RiegosDeGuatemala.Entidades.Usuario.TokenUsuario", b =>
                {
                    b.HasOne("RiegosDeGuatemala.Entidades.Usuario.UsuarioEntidad", "UsuarioEntidad")
                        .WithMany()
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioEntidad");
                });
#pragma warning restore 612, 618
        }
    }
}