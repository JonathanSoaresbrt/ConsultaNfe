﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RelatoriosWeb.Data;

namespace RelatoriosWeb.Migrations
{
    [DbContext(typeof(RelatoriosWebContext))]
    [Migration("20200526174159_Painel")]
    partial class Painel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RelatoriosWeb.Models.Painel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnpj");

                    b.Property<DateTime>("Dt_Termino");

                    b.Property<string>("Movimento");

                    b.Property<int>("Nf_Numero");

                    b.Property<string>("Nr_Serie");

                    b.Property<string>("Retorno");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Painel");
                });

            modelBuilder.Entity("RelatoriosWeb.Models.Painel_Nfe", b =>
                {
                    b.Property<int>("Nf_numero")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Chave_Nfe");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Cxml");

                    b.Property<DateTime>("Dt_Termino");

                    b.Property<int>("Modelo_Nfe");

                    b.Property<string>("Nr_serie");

                    b.Property<string>("Retorno");

                    b.Property<string>("Serie_Nfe");

                    b.Property<string>("Status");

                    b.Property<int>("Tp_nota");

                    b.HasKey("Nf_numero");

                    b.ToTable("Painel_Nfe");
                });

            modelBuilder.Entity("RelatoriosWeb.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
