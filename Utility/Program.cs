using System.Diagnostics;

namespace Utility
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            /*
            using var db = new UtilityDbContext();

            Debug.WriteLine($"Database path: {db.DbPath}.");

            db.Add(new FurnitureCollection { Id = "test_Id1", Name = "Test_Name1"});
            db.Add(new FurnitureCollection { Id = "test_Id2", Name = "Test_Name2"});
            db.Add(new FurnitureCollection { Id = "test_Id3", Name = "Test_Name3"});
            db.Add(new FurnitureCollection { Id = "test_Id3", Name = "Test_Name3"});
            db.Add(new FurnitureCollection { Id = "test_Id3", Name = "Test_Name3"});
            db.Add(new FurnitureCollection { Id = "test_Id3", Name = "Test_Name3"});
            db.Add(new FurnitureCollection { Id = "test_Id3", Name = "Test_Name3"});
            db.SaveChanges();

            // Read
            var collection = db.Collections
                .OrderBy(x => x.Id)
                .First();

            // Update
            collection.Name = "Changed Test Name";
            collection.Elements.Add(
                new FurnitureElement { Name = "divan name", Description = "o4en krutoi divan", Id = collection.Id + "_2_elem_id" });
            db.SaveChanges();*/
        }
    }
}