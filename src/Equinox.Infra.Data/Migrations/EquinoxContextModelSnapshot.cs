﻿// <auto-generated />
using System;
using Equinox.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Equinox.Infra.Data.Migrations
{
    [DbContext(typeof(EquinoxContext))]
    partial class EquinoxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Equinox.Domain.Models.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AnimalId")
                        .HasColumnType("integer");

                    b.Property<int?>("ClienteAnimalId")
                        .HasColumnType("integer");

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("timestamp");

                    b.Property<string>("DataConsulta")
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Horario")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("VeterinarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClienteAnimalId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Agendamento");
                });

            modelBuilder.Entity("Equinox.Domain.Models.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AgendamentoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("timestamp");

                    b.Property<string>("Diagnostico")
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("Equinox.Domain.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("timestamp");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Equinox.Domain.Models.ClienteAnimal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnName("ClienteId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("timestamp");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(150);

                    b.Property<int>("TipoAnimalId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("ClienteAnimal");
                });

            modelBuilder.Entity("Equinox.Domain.Models.ClienteContato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnName("ClienteId")
                        .HasColumnType("integer");

                    b.Property<string>("NomeContato")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("TipoContatoId")
                        .HasColumnName("TipoContatoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("ClienteContato");
                });

            modelBuilder.Entity("Equinox.Domain.Models.TipoAnimal", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("TipoAnimal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Cão"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Gato"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Hamster"
                        });
                });

            modelBuilder.Entity("Equinox.Domain.Models.TipoContato", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("TipoContato");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Telefone"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Celular"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "E-mail"
                        });
                });

            modelBuilder.Entity("Equinox.Domain.Models.Veterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataContratacao")
                        .HasColumnType("timestamp");

                    b.Property<bool>("Geriatra")
                        .HasColumnType("boolean");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Veterinario");
                });

            modelBuilder.Entity("Equinox.Domain.Models.VeterinarioGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DiaSemana")
                        .HasColumnType("integer");

                    b.Property<DateTime>("HorFim")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("HorIni")
                        .HasColumnType("timestamp");

                    b.Property<int>("Intervalo")
                        .HasColumnType("integer");

                    b.Property<int>("VeterinarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("VeterinarioGrade");
                });

            modelBuilder.Entity("Equinox.Domain.Models.Agendamento", b =>
                {
                    b.HasOne("Equinox.Domain.Models.ClienteAnimal", null)
                        .WithMany("Agendandamento")
                        .HasForeignKey("ClienteAnimalId");

                    b.HasOne("Equinox.Domain.Models.Cliente", "Cliente")
                        .WithMany("Agendamento")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Equinox.Domain.Models.Veterinario", "Veterinario")
                        .WithMany("Agendamento")
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Equinox.Domain.Models.ClienteAnimal", b =>
                {
                    b.HasOne("Equinox.Domain.Models.Cliente", "Cliente")
                        .WithMany("ClienteAnimal")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Equinox.Domain.Models.ClienteContato", b =>
                {
                    b.HasOne("Equinox.Domain.Models.Cliente", "Cliente")
                        .WithMany("ClienteContato")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
