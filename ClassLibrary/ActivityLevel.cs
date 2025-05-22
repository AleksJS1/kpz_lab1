using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

        public class ActivityLevel
        {
            public string Description { get; }
            public double Value { get; }

            public ActivityLevel(string description, double value)
            {
                Description = description;
                Value = value;
            }

            public override string ToString()
            {
                return Description;
            }
        }
    }
