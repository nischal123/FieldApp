using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldApp.Model
{
    public class Animal
    {

        [PrimaryKey, AutoIncrement, Column("_Localid")]
        public int LocalAnimalID { get; set; }
        [MaxLength(8)]
        public int AnimalID { get; set; }
        public string RFID { get; set; }
        public string NLISVID { get; set; }
        public string NLISRFID { get; set; }
        public string GFarmVID { get; set; }
        public string GFarmRFID { get; set; }
        public string VisualTagDeviceVID { get; set; }
        public int? TrackingTagDeviceID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string Age { get; set; }
        public string Species { get; set; }
        public string Status { get; set; }
        public string BreedText { get; set; }
        public string GroupName { get; set; }
        public string AnimalWeight { get; set; }
        public string AnimalWeightDate { get; set; }
        public string CalcAge { get; set; }
        public bool IsNew { get; set; }
        public bool IsEdited { get; set; }
        public int DamID { get; set; }
        public int SireID { get; set; }
        public int AnimalGroupID { get; set; }
        public int SpeciesID { get; set; }
        public int BreedID { get; set; }
        public int GenderTypeID { get; set; }
        public string GenderTypeName { get; set; }
        public int FarmID { get; set; }
    }
}
