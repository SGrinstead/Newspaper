using Newspaper.Data;

using (var context = new NewspaperContext())
{
    DataSeeder.SeedData(context);
}