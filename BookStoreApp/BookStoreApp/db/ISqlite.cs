using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreApp.db
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
    }
}
