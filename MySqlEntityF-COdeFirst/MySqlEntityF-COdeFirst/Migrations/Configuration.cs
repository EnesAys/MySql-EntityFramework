namespace MySqlEntityF_COdeFirst.Migrations
{
    using MySqlEntityF_COdeFirst.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MySqlEntityF_COdeFirst.Models.ContactContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(MySqlEntityF_COdeFirst.Models.ContactContext context)
        {
            IList<Contact> defaultValues = new List<Contact>();
            defaultValues.Add(new Contact() { FirstName = "Enes", LastName = "Aysan", Mail = "enes@enes.com", Phone = "05075075757" });
            defaultValues.Add(new Contact() { FirstName = "Muhammed", LastName = "Þahin", Mail = "muhammed@muhammed.com", Phone = "05555555555" });


            foreach (Contact ct in defaultValues)
                context.Contacts.Add(ct);

            base.Seed(context);

        }
    }
}
