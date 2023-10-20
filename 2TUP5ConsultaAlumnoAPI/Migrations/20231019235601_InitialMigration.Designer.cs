﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2TUP5ConsultaAlumnoAPI.Data;

#nullable disable

namespace _2TUP5ConsultaAlumnoAPI.Migrations
{
    [DbContext(typeof(ConsultaContext))]
    [Migration("20231019235601_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("ProfessorSubject", b =>
                {
                    b.Property<int>("ProfessorsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProfessorsId", "SubjectsId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("ProfessorsSubjects", (string)null);

                    b.HasData(
                        new
                        {
                            ProfessorsId = 4,
                            SubjectsId = 1
                        },
                        new
                        {
                            ProfessorsId = 5,
                            SubjectsId = 1
                        },
                        new
                        {
                            ProfessorsId = 4,
                            SubjectsId = 2
                        });
                });

            modelBuilder.Entity("StudentSubject", b =>
                {
                    b.Property<int>("StudentsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectsAttendedId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentsId", "SubjectsAttendedId");

                    b.HasIndex("SubjectsAttendedId");

                    b.ToTable("SubjectsStudents", (string)null);

                    b.HasData(
                        new
                        {
                            StudentsId = 1,
                            SubjectsAttendedId = 1
                        },
                        new
                        {
                            StudentsId = 1,
                            SubjectsAttendedId = 2
                        });
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatorStudentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatorStudentId");

                    b.HasIndex("ProfessorId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreatorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Quarter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Programación 3",
                            Quarter = "Tercer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Labarotario de Computacion 4",
                            Quarter = "Cuarto"
                        });
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("UserType").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Professor", b =>
                {
                    b.HasBaseType("_2TUP5ConsultaAlumnoAPI.Data.Entities.User");

                    b.HasDiscriminator().HasValue("Professor");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Email = "nbologna31@gmail.com",
                            LastName = "Bologna",
                            Name = "Nicolas",
                            Password = "123456",
                            UserName = "nbologna_profesor"
                        },
                        new
                        {
                            Id = 5,
                            Email = "ppaez@gmail.com",
                            LastName = "Paez",
                            Name = "Pablo",
                            Password = "123456",
                            UserName = "ppaez"
                        });
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Student", b =>
                {
                    b.HasBaseType("_2TUP5ConsultaAlumnoAPI.Data.Entities.User");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "nbologna31@gmail.com",
                            LastName = "Bologna",
                            Name = "Nicolas",
                            Password = "123456",
                            UserName = "nbologna_alumno"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Jperez@gmail.com",
                            LastName = "Perez",
                            Name = "Juan",
                            Password = "123456",
                            UserName = "jperez"
                        },
                        new
                        {
                            Id = 3,
                            Email = "pgarcia@gmail.com",
                            LastName = "Garcia",
                            Name = "Pedro",
                            Password = "123456",
                            UserName = "pgarcia"
                        });
                });

            modelBuilder.Entity("ProfessorSubject", b =>
                {
                    b.HasOne("_2TUP5ConsultaAlumnoAPI.Data.Entities.Professor", null)
                        .WithMany()
                        .HasForeignKey("ProfessorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2TUP5ConsultaAlumnoAPI.Data.Entities.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentSubject", b =>
                {
                    b.HasOne("_2TUP5ConsultaAlumnoAPI.Data.Entities.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2TUP5ConsultaAlumnoAPI.Data.Entities.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsAttendedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Question", b =>
                {
                    b.HasOne("_2TUP5ConsultaAlumnoAPI.Data.Entities.Student", "Student")
                        .WithMany("Questions")
                        .HasForeignKey("CreatorStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2TUP5ConsultaAlumnoAPI.Data.Entities.Professor", "AssignedProfessor")
                        .WithMany("Questions")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2TUP5ConsultaAlumnoAPI.Data.Entities.Subject", "Subject")
                        .WithMany("Questions")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedProfessor");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Response", b =>
                {
                    b.HasOne("_2TUP5ConsultaAlumnoAPI.Data.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2TUP5ConsultaAlumnoAPI.Data.Entities.Question", "Question")
                        .WithMany("Responses")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Question", b =>
                {
                    b.Navigation("Responses");
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Subject", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Professor", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("_2TUP5ConsultaAlumnoAPI.Data.Entities.Student", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
