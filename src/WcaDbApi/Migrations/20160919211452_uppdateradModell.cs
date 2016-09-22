using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WcaDbApi.Migrations
{
  public partial class uppdateradModell : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.RenameColumn(
        name: "website", 
        table: "Competitions_Diff", 
        newName: "external_website");
      /*
      migrationBuilder.DropColumn(
                name: "website",
                table: "Competitions_Diff");
      */
      migrationBuilder.RenameColumn(
        name: "website", 
        table: "Competitions", 
        newName: "external_website");
      /*
      migrationBuilder.DropColumn(
          name: "website",
          table: "Competitions");
      */
      migrationBuilder.AddColumn<int>(
          name: "final",
          table: "Rounds_Diff",
          nullable: false,
          defaultValue: 0);

      migrationBuilder.AddColumn<int>(
          name: "final",
          table: "Rounds",
          nullable: false,
          defaultValue: 0);

      migrationBuilder.AddColumn<string>(
          name: "expected_solve_count",
          table: "Formats_Diff",
          nullable: true);

      migrationBuilder.AddColumn<string>(
          name: "sort_by",
          table: "Formats_Diff",
          nullable: true);

      migrationBuilder.AddColumn<string>(
          name: "sort_by_second",
          table: "Formats_Diff",
          nullable: true);

      migrationBuilder.AddColumn<int>(
          name: "trim_fastest_n",
          table: "Formats_Diff",
          nullable: false,
          defaultValue: 0);

      migrationBuilder.AddColumn<int>(
          name: "trim_slowest_n",
          table: "Formats_Diff",
          nullable: false,
          defaultValue: 0);

      migrationBuilder.AddColumn<string>(
          name: "expected_solve_count",
          table: "Formats",
          nullable: true);

      migrationBuilder.AddColumn<string>(
          name: "sort_by",
          table: "Formats",
          nullable: true);

      migrationBuilder.AddColumn<string>(
          name: "sort_by_second",
          table: "Formats",
          nullable: true);

      migrationBuilder.AddColumn<int>(
          name: "trim_fastest_n",
          table: "Formats",
          nullable: false,
          defaultValue: 0);

      migrationBuilder.AddColumn<int>(
          name: "trim_slowest_n",
          table: "Formats",
          nullable: false,
          defaultValue: 0);
      /*
      migrationBuilder.AddColumn<string>(
          name: "external_website",
          table: "Competitions_Diff",
          maxLength: 200,
          nullable: true);

      migrationBuilder.AddColumn<string>(
          name: "external_website",
          table: "Competitions",
          maxLength: 200,
          nullable: true);
      */
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "Final",
          table: "Rounds_Diff");

      migrationBuilder.DropColumn(
          name: "Final",
          table: "Rounds");

      migrationBuilder.DropColumn(
          name: "Expected_solve_count",
          table: "Formats_Diff");

      migrationBuilder.DropColumn(
          name: "Sort_by",
          table: "Formats_Diff");

      migrationBuilder.DropColumn(
          name: "Sort_by_second",
          table: "Formats_Diff");

      migrationBuilder.DropColumn(
          name: "Trim_fastest_n",
          table: "Formats_Diff");

      migrationBuilder.DropColumn(
          name: "Trim_slowest_n",
          table: "Formats_Diff");

      migrationBuilder.DropColumn(
          name: "Expected_solve_count",
          table: "Formats");

      migrationBuilder.DropColumn(
          name: "Sort_by",
          table: "Formats");

      migrationBuilder.DropColumn(
          name: "Sort_by_second",
          table: "Formats");

      migrationBuilder.DropColumn(
          name: "Trim_fastest_n",
          table: "Formats");

      migrationBuilder.DropColumn(
          name: "Trim_slowest_n",
          table: "Formats");

      migrationBuilder.DropColumn(
          name: "external_website",
          table: "Competitions_Diff");

      migrationBuilder.DropColumn(
          name: "external_website",
          table: "Competitions");
      /*
      migrationBuilder.AddColumn<string>(
          name: "website",
          table: "Competitions_Diff",
          maxLength: 200,
          nullable: true);

      migrationBuilder.AddColumn<string>(
          name: "website",
          table: "Competitions",
          maxLength: 200,
          nullable: true);
      */
    }
  }
}
