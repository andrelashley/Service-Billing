﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Service_Billing.Data;

#nullable disable

namespace Service_Billing.Migrations
{
    [DbContext(typeof(ServiceBillingContext))]
    [Migration("20230525223947_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Service_Billing.Models.Bill", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("UOM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("clientAccountId")
                        .HasColumnType("int");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expenseAuthorityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fiscalPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idirOrUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("serviceCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ticketNumberAndRequesterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("bills");
                });

            modelBuilder.Entity("Service_Billing.Models.ClientAccount", b =>
                {
                    b.Property<int>("accountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Client_Account_Number");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("accountId"));

                    b.Property<int>("STOB")
                        .HasColumnType("int");

                    b.Property<int>("client")
                        .HasColumnType("int");

                    b.Property<string>("clientName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Client_Account_Name");

                    b.Property<int>("clientTeam")
                        .HasColumnType("int")
                        .HasColumnName("Client_Team");

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created");

                    b.Property<string>("expense_Authority_Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Expense_Authority_Name");

                    b.Property<int>("project")
                        .HasColumnType("int");

                    b.Property<string>("responsibilityCentre")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Responsibility_Centre");

                    b.Property<int>("serviceLine")
                        .HasColumnType("int")
                        .HasColumnName("Service_Line");

                    b.Property<string>("servicesEnabled")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Services_Enabled");

                    b.HasKey("accountId");

                    b.ToTable("clientAccounts");
                });

            modelBuilder.Entity("Service_Billing.Models.ServiceCategory", b =>
                {
                    b.Property<int>("serviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("serviceId"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("unitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("serviceId");

                    b.ToTable("serviceCategories");
                });
#pragma warning restore 612, 618
        }
    }
}