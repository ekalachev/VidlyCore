﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace VidlyCore.Migrations
{
    public partial class PopulateMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT MembershipTypes ON");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationImMonths, DiscountRate) VALUES(1, 0, 0, 0)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationImMonths, DiscountRate) VALUES(2, 30, 1, 10)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationImMonths, DiscountRate) VALUES(3, 90, 3, 15)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationImMonths, DiscountRate) VALUES(4, 300, 12, 20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
