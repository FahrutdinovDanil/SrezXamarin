using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Sqlite
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
