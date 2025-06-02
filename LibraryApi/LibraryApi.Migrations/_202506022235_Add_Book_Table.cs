using FluentMigrator;
using System.Data;

namespace LibraryApi.Migrations
{
    [Migration(202506022235)]
    public class _202506022235_Add_Book_Table : Migration
    {
        public override void Up()
        {
            Create.Table("Boks")
               .WithColumn("Id").AsInt32().PrimaryKey().Identity()
               .WithColumn("Title").AsString(50).NotNullable()
               .WithColumn("Author").AsString(50).NotNullable()
               .WithColumn("Description").AsString(200).NotNullable()
               .WithColumn("PublishDate").AsDateTime2().NotNullable()
               .WithColumn("PageCount").AsInt32().NotNullable()
               .WithColumn("CategoryId").AsInt32().NotNullable();

            Create.ForeignKey("FK_Books_Categories")
                .FromTable("Boks")
                .ForeignColumns("CategoryId")
                .ToTable("Categories")
                .PrimaryColumn("Id")
                .OnDeleteOrUpdate(Rule.None);
        }

        public override void Down()
        {
            Delete.ForeignKey("FK_Books_Categories").OnTable("Boks");
            Delete.Table("Boks");
        }
    }
}
