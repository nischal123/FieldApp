using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldApp.Model
{
    [Table("AnimalEventsLink")]
    public class AnimalEventsLink
    {
        [PrimaryKey, AutoIncrement, Column("_AnimalEventID")]
        public int AnimalEventLocalID { get; set; }
        [MaxLength(8)]
        public int SessionID { get; set; }
        public int LocalSessionID { get; set; }
        public int EventID { get; set; }
        public string EventType { get; set; }
        public int FarmID { get; set; }
        public int AnimalID { get; set; }
        public string Note { get; set; }
        public bool IsNew { get; set; }
        public string Value { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ActionType { get; set; }

        public int? MedInventoryID { get; set; }
        public string Unit { get; set; }
        public int LocalEventID { get; set; }
    }
}
