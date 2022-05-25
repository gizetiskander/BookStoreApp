using BookStoreApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreApp.db
{
    public class CRUDOperation
    {
        readonly SQLiteConnection db;
        public CRUDOperation(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<Book>();
            db.CreateTable<Users>();
        }
        public IEnumerable<Book> GetBook()
        {
            return db.Table<Book>();
        }
        public IEnumerable<Users> GetUsers()
        {
            return db.Table<Users>();
        }

        public Book GetBookItem(int id)
        {
            return db.Get<Book>(id);
        }

        public int DelBook(int id) { return db.Delete<Book>(id); }

        public int SaveItem(Book projectModel)
        {
            if (projectModel.ID != 0)
            {
                db.Update(projectModel);
                return projectModel.ID;
            }
            else
            {
                return db.Insert(projectModel);
            }
        }

        public int SaveUsers(Users projectModel)
        {
            return db.Insert(projectModel);
        }
    }
}
