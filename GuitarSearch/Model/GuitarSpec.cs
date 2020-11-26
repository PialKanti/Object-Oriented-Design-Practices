using GuitarSearch.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Type = GuitarSearch.Enums.Type;

namespace GuitarSearch.Model
{
    public class GuitarSpec
    {
        public Builder Builder { get; }
        public string Model { get; }
        public Type Type { get; }
        public int NumStrings { get; }
        public Wood BackWood { get; }
        public Wood TopWood { get; }

        public GuitarSpec(Builder builder, string model, Type type, int numStrings, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            NumStrings = numStrings;
            BackWood = backWood;
            TopWood = topWood;
        }

        public bool Matches(GuitarSpec guitarSpec)
        {
            if (Builder != guitarSpec.Builder)
            {
                return false;
            }
            if (!string.IsNullOrEmpty(Model) && !Model.ToLower().Equals(guitarSpec.Model.ToLower()))
            {
                return false;
            }
            if (Type != guitarSpec.Type)
            {
                return false;
            }
            if (NumStrings != guitarSpec.NumStrings)
            {
                return false;
            }
            if (BackWood != guitarSpec.BackWood)
            {
                return false; ;
            }
            if (TopWood != guitarSpec.TopWood)
            {
                return false;
            }

            return true;
        }
    }
}
