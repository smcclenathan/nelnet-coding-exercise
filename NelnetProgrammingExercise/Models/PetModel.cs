using System;
using System.Collections.Generic;
using System.Text;

namespace NelnetProgrammingExercise.Models
{
    public class PetModel
    {
        public string Name { get; set; }
        public PetClassification Classification { get; set; }
        public PetType Type { get; set; }

        public double Weight { get; set; }

        public WeightClass GetWeightClass()
        {
            if( Weight>0 && Weight<=1.0)
            {
                return WeightClass.ExtraSmall;
            }
            if (Weight > 1.0 && Weight <= 5.0)
            {
                return WeightClass.Small;
            }
            if (Weight > 5.0 && Weight <= 15.0)
            {
                return WeightClass.Medium;
            }
            if (Weight > 15.0 && Weight <= 30.0)
            {
                return WeightClass.Large;
            }
            if (Weight > 30.0)
            {
                return WeightClass.ExtraLarge;
            }

            throw new Exception("Invalid Weight");
        }
    }
}
