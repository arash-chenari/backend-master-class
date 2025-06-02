using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApi.Migrations
{
    [Migration(202506022331)]
    public class _202506022331_Correct_Book_Table : Migration
    {
        public override void Up()
        {
            Rename.Table("Boks").To("Books");
        }

        public override void Down()
        {
            Rename.Table("Books").To("Boks");
        }
    }
}
