using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WcaDbApi.Models
{
    public partial class WCADBContext : DbContext
    {
        public WCADBContext()
        {

        }
        public WCADBContext(DbContextOptions<WCADBContext> options): base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competitions>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasColumnName("cellName")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("cityName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("countryId")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Day)
                    .HasColumnName("day")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EndDay)
                    .HasColumnName("endDay")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EndMonth)
                    .HasColumnName("endMonth")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventSpecs)
                    .IsRequired()
                    .HasColumnName("eventSpecs")
                    .HasColumnType("text");

                entity.Property(e => e.Information)
                    .HasColumnName("information")
                    .HasColumnType("text");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Organiser)
                    .IsRequired()
                    .HasColumnName("organiser")
                    .HasColumnType("text");

                entity.Property(e => e.Venue)
                    .IsRequired()
                    .HasColumnName("venue")
                    .HasMaxLength(240)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VenueAddress)
                    .HasColumnName("venueAddress")
                    .HasMaxLength(120);

                entity.Property(e => e.VenueDetails)
                    .HasColumnName("venueDetails")
                    .HasMaxLength(120);

                entity.Property(e => e.WcaDelegate)
                    .IsRequired()
                    .HasColumnName("wcaDelegate")
                    .HasColumnType("text");

                entity.Property(e => e.External_website)
                    .HasColumnName("external_website")
                    .HasMaxLength(200);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Competitions)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Competitions_Countries");
            });

            modelBuilder.Entity<CompetitionsDiff>(entity =>
            {
                entity.ToTable("Competitions_Diff");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasColumnName("cellName")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("cityName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("countryId")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Day)
                    .HasColumnName("day")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EndDay)
                    .HasColumnName("endDay")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EndMonth)
                    .HasColumnName("endMonth")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventSpecs)
                    .IsRequired()
                    .HasColumnName("eventSpecs")
                    .HasColumnType("text");

                entity.Property(e => e.Information)
                    .HasColumnName("information")
                    .HasColumnType("text");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Organiser)
                    .IsRequired()
                    .HasColumnName("organiser")
                    .HasColumnType("text");

                entity.Property(e => e.Venue)
                    .IsRequired()
                    .HasColumnName("venue")
                    .HasMaxLength(240)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VenueAddress)
                    .HasColumnName("venueAddress")
                    .HasMaxLength(120);

                entity.Property(e => e.VenueDetails)
                    .HasColumnName("venueDetails")
                    .HasMaxLength(120);

                entity.Property(e => e.WcaDelegate)
                    .IsRequired()
                    .HasColumnName("wcaDelegate")
                    .HasColumnType("text")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.External_website)
                    .HasColumnName("external_website")
                    .HasMaxLength(200);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Continents>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordName)
                    .IsRequired()
                    .HasColumnName("recordName")
                    .HasColumnType("char(3)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Zoom)
                    .HasColumnName("zoom")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ContinentsDiff>(entity =>
            {
                entity.ToTable("Continents_Diff");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordName)
                    .IsRequired()
                    .HasColumnName("recordName")
                    .HasColumnType("char(3)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Zoom)
                    .HasColumnName("zoom")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ContinentId)
                    .IsRequired()
                    .HasColumnName("continentId")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Iso2)
                    .HasColumnName("iso2")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Zoom)
                    .HasColumnName("zoom")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Continent)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.ContinentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Countries_Continents");
            });

            modelBuilder.Entity<CountriesDiff>(entity =>
            {
                entity.ToTable("Countries_Diff");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ContinentId)
                    .IsRequired()
                    .HasColumnName("continentId")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Iso2)
                    .HasColumnName("iso2")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Zoom)
                    .HasColumnName("zoom")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasColumnName("cellName")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnName("format")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(54)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EventsDiff>(entity =>
            {
                entity.ToTable("Events_Diff");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasColumnName("cellName")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnName("format")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(54)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Formats>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<FormatsDiff>(entity =>
            {
                entity.ToTable("Formats_Diff");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ImportedFiles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Imported)
                    .HasColumnName("imported")
                    .HasColumnType("datetime");

                entity.Property(e => e.WcaFileName)
                    .IsRequired()
                    .HasColumnName("wcaFileName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Filename).HasMaxLength(200);

                entity.Property(e => e.Info).HasMaxLength(2000);
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Subid })
                    .HasName("PK_Persons");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Subid)
                    .HasColumnName("subid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("countryId")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(80);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Persons_Countries");
            });

            modelBuilder.Entity<PersonsDiff>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Subid })
                    .HasName("PK_Persons_Diff");

                entity.ToTable("Persons_Diff");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Subid)
                    .HasColumnName("subid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("countryId")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<RanksAverage>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.EventId })
                    .HasName("PK_RanksAverage");

                entity.Property(e => e.PersonId)
                    .HasColumnName("personId")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EventId)
                    .HasColumnName("eventId")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Best)
                    .HasColumnName("best")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContinentRank)
                    .HasColumnName("continentRank")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CountryRank)
                    .HasColumnName("countryRank")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WorldRank)
                    .HasColumnName("worldRank")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RanksAverageDiff>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.EventId })
                    .HasName("PK_RanksAverage_Diff");

                entity.ToTable("RanksAverage_Diff");

                entity.Property(e => e.PersonId)
                    .HasColumnName("personId")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EventId)
                    .HasColumnName("eventId")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Best)
                    .HasColumnName("best")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContinentRank)
                    .HasColumnName("continentRank")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CountryRank)
                    .HasColumnName("countryRank")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WorldRank)
                    .HasColumnName("worldRank")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RanksSingle>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.EventId })
                    .HasName("PK_RanksSingle");

                entity.Property(e => e.PersonId)
                    .HasColumnName("personId")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EventId)
                    .HasColumnName("eventId")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Best)
                    .HasColumnName("best")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContinentRank)
                    .HasColumnName("continentRank")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CountryRank)
                    .HasColumnName("countryRank")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WorldRank)
                    .HasColumnName("worldRank")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RanksSingleDiff>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.EventId })
                    .HasName("PK_RanksSingle_Diff");

                entity.ToTable("RanksSingle_Diff");

                entity.Property(e => e.PersonId)
                    .HasColumnName("personId")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EventId)
                    .HasColumnName("eventId")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Best)
                    .HasColumnName("best")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContinentRank)
                    .HasColumnName("continentRank")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CountryRank)
                    .HasColumnName("countryRank")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WorldRank)
                    .HasColumnName("worldRank")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Results>(entity =>
            {
                entity.HasKey(e => new { e.CompetitionId, e.EventId, e.RoundId, e.PersonId })
                    .HasName("PK_Results");

                entity.Property(e => e.CompetitionId)
                    .HasColumnName("competitionId")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EventId)
                    .HasColumnName("eventId")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RoundId)
                    .HasColumnName("roundId")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PersonId)
                    .HasColumnName("personId")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Average)
                    .HasColumnName("average")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Best)
                    .HasColumnName("best")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FormatId)
                    .IsRequired()
                    .HasColumnName("formatId")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PersonCountryId)
                    .HasColumnName("personCountryId")
                    .HasMaxLength(50);

                entity.Property(e => e.PersonName)
                    .HasColumnName("personName")
                    .HasMaxLength(80);

                entity.Property(e => e.Pos)
                    .HasColumnName("pos")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RegionalAverageRecord)
                    .HasColumnName("regionalAverageRecord")
                    .HasColumnType("char(3)");

                entity.Property(e => e.RegionalSingleRecord)
                    .HasColumnName("regionalSingleRecord")
                    .HasColumnType("char(3)");

                entity.Property(e => e.Value1)
                    .HasColumnName("value1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ResultsDiff>(entity =>
            {
                entity.HasKey(e => new { e.CompetitionId, e.EventId, e.RoundId, e.PersonId })
                    .HasName("PK_Results_Diff");

                entity.ToTable("Results_Diff");

                entity.Property(e => e.CompetitionId)
                    .HasColumnName("competitionId")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EventId)
                    .HasColumnName("eventId")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RoundId)
                    .HasColumnName("roundId")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PersonId)
                    .HasColumnName("personId")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Average)
                    .HasColumnName("average")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Best)
                    .HasColumnName("best")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FormatId)
                    .IsRequired()
                    .HasColumnName("formatId")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PersonCountryId)
                    .HasColumnName("personCountryId")
                    .HasMaxLength(50);

                entity.Property(e => e.PersonName)
                    .HasColumnName("personName")
                    .HasMaxLength(80);

                entity.Property(e => e.Pos)
                    .HasColumnName("pos")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RegionalAverageRecord)
                    .HasColumnName("regionalAverageRecord")
                    .HasColumnType("char(3)");

                entity.Property(e => e.RegionalSingleRecord)
                    .HasColumnName("regionalSingleRecord")
                    .HasColumnType("char(3)");

                entity.Property(e => e.Value1)
                    .HasColumnName("value1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Rounds>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasColumnName("cellName")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RoundsDiff>(entity =>
            {
                entity.ToTable("Rounds_Diff");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasColumnName("cellName")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Scrambles>(entity =>
            {
                entity.HasKey(e => e.ScrambleId)
                    .HasName("PK_Scrambles");

                entity.Property(e => e.ScrambleId)
                    .HasColumnName("scrambleId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CompetitionId)
                    .IsRequired()
                    .HasColumnName("competitionId")
                    .HasMaxLength(32);

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasColumnName("eventId")
                    .HasMaxLength(6);

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasColumnName("groupId")
                    .HasMaxLength(3);

                entity.Property(e => e.IsExtra).HasColumnName("isExtra");

                entity.Property(e => e.RoundId)
                    .IsRequired()
                    .HasColumnName("roundId")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Scramble)
                    .IsRequired()
                    .HasColumnName("scramble")
                    .HasMaxLength(500);

                entity.Property(e => e.ScrambleNum).HasColumnName("scrambleNum");

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Scrambles)
                    .HasForeignKey(d => d.CompetitionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Scrambles_Competitions");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Scrambles)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Scrambles_Events");

                entity.HasOne(d => d.Round)
                    .WithMany(p => p.Scrambles)
                    .HasForeignKey(d => d.RoundId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Scrambles_Rounds");
            });

            modelBuilder.Entity<ScramblesDiff>(entity =>
            {
                entity.HasKey(e => e.ScrambleId)
                    .HasName("PK_Scrambles_Diff");

                entity.ToTable("Scrambles_Diff");

                entity.Property(e => e.ScrambleId)
                    .HasColumnName("scrambleId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CompetitionId)
                    .IsRequired()
                    .HasColumnName("competitionId")
                    .HasMaxLength(32);

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasColumnName("eventId")
                    .HasMaxLength(6);

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasColumnName("groupId")
                    .HasMaxLength(3);

                entity.Property(e => e.IsExtra).HasColumnName("isExtra");

                entity.Property(e => e.RoundId)
                    .IsRequired()
                    .HasColumnName("roundId")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Scramble)
                    .IsRequired()
                    .HasColumnName("scramble")
                    .HasMaxLength(500);

                entity.Property(e => e.ScrambleNum).HasColumnName("scrambleNum");
            });
        }

        public virtual DbSet<Competitions> Competitions { get; set; }
        private DbSet<CompetitionsDiff> CompetitionsDiff { get; set; }
        public virtual DbSet<Continents> Continents { get; set; }
        private DbSet<ContinentsDiff> ContinentsDiff { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        private DbSet<CountriesDiff> CountriesDiff { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        private DbSet<EventsDiff> EventsDiff { get; set; }
        public virtual DbSet<Formats> Formats { get; set; }
        private DbSet<FormatsDiff> FormatsDiff { get; set; }
        public virtual DbSet<ImportedFiles> ImportedFiles { get; set; }
        private DbSet<Log> Log { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        private DbSet<PersonsDiff> PersonsDiff { get; set; }
        public virtual DbSet<RanksAverage> RanksAverage { get; set; }
        private DbSet<RanksAverageDiff> RanksAverageDiff { get; set; }
        public virtual DbSet<RanksSingle> RanksSingle { get; set; }
        private DbSet<RanksSingleDiff> RanksSingleDiff { get; set; }
        public virtual DbSet<Results> Results { get; set; }
        private DbSet<ResultsDiff> ResultsDiff { get; set; }
        public virtual DbSet<Rounds> Rounds { get; set; }
        private DbSet<RoundsDiff> RoundsDiff { get; set; }
        public virtual DbSet<Scrambles> Scrambles { get; set; }
        private DbSet<ScramblesDiff> ScramblesDiff { get; set; }
    }
}