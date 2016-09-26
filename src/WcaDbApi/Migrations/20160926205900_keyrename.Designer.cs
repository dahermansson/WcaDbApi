using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WcaDbApi.Models;

namespace WcaDbApi.Migrations
{
    [DbContext(typeof(WCADBContext))]
    [Migration("20160926205900_keyrename")]
    partial class keyrename
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WcaDbApi.Models.Competitions", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<string>("CellName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cellName")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 45);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cityName")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("countryId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<short>("Day")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("day")
                        .HasDefaultValueSql("0");

                    b.Property<short>("EndDay")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("endDay")
                        .HasDefaultValueSql("0");

                    b.Property<short>("EndMonth")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("endMonth")
                        .HasDefaultValueSql("0");

                    b.Property<string>("EventSpecs")
                        .IsRequired()
                        .HasColumnName("eventSpecs")
                        .HasColumnType("text");

                    b.Property<string>("External_website")
                        .HasColumnName("external_website")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Information")
                        .HasColumnName("information")
                        .HasColumnType("text");

                    b.Property<int>("Latitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("latitude")
                        .HasDefaultValueSql("0");

                    b.Property<int>("Longitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("longitude")
                        .HasDefaultValueSql("0");

                    b.Property<short>("Month")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("month")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Organiser")
                        .IsRequired()
                        .HasColumnName("organiser")
                        .HasColumnType("text");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("venue")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 240);

                    b.Property<string>("VenueAddress")
                        .HasColumnName("venueAddress")
                        .HasAnnotation("MaxLength", 120);

                    b.Property<string>("VenueDetails")
                        .HasColumnName("venueDetails")
                        .HasAnnotation("MaxLength", 120);

                    b.Property<string>("WcaDelegate")
                        .IsRequired()
                        .HasColumnName("wcaDelegate")
                        .HasColumnType("text");

                    b.Property<short>("Year")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("year")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("WcaDbApi.Models.CompetitionsDiff", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<string>("CellName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cellName")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 45);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cityName")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("countryId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<short>("Day")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("day")
                        .HasDefaultValueSql("0");

                    b.Property<short>("EndDay")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("endDay")
                        .HasDefaultValueSql("0");

                    b.Property<short>("EndMonth")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("endMonth")
                        .HasDefaultValueSql("0");

                    b.Property<string>("EventSpecs")
                        .IsRequired()
                        .HasColumnName("eventSpecs")
                        .HasColumnType("text");

                    b.Property<string>("External_website")
                        .HasColumnName("external_website")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Information")
                        .HasColumnName("information")
                        .HasColumnType("text");

                    b.Property<int>("Latitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("latitude")
                        .HasDefaultValueSql("0");

                    b.Property<int>("Longitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("longitude")
                        .HasDefaultValueSql("0");

                    b.Property<short>("Month")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("month")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Organiser")
                        .IsRequired()
                        .HasColumnName("organiser")
                        .HasColumnType("text");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("venue")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 240);

                    b.Property<string>("VenueAddress")
                        .HasColumnName("venueAddress")
                        .HasAnnotation("MaxLength", 120);

                    b.Property<string>("VenueDetails")
                        .HasColumnName("venueDetails")
                        .HasAnnotation("MaxLength", 120);

                    b.Property<string>("WcaDelegate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("wcaDelegate")
                        .HasColumnType("text")
                        .HasDefaultValueSql("''");

                    b.Property<short>("Year")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("year")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.ToTable("Competitions_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.Continents", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int>("Latitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("latitude")
                        .HasDefaultValueSql("0");

                    b.Property<int>("Longitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("longitude")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("RecordName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recordName")
                        .HasColumnType("char(3)")
                        .HasDefaultValueSql("''");

                    b.Property<byte>("Zoom")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("zoom")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("WcaDbApi.Models.ContinentsDiff", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int>("Latitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("latitude")
                        .HasDefaultValueSql("0");

                    b.Property<int>("Longitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("longitude")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("RecordName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recordName")
                        .HasColumnType("char(3)")
                        .HasDefaultValueSql("''");

                    b.Property<byte>("Zoom")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("zoom")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.ToTable("Continents_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.Countries", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("ContinentId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("continentId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Iso2")
                        .HasColumnName("iso2")
                        .HasColumnType("char(2)");

                    b.Property<int>("Latitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("latitude")
                        .HasDefaultValueSql("0");

                    b.Property<int>("Longitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("longitude")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<byte>("Zoom")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("zoom")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WcaDbApi.Models.CountriesDiff", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("ContinentId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("continentId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Iso2")
                        .HasColumnName("iso2")
                        .HasColumnType("char(2)");

                    b.Property<int>("Latitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("latitude")
                        .HasDefaultValueSql("0");

                    b.Property<int>("Longitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("longitude")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<byte>("Zoom")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("zoom")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.ToTable("Countries_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.Events", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<string>("CellName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cellName")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 45);

                    b.Property<string>("Format")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("format")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 54);

                    b.Property<int>("Rank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rank")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("WcaDbApi.Models.EventsDiff", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<string>("CellName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cellName")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 45);

                    b.Property<string>("Format")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("format")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 54);

                    b.Property<int>("Rank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rank")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.ToTable("Events_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.Formats", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Expected_solve_count");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Sort_by");

                    b.Property<string>("Sort_by_second");

                    b.Property<int>("Trim_fastest_n");

                    b.Property<int>("Trim_slowest_n");

                    b.HasKey("Id");

                    b.ToTable("Formats");
                });

            modelBuilder.Entity("WcaDbApi.Models.FormatsDiff", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Expected_solve_count");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Sort_by");

                    b.Property<string>("Sort_by_second");

                    b.Property<int>("Trim_fastest_n");

                    b.Property<int>("Trim_slowest_n");

                    b.HasKey("Id");

                    b.ToTable("Formats_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.ImportedFiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("Imported")
                        .HasColumnName("imported")
                        .HasColumnType("datetime");

                    b.Property<string>("WcaFileName")
                        .IsRequired()
                        .HasColumnName("wcaFileName")
                        .HasAnnotation("MaxLength", 50);

                    b.HasKey("Id");

                    b.ToTable("ImportedFiles");
                });

            modelBuilder.Entity("WcaDbApi.Models.Key", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ApiKey");

                    b.Property<bool>("BannedEmail");

                    b.Property<bool>("BannedKey");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 250);

                    b.HasKey("Id");

                    b.ToTable("Key");
                });

            modelBuilder.Entity("WcaDbApi.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Filename")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Info")
                        .HasAnnotation("MaxLength", 2000);

                    b.HasKey("Id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("WcaDbApi.Models.Persons", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<byte>("Subid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("subid")
                        .HasDefaultValueSql("1");

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("countryId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gender")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasAnnotation("MaxLength", 80);

                    b.HasKey("Id", "Subid")
                        .HasName("PK_Persons");

                    b.HasIndex("CountryId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WcaDbApi.Models.PersonsDiff", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<byte>("Subid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("subid")
                        .HasDefaultValueSql("1");

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("countryId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gender")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasAnnotation("MaxLength", 80);

                    b.HasKey("Id", "Subid")
                        .HasName("PK_Persons_Diff");

                    b.ToTable("Persons_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.RanksAverage", b =>
                {
                    b.Property<string>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("personId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<string>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("eventId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<int>("Best")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("best")
                        .HasDefaultValueSql("0");

                    b.Property<int>("ContinentRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("continentRank")
                        .HasDefaultValueSql("0");

                    b.Property<int>("CountryRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("countryRank")
                        .HasDefaultValueSql("0");

                    b.Property<int>("WorldRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("worldRank")
                        .HasDefaultValueSql("0");

                    b.HasKey("PersonId", "EventId")
                        .HasName("PK_RanksAverage");

                    b.ToTable("RanksAverage");
                });

            modelBuilder.Entity("WcaDbApi.Models.RanksAverageDiff", b =>
                {
                    b.Property<string>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("personId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<string>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("eventId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<int>("Best")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("best")
                        .HasDefaultValueSql("0");

                    b.Property<int>("ContinentRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("continentRank")
                        .HasDefaultValueSql("0");

                    b.Property<int>("CountryRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("countryRank")
                        .HasDefaultValueSql("0");

                    b.Property<int>("WorldRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("worldRank")
                        .HasDefaultValueSql("0");

                    b.HasKey("PersonId", "EventId")
                        .HasName("PK_RanksAverage_Diff");

                    b.ToTable("RanksAverage_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.RanksSingle", b =>
                {
                    b.Property<string>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("personId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<string>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("eventId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<int>("Best")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("best")
                        .HasDefaultValueSql("0");

                    b.Property<int>("ContinentRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("continentRank")
                        .HasDefaultValueSql("0");

                    b.Property<int>("CountryRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("countryRank")
                        .HasDefaultValueSql("0");

                    b.Property<int>("WorldRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("worldRank")
                        .HasDefaultValueSql("0");

                    b.HasKey("PersonId", "EventId")
                        .HasName("PK_RanksSingle");

                    b.ToTable("RanksSingle");
                });

            modelBuilder.Entity("WcaDbApi.Models.RanksSingleDiff", b =>
                {
                    b.Property<string>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("personId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<string>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("eventId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<int>("Best")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("best")
                        .HasDefaultValueSql("0");

                    b.Property<int>("ContinentRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("continentRank")
                        .HasDefaultValueSql("0");

                    b.Property<int>("CountryRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("countryRank")
                        .HasDefaultValueSql("0");

                    b.Property<int>("WorldRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("worldRank")
                        .HasDefaultValueSql("0");

                    b.HasKey("PersonId", "EventId")
                        .HasName("PK_RanksSingle_Diff");

                    b.ToTable("RanksSingle_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.Results", b =>
                {
                    b.Property<string>("CompetitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("competitionId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<string>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("eventId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<string>("RoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("roundId")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("personId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<int>("Average")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("average")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Best")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("best")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("FormatId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("formatId")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("PersonCountryId")
                        .HasColumnName("personCountryId")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("PersonName")
                        .HasColumnName("personName")
                        .HasAnnotation("MaxLength", 80);

                    b.Property<short>("Pos")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("pos")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("RegionalAverageRecord")
                        .HasColumnName("regionalAverageRecord")
                        .HasColumnType("char(3)");

                    b.Property<string>("RegionalSingleRecord")
                        .HasColumnName("regionalSingleRecord")
                        .HasColumnType("char(3)");

                    b.Property<int>("Value1")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value1")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Value2")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value2")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Value3")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value3")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Value4")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value4")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Value5")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value5")
                        .HasDefaultValueSql("'0'");

                    b.HasKey("CompetitionId", "EventId", "RoundId", "PersonId")
                        .HasName("PK_Results");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("WcaDbApi.Models.ResultsDiff", b =>
                {
                    b.Property<string>("CompetitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("competitionId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<string>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("eventId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<string>("RoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("roundId")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("personId")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<int>("Average")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("average")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Best")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("best")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("FormatId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("formatId")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("PersonCountryId")
                        .HasColumnName("personCountryId")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("PersonName")
                        .HasColumnName("personName")
                        .HasAnnotation("MaxLength", 80);

                    b.Property<short>("Pos")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("pos")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("RegionalAverageRecord")
                        .HasColumnName("regionalAverageRecord")
                        .HasColumnType("char(3)");

                    b.Property<string>("RegionalSingleRecord")
                        .HasColumnName("regionalSingleRecord")
                        .HasColumnType("char(3)");

                    b.Property<int>("Value1")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value1")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Value2")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value2")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Value3")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value3")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Value4")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value4")
                        .HasDefaultValueSql("'0'");

                    b.Property<int>("Value5")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("value5")
                        .HasDefaultValueSql("'0'");

                    b.HasKey("CompetitionId", "EventId", "RoundId", "PersonId")
                        .HasName("PK_Results_Diff");

                    b.ToTable("Results_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.Rounds", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("CellName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cellName")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 45);

                    b.Property<int>("Final");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int>("Rank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rank")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("WcaDbApi.Models.RoundsDiff", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("CellName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cellName")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 45);

                    b.Property<int>("Final");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValueSql("''")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int>("Rank")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rank")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.ToTable("Rounds_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.Scrambles", b =>
                {
                    b.Property<long>("ScrambleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("scrambleId")
                        .HasDefaultValueSql("0");

                    b.Property<string>("CompetitionId")
                        .IsRequired()
                        .HasColumnName("competitionId")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnName("eventId")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<string>("GroupId")
                        .IsRequired()
                        .HasColumnName("groupId")
                        .HasAnnotation("MaxLength", 3);

                    b.Property<byte>("IsExtra")
                        .HasColumnName("isExtra");

                    b.Property<string>("RoundId")
                        .IsRequired()
                        .HasColumnName("roundId")
                        .HasColumnType("char(1)");

                    b.Property<string>("Scramble")
                        .IsRequired()
                        .HasColumnName("scramble")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<int>("ScrambleNum")
                        .HasColumnName("scrambleNum");

                    b.HasKey("ScrambleId")
                        .HasName("PK_Scrambles");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("EventId");

                    b.HasIndex("RoundId");

                    b.ToTable("Scrambles");
                });

            modelBuilder.Entity("WcaDbApi.Models.ScramblesDiff", b =>
                {
                    b.Property<long>("ScrambleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("scrambleId")
                        .HasDefaultValueSql("0");

                    b.Property<string>("CompetitionId")
                        .IsRequired()
                        .HasColumnName("competitionId")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnName("eventId")
                        .HasAnnotation("MaxLength", 6);

                    b.Property<string>("GroupId")
                        .IsRequired()
                        .HasColumnName("groupId")
                        .HasAnnotation("MaxLength", 3);

                    b.Property<byte>("IsExtra")
                        .HasColumnName("isExtra");

                    b.Property<string>("RoundId")
                        .IsRequired()
                        .HasColumnName("roundId")
                        .HasColumnType("char(1)");

                    b.Property<string>("Scramble")
                        .IsRequired()
                        .HasColumnName("scramble")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<int>("ScrambleNum")
                        .HasColumnName("scrambleNum");

                    b.HasKey("ScrambleId")
                        .HasName("PK_Scrambles_Diff");

                    b.ToTable("Scrambles_Diff");
                });

            modelBuilder.Entity("WcaDbApi.Models.Competitions", b =>
                {
                    b.HasOne("WcaDbApi.Models.Countries", "Country")
                        .WithMany("Competitions")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_Competitions_Countries");
                });

            modelBuilder.Entity("WcaDbApi.Models.Countries", b =>
                {
                    b.HasOne("WcaDbApi.Models.Continents", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId")
                        .HasConstraintName("FK_Countries_Continents");
                });

            modelBuilder.Entity("WcaDbApi.Models.Persons", b =>
                {
                    b.HasOne("WcaDbApi.Models.Countries", "Country")
                        .WithMany("Persons")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_Persons_Countries");
                });

            modelBuilder.Entity("WcaDbApi.Models.Scrambles", b =>
                {
                    b.HasOne("WcaDbApi.Models.Competitions", "Competition")
                        .WithMany("Scrambles")
                        .HasForeignKey("CompetitionId")
                        .HasConstraintName("FK_Scrambles_Competitions");

                    b.HasOne("WcaDbApi.Models.Events", "Event")
                        .WithMany("Scrambles")
                        .HasForeignKey("EventId")
                        .HasConstraintName("FK_Scrambles_Events");

                    b.HasOne("WcaDbApi.Models.Rounds", "Round")
                        .WithMany("Scrambles")
                        .HasForeignKey("RoundId")
                        .HasConstraintName("FK_Scrambles_Rounds");
                });
        }
    }
}
