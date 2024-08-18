using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ReFieldName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiscriptionVN",
                table: "Units",
                newName: "DescriptionVN");

            migrationBuilder.RenameColumn(
                name: "DiscriptionEN",
                table: "Units",
                newName: "DescriptionEN");

            migrationBuilder.RenameColumn(
                name: "DiscriptionVN",
                table: "Products",
                newName: "DescriptionVN");

            migrationBuilder.RenameColumn(
                name: "DiscriptionEN",
                table: "Products",
                newName: "DescriptionEN");

            migrationBuilder.RenameColumn(
                name: "DiscriptionVN",
                table: "MenuItems",
                newName: "DescriptionVN");

            migrationBuilder.RenameColumn(
                name: "DiscriptionEN",
                table: "MenuItems",
                newName: "DescriptionEN");

            migrationBuilder.RenameColumn(
                name: "DiscriptionVN",
                table: "MenuGroups",
                newName: "DescriptionVN");

            migrationBuilder.RenameColumn(
                name: "DiscriptionEN",
                table: "MenuGroups",
                newName: "DescriptionEN");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(7339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 748, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(6926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 748, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(1239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(6747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(2832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 746, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(2438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 746, DateTimeKind.Local).AddTicks(9504));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescriptionVN",
                table: "Units",
                newName: "DiscriptionVN");

            migrationBuilder.RenameColumn(
                name: "DescriptionEN",
                table: "Units",
                newName: "DiscriptionEN");

            migrationBuilder.RenameColumn(
                name: "DescriptionVN",
                table: "Products",
                newName: "DiscriptionVN");

            migrationBuilder.RenameColumn(
                name: "DescriptionEN",
                table: "Products",
                newName: "DiscriptionEN");

            migrationBuilder.RenameColumn(
                name: "DescriptionVN",
                table: "MenuItems",
                newName: "DiscriptionVN");

            migrationBuilder.RenameColumn(
                name: "DescriptionEN",
                table: "MenuItems",
                newName: "DiscriptionEN");

            migrationBuilder.RenameColumn(
                name: "DescriptionVN",
                table: "MenuGroups",
                newName: "DiscriptionVN");

            migrationBuilder.RenameColumn(
                name: "DescriptionEN",
                table: "MenuGroups",
                newName: "DiscriptionEN");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 748, DateTimeKind.Local).AddTicks(2968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 748, DateTimeKind.Local).AddTicks(2627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(7777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(7428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(3806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(3424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 746, DateTimeKind.Local).AddTicks(9868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 746, DateTimeKind.Local).AddTicks(9504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(2438));
        }
    }
}
