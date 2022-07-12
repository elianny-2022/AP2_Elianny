﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AP2_Verduras.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220711222402_Nueva migracion")]
    partial class Nuevamigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Verduras", b =>
                {
                    b.Property<int>("VerduraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VerduraId");

                    b.ToTable("Verduras");
                });

            modelBuilder.Entity("VerdurasDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<int>("VerduraId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VitaminaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VerduraId");

                    b.ToTable("VerdurasDetalle");
                });

            modelBuilder.Entity("Vitaminas", b =>
                {
                    b.Property<int>("VitaminaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Existencia")
                        .HasColumnType("REAL");

                    b.Property<string>("UnidadMedida")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VitaminaId");

                    b.ToTable("Vitaminas");

                    b.HasData(
                        new
                        {
                            VitaminaId = 1,
                            Descripcion = "Vitamina C",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 2,
                            Descripcion = "Vitamina E ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 3,
                            Descripcion = "Vitamina K ",
                            Existencia = 0.0,
                            UnidadMedida = "mcg"
                        },
                        new
                        {
                            VitaminaId = 4,
                            Descripcion = "Vitamina A ",
                            Existencia = 0.0,
                            UnidadMedida = "mcg RAE"
                        },
                        new
                        {
                            VitaminaId = 5,
                            Descripcion = "Betaína",
                            Existencia = 0.0,
                            UnidadMedida = "mcg RAE"
                        },
                        new
                        {
                            VitaminaId = 6,
                            Descripcion = "Tiamina(B1)",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 7,
                            Descripcion = "Riboflavina(B2)",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 8,
                            Descripcion = "Ácido fólico(B9)",
                            Existencia = 0.0,
                            UnidadMedida = "(mg)"
                        },
                        new
                        {
                            VitaminaId = 9,
                            Descripcion = "Choline",
                            Existencia = 0.0,
                            UnidadMedida = "(mg)"
                        },
                        new
                        {
                            VitaminaId = 10,
                            Descripcion = "Folate(B9) (μg)",
                            Existencia = 0.0,
                            UnidadMedida = "(μg)"
                        });
                });

            modelBuilder.Entity("VerdurasDetalle", b =>
                {
                    b.HasOne("Verduras", null)
                        .WithMany("Detalle")
                        .HasForeignKey("VerduraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Verduras", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
