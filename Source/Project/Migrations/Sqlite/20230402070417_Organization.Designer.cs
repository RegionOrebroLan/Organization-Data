﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegionOrebroLan.Organization.Data.Sqlite;

namespace RegionOrebroLan.Organization.Data.Migrations.Sqlite
{
    [DbContext(typeof(SqliteOrganizationContext))]
    [Migration("20230402070417_Organization")]
    partial class Organization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("RegionOrebroLan.Organization.Data.Entities.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusinessClassificationName")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Cn")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("CountyCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("CountyName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Disabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayOption")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("DistinguishedName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("DropInHours")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("EndDate")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Extension")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("FacsimileTelephoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("FinancingOrganization")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("GeographicalCoordinates")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("GivenName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Guid")
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaAltText")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaConsigneeAddress")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaDeliveryAddress")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaDirectoryContact")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaGroupPrescriptionCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaHealthCareArea")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaHealthCareUnitManager")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaHealthCareUnitMember")
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaIdentity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaInvoiceAddress")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaProtectedPerson")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaResponsibleHealthCareProvider")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaSwitchboardNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaTelephoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaTextTelephoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaTitle")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaVisitingRuleAge")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaVisitingRuleReferral")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaVisitingRules")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaVpwInformation1")
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaVpwInformation2")
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaVpwInformation3")
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaVpwInformation4")
                        .HasColumnType("TEXT");

                    b.Property<string>("HsaVpwNeighbouringObject")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Initials")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("L")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LabeledURI")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("MunicipalityCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("MunicipalityName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("NickName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("O")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectClass")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("OllAssistant")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("OllInternalPagerNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("OllManager")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("OllPublicTelephoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("OllStudentValues")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("OllSystemId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("OllSystemRole")
                        .HasColumnType("TEXT");

                    b.Property<string>("OllViceManager")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("OrgNo")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Ou")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("OuShort")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PaTitleName")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Pager")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostOfficeBox")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalAddress")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("RBAC")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Route")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Saved")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeeAlso")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("SmsTelephoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sn")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialityName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("St")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("StartDate")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("SurgeryHours")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("TelephoneHours")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("TelephoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("TelexNumber")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Uid")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrescriptionCode")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitShortName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ValidNotAfter")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("ValidNotBefore")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("VisitingHours")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DistinguishedName")
                        .IsUnique();

                    b.HasIndex("Guid")
                        .IsUnique();

                    b.HasIndex("HsaIdentity")
                        .IsUnique();

                    b.ToTable("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}