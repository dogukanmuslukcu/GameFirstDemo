using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    class Players
    {
        // players database like a sql server,mysql which a get a read data
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCNumber { get; set ; }
        public string BirthdayDate { get; set; }
        public int PlayerExperience { get; set; }

    }
}
