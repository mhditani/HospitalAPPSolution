using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAPP.Migrations
{
    /// <inheritdoc />
    public partial class Now : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stay",
                table: "Stay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedure",
                table: "Procedure");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescribes",
                table: "Prescribes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Physician",
                table: "Physician");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nurse",
                table: "Nurse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medication",
                table: "Medication");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AffiliatedWith",
                table: "AffiliatedWith");

            migrationBuilder.RenameTable(
                name: "Stay",
                newName: "Stays");

            migrationBuilder.RenameTable(
                name: "Room",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "Procedure",
                newName: "Procedures");

            migrationBuilder.RenameTable(
                name: "Prescribes",
                newName: "Prescribess");

            migrationBuilder.RenameTable(
                name: "Physician",
                newName: "Physicians");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameTable(
                name: "Nurse",
                newName: "Nurses");

            migrationBuilder.RenameTable(
                name: "Medication",
                newName: "Medications");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointments");

            migrationBuilder.RenameTable(
                name: "AffiliatedWith",
                newName: "AffiliatedWiths");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stays",
                table: "Stays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescribess",
                table: "Prescribess",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Physicians",
                table: "Physicians",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nurses",
                table: "Nurses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medications",
                table: "Medications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AffiliatedWiths",
                table: "AffiliatedWiths",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stays",
                table: "Stays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescribess",
                table: "Prescribess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Physicians",
                table: "Physicians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nurses",
                table: "Nurses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medications",
                table: "Medications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AffiliatedWiths",
                table: "AffiliatedWiths");

            migrationBuilder.RenameTable(
                name: "Stays",
                newName: "Stay");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "Room");

            migrationBuilder.RenameTable(
                name: "Procedures",
                newName: "Procedure");

            migrationBuilder.RenameTable(
                name: "Prescribess",
                newName: "Prescribes");

            migrationBuilder.RenameTable(
                name: "Physicians",
                newName: "Physician");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameTable(
                name: "Nurses",
                newName: "Nurse");

            migrationBuilder.RenameTable(
                name: "Medications",
                newName: "Medication");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appointment");

            migrationBuilder.RenameTable(
                name: "AffiliatedWiths",
                newName: "AffiliatedWith");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stay",
                table: "Stay",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedure",
                table: "Procedure",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescribes",
                table: "Prescribes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Physician",
                table: "Physician",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nurse",
                table: "Nurse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medication",
                table: "Medication",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AffiliatedWith",
                table: "AffiliatedWith",
                column: "Id");
        }
    }
}
