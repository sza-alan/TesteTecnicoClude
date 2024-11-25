﻿// <auto-generated />
using GestaoProfissionais.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoProfissionais.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241125021719_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("GestaoProfissionais.Models.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Cardiologia",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Ortopedia",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Pediatria",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Dermatologia",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Ginecologia",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Neurologia",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Psiquiatria",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Anestesiologia",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Radiologia",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Endocrinologia",
                            TipoDocumento = "CRM"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Nutricionista Clínico",
                            TipoDocumento = "CRN"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Nutrição Esportiva",
                            TipoDocumento = "CRN"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "Nutrição Oncológica",
                            TipoDocumento = "CRN"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "Fisioterapia Ortopédica",
                            TipoDocumento = "CREFITO"
                        },
                        new
                        {
                            Id = 15,
                            Nome = "Fisioterapia Neurológica",
                            TipoDocumento = "CREFITO"
                        },
                        new
                        {
                            Id = 16,
                            Nome = "Fisioterapia Respiratória",
                            TipoDocumento = "CREFITO"
                        },
                        new
                        {
                            Id = 17,
                            Nome = "Ortodontia",
                            TipoDocumento = "CRO"
                        },
                        new
                        {
                            Id = 18,
                            Nome = "Implantodontia",
                            TipoDocumento = "CRO"
                        },
                        new
                        {
                            Id = 19,
                            Nome = "Endodontia",
                            TipoDocumento = "CRO"
                        },
                        new
                        {
                            Id = 20,
                            Nome = "Enfermagem Geral",
                            TipoDocumento = "COREN"
                        },
                        new
                        {
                            Id = 21,
                            Nome = "Enfermagem Obstétrica",
                            TipoDocumento = "COREN"
                        },
                        new
                        {
                            Id = 22,
                            Nome = "Psicologia Clínica",
                            TipoDocumento = "CRP"
                        },
                        new
                        {
                            Id = 23,
                            Nome = "Psicologia Organizacional",
                            TipoDocumento = "CRP"
                        },
                        new
                        {
                            Id = 24,
                            Nome = "Neuropsicologia",
                            TipoDocumento = "CRP"
                        },
                        new
                        {
                            Id = 25,
                            Nome = "Farmácia Clínica",
                            TipoDocumento = "CRF"
                        },
                        new
                        {
                            Id = 26,
                            Nome = "Farmácia Hospitalar",
                            TipoDocumento = "CRF"
                        },
                        new
                        {
                            Id = 27,
                            Nome = "Análises Clínicas",
                            TipoDocumento = "CRF"
                        },
                        new
                        {
                            Id = 28,
                            Nome = "Personal Trainer",
                            TipoDocumento = "CREF"
                        },
                        new
                        {
                            Id = 29,
                            Nome = "Preparação Física",
                            TipoDocumento = "CREF"
                        });
                });

            modelBuilder.Entity("GestaoProfissionais.Models.Profissional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("Profissionais");
                });

            modelBuilder.Entity("GestaoProfissionais.Models.Profissional", b =>
                {
                    b.HasOne("GestaoProfissionais.Models.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");
                });
#pragma warning restore 612, 618
        }
    }
}