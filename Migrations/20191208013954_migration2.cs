using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueFriendFinder.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfRegistrationInService = table.Column<DateTime>(nullable: false),
                    IsLicenseAccepted = table.Column<bool>(nullable: false),
                    VkontakteUserID = table.Column<int>(nullable: false),
                    InGameAccountNickname = table.Column<string>(nullable: true),
                    ServerOfInGameAccount = table.Column<string>(nullable: true),
                    RankedLeague = table.Column<string>(nullable: true),
                    RankedDivision = table.Column<string>(nullable: true),
                    IsSearchingForPlayingInTeam = table.Column<bool>(nullable: false),
                    IsSearchingForPlayingRankeds = table.Column<bool>(nullable: false),
                    IsSearchingJustToFindNewFriends = table.Column<bool>(nullable: false),
                    CommentAboutHimself = table.Column<string>(nullable: true),
                    PrefferedRole1 = table.Column<string>(nullable: true),
                    PrefferedRole2 = table.Column<string>(nullable: true),
                    WhoIAmSearchingForComment = table.Column<string>(nullable: true),
                    MostPlayedChampions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
