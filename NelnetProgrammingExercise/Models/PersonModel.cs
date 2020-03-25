using System;
using System.Collections.Generic;
using System.Text;

namespace NelnetProgrammingExercise.Models
{
    public class PersonModel
    {
        public string Name { get; set; }
        public PetClassification PreferredClassification { get; set; }
        public PetType PreferredType { get; set; }
        public WeightClass PreferredWeight { get; set; }

        public List<PetClassification> petClassificationOverrides = new List<PetClassification>();
        public List<PetType> petTypeOverrides = new List<PetType>();
        public List<WeightClass> weightClassOverrides = new List<WeightClass>();

        public bool checkOverrides(PetModel pm)
        {
            //returns true if the pet violates an override
            return petClassificationOverrides.Contains(pm.Classification) || petTypeOverrides.Contains(pm.Type) || weightClassOverrides.Contains(pm.GetWeightClass());
        }
    }
}
