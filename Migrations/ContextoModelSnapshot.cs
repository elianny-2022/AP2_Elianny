﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AP2_Verduras.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("UnidadDeMedida")
                        .HasColumnType("REAL");

                    b.HasKey("VitaminaId");

                    b.ToTable("Vitaminas");

                    b.HasData(
                        new
                        {
                            VitaminaId = 1,
                            Descripcion = "Vitamina C (mg)",
                            UnidadDeMedida = 120.0
                        },
                        new
                        {
                            VitaminaId = 2,
                            Descripcion = "Vitamina E (mg)",
                            UnidadDeMedida = 1.54
                        },
                        new
                        {
                            VitaminaId = 3,
                            Descripcion = "Vitamina K (mcg)",
                            UnidadDeMedida = 390.0
                        },
                        new
                        {
                            VitaminaId = 4,
                            Descripcion = "Vitamina A (mcg RAE)",
                            UnidadDeMedida = 90.0
                        },
                        new
                        {
                            VitaminaId = 5,
                            Descripcion = "Betaína (mg)",
                            UnidadDeMedida = 700.0
                        },
                        new
                        {
                            VitaminaId = 6,
                            Descripcion = "Tiamina(B1) (mg)",
                            UnidadDeMedida = 0.11
                        },
                        new
                        {
                            VitaminaId = 7,
                            Descripcion = "Riboflavina(B2) (mg)",
                            UnidadDeMedida = 0.13
                        },
                        new
                        {
                            VitaminaId = 8,
                            Descripcion = "Ácido fólico(B9) (mg)",
                            UnidadDeMedida = 400.0
                        },
                        new
                        {
                            VitaminaId = 9,
                            Descripcion = "Choline (mg)",
                            UnidadDeMedida = 0.80000000000000004
                        },
                        new
                        {
                            VitaminaId = 10,
                            Descripcion = "Folate(B9) (μg)",
                            UnidadDeMedida = 141.0
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
