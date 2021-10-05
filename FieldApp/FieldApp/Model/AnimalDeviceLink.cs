using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldApp.Model
{
    [Table("AnimalDeviceLink")]
    public class AnimalDeviceLink
    {

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int LocalID { get; set; }
        [MaxLength(8)]

        public int ID { get; set; }
        public int DeviceID { get; set; }
        public int AnimalDeviceMTMID { get; set; }
        public int DeviceTypeID { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public string RFID { get; set; }
        public string Description { get; set; }
        public int DeviceTagID { get; set; }
        public string Address { get; set; }
        public int? GeoEntDetailsID { get; set; }
        public DateTime LastMessageReceived { get; set; }
        public bool isLinked { get; set; }
        public int AnimalID { get; set; }

        public int ServerAnimalID { get; set; }
        public int? LocalAnimalID { get; set; }
        public string AnimalRFID { get; set; }
        public string GFarmRFID { get; set; }
        public string Note { get; set; }
        //public int FarmID { get; set; }
        public DateTime? LinkedDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsNew { get; set; }
        public bool IsEdited { get; set; }
        public string SessionName { get; set; }
        public DateTime LinkDateForLINQ { get; set; }
        public string LinkedDateStr { get; set; }
        public string EndDateStr { get; set; }
        public int SessionID { get; set; }
        public int LocalSessionID { get; set; }

    }
}
