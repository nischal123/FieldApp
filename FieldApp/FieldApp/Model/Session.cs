using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldApp.Model
{
    [Table("Session")]
    public class Session
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int LocalSessionID { get; set; }
        [MaxLength(8)]
        public int SessionID { get; set; }
        public string Name { get; set; }
        public int EventTypeID { get; set; }
        public string EventName { get; set; }
        public int GeoEntityID { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public bool IsNew { get; set; }
    }
}
