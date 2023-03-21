﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    [SQLite.Table("Groups")]
    public class Group
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("_id")]
        public int IdGroup { get; set; }

        public string Title { get; set; }
    }
}
