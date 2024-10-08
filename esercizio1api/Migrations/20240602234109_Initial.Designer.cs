﻿// <auto-generated />
using esercizio1api.Dd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace esercizio1api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240602234109_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("esercizio1api.Entity.AlunnoEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Anno")
                        .HasColumnType("text");

                    b.Property<string>("ClasseId")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Alunni");
                });

            modelBuilder.Entity("esercizio1api.Entity.ClasseEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Sezione")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Classi");
                });

            modelBuilder.Entity("esercizio1api.Entity.AlunnoEntity", b =>
                {
                    b.HasOne("esercizio1api.Entity.ClasseEntity", "Classe")
                        .WithMany("Alunni")
                        .HasForeignKey("ClasseId");

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("esercizio1api.Entity.ClasseEntity", b =>
                {
                    b.Navigation("Alunni");
                });
#pragma warning restore 612, 618
        }
    }
}
