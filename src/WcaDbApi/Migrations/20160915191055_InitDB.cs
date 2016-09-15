using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WcaDbApi.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions_Diff",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 32, nullable: false, defaultValueSql: "''"),
                    cellName = table.Column<string>(maxLength: 45, nullable: false, defaultValueSql: "''"),
                    cityName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    countryId = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    day = table.Column<short>(nullable: false, defaultValueSql: "0"),
                    endDay = table.Column<short>(nullable: false, defaultValueSql: "0"),
                    endMonth = table.Column<short>(nullable: false, defaultValueSql: "0"),
                    eventSpecs = table.Column<string>(type: "text", nullable: false),
                    information = table.Column<string>(type: "text", nullable: true),
                    latitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    longitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    month = table.Column<short>(nullable: false, defaultValueSql: "0"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    organiser = table.Column<string>(type: "text", nullable: false),
                    venue = table.Column<string>(maxLength: 240, nullable: false, defaultValueSql: "''"),
                    venueAddress = table.Column<string>(maxLength: 120, nullable: true),
                    venueDetails = table.Column<string>(maxLength: 120, nullable: true),
                    wcaDelegate = table.Column<string>(type: "text", nullable: false, defaultValueSql: "''"),
                    website = table.Column<string>(maxLength: 200, nullable: true),
                    year = table.Column<short>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions_Diff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    latitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    longitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    recordName = table.Column<string>(type: "char(3)", nullable: false, defaultValueSql: "''"),
                    zoom = table.Column<byte>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Continents_Diff",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    latitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    longitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    recordName = table.Column<string>(type: "char(3)", nullable: false, defaultValueSql: "''"),
                    zoom = table.Column<byte>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents_Diff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Countries_Diff",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    continentId = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    iso2 = table.Column<string>(type: "char(2)", nullable: true),
                    latitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    longitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    zoom = table.Column<byte>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries_Diff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    cellName = table.Column<string>(maxLength: 45, nullable: false, defaultValueSql: "''"),
                    format = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    name = table.Column<string>(maxLength: 54, nullable: false, defaultValueSql: "''"),
                    rank = table.Column<int>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Events_Diff",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    cellName = table.Column<string>(maxLength: 45, nullable: false, defaultValueSql: "''"),
                    format = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    name = table.Column<string>(maxLength: 54, nullable: false, defaultValueSql: "''"),
                    rank = table.Column<int>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events_Diff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Formats",
                columns: table => new
                {
                    id = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formats", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Formats_Diff",
                columns: table => new
                {
                    id = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formats_Diff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ImportedFiles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    imported = table.Column<DateTime>(type: "datetime", nullable: false),
                    wcaFileName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportedFiles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Filename = table.Column<string>(maxLength: 200, nullable: true),
                    Info = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persons_Diff",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    subid = table.Column<byte>(nullable: false, defaultValueSql: "1"),
                    countryId = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    gender = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    name = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons_Diff", x => new { x.id, x.subid });
                });

            migrationBuilder.CreateTable(
                name: "RanksAverage",
                columns: table => new
                {
                    personId = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    eventId = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    best = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    continentRank = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    countryRank = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    worldRank = table.Column<int>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RanksAverage", x => new { x.personId, x.eventId });
                });

            migrationBuilder.CreateTable(
                name: "RanksAverage_Diff",
                columns: table => new
                {
                    personId = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    eventId = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    best = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    continentRank = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    countryRank = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    worldRank = table.Column<int>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RanksAverage_Diff", x => new { x.personId, x.eventId });
                });

            migrationBuilder.CreateTable(
                name: "RanksSingle",
                columns: table => new
                {
                    personId = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    eventId = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    best = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    continentRank = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    countryRank = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    worldRank = table.Column<int>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RanksSingle", x => new { x.personId, x.eventId });
                });

            migrationBuilder.CreateTable(
                name: "RanksSingle_Diff",
                columns: table => new
                {
                    personId = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    eventId = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    best = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    continentRank = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    countryRank = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    worldRank = table.Column<int>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RanksSingle_Diff", x => new { x.personId, x.eventId });
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    competitionId = table.Column<string>(maxLength: 32, nullable: false, defaultValueSql: "''"),
                    eventId = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    roundId = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    personId = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    average = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    best = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    formatId = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    personCountryId = table.Column<string>(maxLength: 50, nullable: true),
                    personName = table.Column<string>(maxLength: 80, nullable: true),
                    pos = table.Column<short>(nullable: false, defaultValueSql: "'0'"),
                    regionalAverageRecord = table.Column<string>(type: "char(3)", nullable: true),
                    regionalSingleRecord = table.Column<string>(type: "char(3)", nullable: true),
                    value1 = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    value2 = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    value3 = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    value4 = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    value5 = table.Column<int>(nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => new { x.competitionId, x.eventId, x.roundId, x.personId });
                });

            migrationBuilder.CreateTable(
                name: "Results_Diff",
                columns: table => new
                {
                    competitionId = table.Column<string>(maxLength: 32, nullable: false, defaultValueSql: "''"),
                    eventId = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    roundId = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    personId = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    average = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    best = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    formatId = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    personCountryId = table.Column<string>(maxLength: 50, nullable: true),
                    personName = table.Column<string>(maxLength: 80, nullable: true),
                    pos = table.Column<short>(nullable: false, defaultValueSql: "'0'"),
                    regionalAverageRecord = table.Column<string>(type: "char(3)", nullable: true),
                    regionalSingleRecord = table.Column<string>(type: "char(3)", nullable: true),
                    value1 = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    value2 = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    value3 = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    value4 = table.Column<int>(nullable: false, defaultValueSql: "'0'"),
                    value5 = table.Column<int>(nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results_Diff", x => new { x.competitionId, x.eventId, x.roundId, x.personId });
                });

            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    id = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    cellName = table.Column<string>(maxLength: 45, nullable: false, defaultValueSql: "''"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    rank = table.Column<int>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rounds_Diff",
                columns: table => new
                {
                    id = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    cellName = table.Column<string>(maxLength: 45, nullable: false, defaultValueSql: "''"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    rank = table.Column<int>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds_Diff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Scrambles_Diff",
                columns: table => new
                {
                    scrambleId = table.Column<long>(nullable: false, defaultValueSql: "0"),
                    competitionId = table.Column<string>(maxLength: 32, nullable: false),
                    eventId = table.Column<string>(maxLength: 6, nullable: false),
                    groupId = table.Column<string>(maxLength: 3, nullable: false),
                    isExtra = table.Column<byte>(nullable: false),
                    roundId = table.Column<string>(type: "char(1)", nullable: false),
                    scramble = table.Column<string>(maxLength: 500, nullable: false),
                    scrambleNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scrambles_Diff", x => x.scrambleId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    continentId = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    iso2 = table.Column<string>(type: "char(2)", nullable: true),
                    latitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    longitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    zoom = table.Column<byte>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.id);
                    table.ForeignKey(
                        name: "FK_Countries_Continents",
                        column: x => x.continentId,
                        principalTable: "Continents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 32, nullable: false, defaultValueSql: "''"),
                    cellName = table.Column<string>(maxLength: 45, nullable: false, defaultValueSql: "''"),
                    cityName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    countryId = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    day = table.Column<short>(nullable: false, defaultValueSql: "0"),
                    endDay = table.Column<short>(nullable: false, defaultValueSql: "0"),
                    endMonth = table.Column<short>(nullable: false, defaultValueSql: "0"),
                    eventSpecs = table.Column<string>(type: "text", nullable: false),
                    information = table.Column<string>(type: "text", nullable: true),
                    latitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    longitude = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    month = table.Column<short>(nullable: false, defaultValueSql: "0"),
                    name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    organiser = table.Column<string>(type: "text", nullable: false),
                    venue = table.Column<string>(maxLength: 240, nullable: false, defaultValueSql: "''"),
                    venueAddress = table.Column<string>(maxLength: 120, nullable: true),
                    venueDetails = table.Column<string>(maxLength: 120, nullable: true),
                    wcaDelegate = table.Column<string>(type: "text", nullable: false),
                    website = table.Column<string>(maxLength: 200, nullable: true),
                    year = table.Column<short>(nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Competitions_Countries",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    subid = table.Column<byte>(nullable: false, defaultValueSql: "1"),
                    countryId = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    gender = table.Column<string>(type: "char(1)", nullable: false, defaultValueSql: "''"),
                    name = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => new { x.id, x.subid });
                    table.ForeignKey(
                        name: "FK_Persons_Countries",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scrambles",
                columns: table => new
                {
                    scrambleId = table.Column<long>(nullable: false, defaultValueSql: "0"),
                    competitionId = table.Column<string>(maxLength: 32, nullable: false),
                    eventId = table.Column<string>(maxLength: 6, nullable: false),
                    groupId = table.Column<string>(maxLength: 3, nullable: false),
                    isExtra = table.Column<byte>(nullable: false),
                    roundId = table.Column<string>(type: "char(1)", nullable: false),
                    scramble = table.Column<string>(maxLength: 500, nullable: false),
                    scrambleNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scrambles", x => x.scrambleId);
                    table.ForeignKey(
                        name: "FK_Scrambles_Competitions",
                        column: x => x.competitionId,
                        principalTable: "Competitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scrambles_Events",
                        column: x => x.eventId,
                        principalTable: "Events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scrambles_Rounds",
                        column: x => x.roundId,
                        principalTable: "Rounds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_countryId",
                table: "Competitions",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_continentId",
                table: "Countries",
                column: "continentId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_countryId",
                table: "Persons",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_Scrambles_competitionId",
                table: "Scrambles",
                column: "competitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Scrambles_eventId",
                table: "Scrambles",
                column: "eventId");

            migrationBuilder.CreateIndex(
                name: "IX_Scrambles_roundId",
                table: "Scrambles",
                column: "roundId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competitions_Diff");

            migrationBuilder.DropTable(
                name: "Continents_Diff");

            migrationBuilder.DropTable(
                name: "Countries_Diff");

            migrationBuilder.DropTable(
                name: "Events_Diff");

            migrationBuilder.DropTable(
                name: "Formats");

            migrationBuilder.DropTable(
                name: "Formats_Diff");

            migrationBuilder.DropTable(
                name: "ImportedFiles");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Persons_Diff");

            migrationBuilder.DropTable(
                name: "RanksAverage");

            migrationBuilder.DropTable(
                name: "RanksAverage_Diff");

            migrationBuilder.DropTable(
                name: "RanksSingle");

            migrationBuilder.DropTable(
                name: "RanksSingle_Diff");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Results_Diff");

            migrationBuilder.DropTable(
                name: "Rounds_Diff");

            migrationBuilder.DropTable(
                name: "Scrambles");

            migrationBuilder.DropTable(
                name: "Scrambles_Diff");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Rounds");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Continents");
        }
    }
}
