using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Sqlite
{
    public class ProjectsRepository
    {
        SQLiteConnection database;
        public ProjectsRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Car>();
        }
        public IEnumerable<Car> GetItems()
        {
            return database.Table<Car>().ToList();
        }
        public Car GetItem(int id)
        {
            return database.Get<Car>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Car>(id);
        }
        public int SaveItem(Car item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
