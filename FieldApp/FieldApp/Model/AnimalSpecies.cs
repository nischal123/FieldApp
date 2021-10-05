using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldApp.Model
{
    [Table("AnimalSpecies")]
    public class AnimalSpecies
    {
        [PrimaryKey, AutoIncrement, Column("_Id")]
        public int LocalID { get; set; }
        public int SpeciesID { get; set; }
        public int GenderTypeID { get; set; }
        public int BreedTypeID { get; set; }
        public string SpeciesName { get; set; }
        public string GenderTypeName { get; set; }
        public string BreedTypeName { get; set; }
        public string Sex { get; set; }

    }
}
