namespace UNDPSerbia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2a8f126b-174a-4622-8768-7a695de95b7d', N'admin@undpserbia.com', 0, N'AOqMc5eHB7TLF6xMTg1k10Tz3XKcoBLbJVOt5SI7A5T91PMGUxaxurTDaSFMayYsIQ==', N'952e6cf8-134b-47b3-a164-6d4d09e09b40', NULL, 0, 0, NULL, 1, 0, N'admin@undpserbia.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'55dc476b-382b-4d78-888e-0c2283f44441', N'guest@undpserbia.com', 0, N'ALF4LR5vWN4dpAIbV86O3TpOCQBBSMN+NB6tbyrspCPrYTlLWXK2KhfJE1F0jXToSQ==', N'508f7e93-14c3-4d30-8f0f-e4c328ae96d9', NULL, 0, 0, NULL, 1, 0, N'guest@undpserbia.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6403f917-3715-43a0-83da-4df6805cbcb0', N'CanManageEmployees')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2a8f126b-174a-4622-8768-7a695de95b7d', N'6403f917-3715-43a0-83da-4df6805cbcb0')

");
        }
        
        public override void Down()
        {
        }
    }
}
