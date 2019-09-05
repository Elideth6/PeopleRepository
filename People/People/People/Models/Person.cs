using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace People.Models
{
    [Table("TBL_people")]
   public class Person
    {
        //Miembro: Properties
        [PrimaryKey, AutoIncrement]

        public int id { get; send; }

        [MaxLength(50), Unique]

        public string Name { get; set; }
    }
}
