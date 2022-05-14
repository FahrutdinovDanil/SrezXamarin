using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Sqlite
{
    [Table("Cars")]
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
