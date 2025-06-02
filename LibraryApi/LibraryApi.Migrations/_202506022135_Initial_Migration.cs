using FluentMigrator;

namespace LibraryApi.Migrations
{
    [Migration(202506022135)]
    public class _202506022135_Initial_Migration : Migration
    {
        public override void Up()
        {
            Create.Table("Categories")
                  .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                  .WithColumn("Title").AsString(50).NotNullable()
                  .WithColumn("AgeRange").AsInt16().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Categories");
        }
    }
}
