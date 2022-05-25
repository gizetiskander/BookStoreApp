using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreApp.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public int Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
