﻿// <auto-generated />
using System;
using InterviewRubric.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InterviewRubric.Server.Migrations
{
    [DbContext(typeof(RubricContext))]
    [Migration("20180605063829_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InterviewRubric.Shared.RubricQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category");

                    b.Property<int>("Difficulty");

                    b.Property<string>("High");

                    b.Property<string>("Low");

                    b.Property<string>("Medium");

                    b.Property<int>("Minutes");

                    b.Property<string>("Question");

                    b.Property<string>("Technology");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("RubricQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
