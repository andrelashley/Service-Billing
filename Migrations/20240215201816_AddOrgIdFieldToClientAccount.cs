﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service_Billing.Migrations
{
    /// <inheritdoc />
    public partial class AddOrgIdFieldToClientAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "ClientAccounts",
                type: "int",
                nullable: true);
            
            migrationBuilder.Sql($"update Ministries " +
                $"set Acronym = 'MMHA'"
                + $"where Acronym = 'MHA';" +

                //awe geez, this is going to be a nightmare...
                $"update ClientAccounts " +
                $"set OrganizationId = Ministries.Id " +
                $"from Ministries " +
                $"where ClientAccounts.[Name] like Ministries.Acronym " +
                $"and ClientAccounts.[Name] like '%' + Ministries.Title + '%'; " + 
                
                $"update ClientAccounts " +
                $"set OrganizationId = 4 " +
                $"where ClientAccounts.[Name] like 'AF%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 7 " +
                $"where ClientAccounts.[Name] like 'CITZ%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 34 " +
                $"where ClientAccounts.[Name] like 'ECON%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 1 " +
                $"where ClientAccounts.[Name] like 'EMLI%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 34 " +
                $"where ClientAccounts.[Name] like 'ENV%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 11 " +
                $"where ClientAccounts.[Name] like 'FIN%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 12 " +
                $"where ClientAccounts.[Name] like 'FOR%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 36 " +
                $"where ClientAccounts.[Name] like 'GCPE%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 16 " +
                $"where ClientAccounts.[Name] like 'JEDI%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 39 " +
                $"where ClientAccounts.[Name] like 'LRB%' " +
                $"or ClientAccounts.[Name] like 'LBR%'; " + // and I curse the inconsistency

                $"update ClientAccounts " +
                $"set OrganizationId = 19 " +
                $"where ClientAccounts.[Name] like 'MUNI%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 40 " +
                $"where ClientAccounts.[Name] like 'PSA%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 20 " +
                $"where ClientAccounts.[Name] like 'PSFS%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 21 " +
                $"where ClientAccounts.[Name] like 'PSSG%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 22 " +
                $"where ClientAccounts.[Name] like 'SDPR%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 2 " +
                $"where ClientAccounts.[Name] like 'TACS%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 23 " +
                $"where ClientAccounts.[Name] like 'TRAN%'; " +
                
                // Now deal with all the stragglers
                $"update ClientAccounts " +
                $"set OrganizationId = 5 " +
                $"where ClientAccounts.[Name] like 'AG - Hate Crimes BC - Analytics%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 45 " +
                $"where ClientAccounts.[Name] like 'WCAT%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 5 " +
                $"where ClientAccounts.[Name] like 'AG - Hate Crimes BC - Analytics%' " +
                $"or ClientAccounts.[Name] like 'AG - Tickets Solutions Explorer Analytics%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 30 " +
                $"where ClientAccounts.[Name] like 'AG - JSB Justice Services Branch%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 37 " +
                $"where ClientAccounts.[Name] like 'HLTH%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 24 " +
                $"where ClientAccounts.[Name] like 'WLRS%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 24 " +
                $"where ClientAccounts.[Name] like 'WLRS%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 8 " +
                $"where ClientAccounts.[Name] like 'ECC%'; " +

                $"update ClientAccounts " +
                $"set OrganizationId = 46 " +
                $"where ClientAccounts.[Name] like 'IGRS%'; "

                ) ;
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "ClientAccounts");
        }
    }
}
