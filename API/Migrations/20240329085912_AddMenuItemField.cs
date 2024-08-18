using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuItemField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 762, DateTimeKind.Local).AddTicks(2625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 762, DateTimeKind.Local).AddTicks(2302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(7361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(6965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(3763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(3423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(2146));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "MenuItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(5558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 762, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(5222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 762, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(77),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(9687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(5975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(2750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(2146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 15, 59, 12, 761, DateTimeKind.Local).AddTicks(256));
        }
    }
}
