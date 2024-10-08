﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using esercizio1api.Dd;

#nullable disable

namespace esercizio1api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240605173732_AlunnoClasseRelazione1N")]
    partial class AlunnoClasseRelazione1N
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
                    b.Property<string>("AlunnoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Anno")
                        .HasColumnType("text");

                    b.Property<string>("ClasseEntityClasseId")
                        .HasColumnType("text");

                    b.Property<string>("ClasseId")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AlunnoId");

                    b.HasIndex("ClasseEntityClasseId");

                    b.ToTable("Alunni");
                });

            modelBuilder.Entity("esercizio1api.Entity.ClasseEntity", b =>
                {
                    b.Property<string>("ClasseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Sezione")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ClasseId");

                    b.ToTable("Classi");
                });

            modelBuilder.Entity("esercizio1api.Entity.AlunnoEntity", b =>
                {
                    b.HasOne("esercizio1api.Entity.ClasseEntity", "ClasseEntity")
                        .WithMany("Alunno")
                        .HasForeignKey("ClasseEntityClasseId");

                    b.Navigation("ClasseEntity");
                });

            modelBuilder.Entity("esercizio1api.Entity.ClasseEntity", b =>
                {
                    b.Navigation("Alunno");
                });
#pragma warning restore 612, 618
        }
    }
}
