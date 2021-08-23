namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'452f3d1d-d6ea-4902-9541-5f178c4c080c', N'admin@Vidly.com', 0, N'AATLH09APeRXE8Zcn42HOEg+XNXZ6kk0aRNq37eiLWKXawgrwy+kgdNbq5LKLHrPzg==', N'5e31e8a5-f8cc-4b04-82aa-1d6477722446', NULL, 0, 0, NULL, 1, 0, N'admin@Vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'66a2a0b1-09cf-44db-a504-249fdc772c6b', N'Guest@Vidly.com', 0, N'APokVT8NnilKP5w5jS5LnORYoqqwxVDI5RzsnoBp+ikGNrLJdd48lO3bqOwnInJdQw==', N'20bfc782-3006-4401-90b7-7ba88597a010', NULL, 0, 0, NULL, 1, 0, N'Guest@Vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b4d4445c-0e08-4f26-a3d9-c5ade24ff63f', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'452f3d1d-d6ea-4902-9541-5f178c4c080c', N'b4d4445c-0e08-4f26-a3d9-c5ade24ff63f')

");
        }
        
        public override void Down()
        {
        }
    }
}
