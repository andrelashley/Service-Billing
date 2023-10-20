﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Service_Billing.Data;

#nullable disable

namespace Service_Billing.Migrations
{
    [DbContext(typeof(ServiceBillingContext))]
    partial class ServiceBillingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Service_Billing.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BillingCycle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientAccountId")
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("FiscalPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdirOrUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ServiceCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("TicketNumberAndRequester")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ticketNumberAndRequesterName");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bills", (string)null);
                });

            modelBuilder.Entity("Service_Billing.Models.ClientAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CasClientNumber")
                        .HasColumnType("int");

                    b.Property<short?>("ClientNumber")
                        .HasColumnType("smallint");

                    b.Property<string>("ClientTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpenseAuthorityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApprovedByEA")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("ResponsibilityCentre")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<short?>("STOB")
                        .HasColumnType("smallint");

                    b.Property<int?>("ServiceLine")
                        .HasColumnType("int");

                    b.Property<string>("ServicesEnabled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ClientAccounts", (string)null);
                });

            modelBuilder.Entity("Service_Billing.Models.ClientTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Approver")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinancialContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientTeams", (string)null);
                });

            modelBuilder.Entity("Service_Billing.Models.Ministry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ministries", (string)null);
                });

            modelBuilder.Entity("Service_Billing.Models.ServiceCategory", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<string>("Costs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GDXBusArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UOM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("ServiceCategories", (string)null);
                });

            modelBuilder.Entity("Service_Billing.ViewModels.ClientIntakeViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("DivisionOrBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinistryAcronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("TeamId");

                    b.ToTable("ClientIntakeViewModel", (string)null);
                });

            modelBuilder.Entity("Service_Billing.ViewModels.ClientIntakeViewModel", b =>
                {
                    b.HasOne("Service_Billing.Models.ClientAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service_Billing.Models.ClientTeam", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Account");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
