﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductStore.Data.Context;

namespace ProductStore.WebAPI.Migrations
{
    [DbContext(typeof(ProductStoreContext))]
    [Migration("20191002032926_CategoryFather_Nullable")]
    partial class CategoryFather_Nullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductStore.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryFatherId")
                        .HasColumnName("CATEGORIA_PAI_ID")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRICAO")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NOME")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("CategoryFatherId");

                    b.ToTable("TB_CATEGORIA");
                });

            modelBuilder.Entity("ProductStore.Model.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Archive")
                        .IsRequired()
                        .HasColumnName("ARQUIVO");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NOME")
                        .HasMaxLength(50);

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("TB_DOCUMENTO");
                });

            modelBuilder.Entity("ProductStore.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnName("CATEGORIA_ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("DESCRICAO")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NOME")
                        .HasMaxLength(30);

                    b.Property<decimal>("Price")
                        .HasColumnName("PRECO");

                    b.Property<int>("Stock")
                        .HasColumnName("ESTOQUE");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("TB_PRODUTO");
                });

            modelBuilder.Entity("ProductStore.Model.Category", b =>
                {
                    b.HasOne("ProductStore.Model.Category", "CategoryFather")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryFatherId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProductStore.Model.Document", b =>
                {
                    b.HasOne("ProductStore.Model.Product")
                        .WithMany("Documents")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProductStore.Model.Product", b =>
                {
                    b.HasOne("ProductStore.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
