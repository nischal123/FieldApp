using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldApp.Model
{
    [Table("Farms")]
    public class Farms
    {
        [PrimaryKey, AutoIncrement, Column("_Id")]

        public int LocalID { get; set; }
        public int ID { get; set; }
        public int FarmID { get; set; }
        public string FarmName { get; set; }
        public bool IsDefaultFarm { get; set; }
        public int UserID { get; set; }
        public string CRUDAccess { get; set; }
    }
}
