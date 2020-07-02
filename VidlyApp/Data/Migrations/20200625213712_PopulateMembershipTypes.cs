using Microsoft.EntityFrameworkCore.Migrations;

namespace VidlyApp.Data.Migrations
{
    public partial class PopulateMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into MembershipTypes(Id, Name, SignupFee, DurationInMonths, DiscountRate) Values (1, N'PayAsYouGo', 0, 0, 0)");
            migrationBuilder.Sql("Insert into MembershipTypes(Id, Name, SignupFee, DurationInMonths, DiscountRate) Values (2, N'Monthly', 30, 1, 10)");
            migrationBuilder.Sql("Insert into MembershipTypes(Id, Name, SignupFee, DurationInMonths, DiscountRate) Values (3, N'Quarterly', 90, 3, 15)");
            migrationBuilder.Sql("Insert into MembershipTypes(Id, Name, SignupFee, DurationInMonths, DiscountRate) Values (4, N'Annual', 300, 12, 20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
