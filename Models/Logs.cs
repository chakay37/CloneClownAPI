﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloneClownAPI.Models
{
    [Table("Logs")]
    public class Logs
    {
        public int id { get; set; }
        public int userID { get; set; }
        public int? configID { get; set; }
        public bool status { get; set; }
        public int details { get; set; }
        public DateTime date { get; set; }
        [Column("already sent")]
        public bool alreadySent { get; set; }

        public virtual Users user { get; set; }
        public virtual Configs? config { get; set; }

    }
}