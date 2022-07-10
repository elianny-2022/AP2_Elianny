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
    [Migration("20220709192554_Cambie campo de Vitaminas")]
    partial class CambiecampodeVitaminas
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

                    b.Property<double>("UnidadDeMedida")
                        .HasColumnType("REAL");

                    b.HasKey("VitaminaId");

                    b.ToTable("Vitaminas");
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