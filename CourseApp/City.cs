using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class City : Settlement
    {
        public City()
        : base("Unnamed")
        {
        }

        public City(string name)
        : base(name, 1)
        {
        }

        public City(string name, int population)
        : this(name, population, 0)
        {
        }

        public City(string name, int population, int square)
        {
            Name = name;
            Population = population;
            Square = square;
        }

        public override int Population
        {
            set
            {
                if (value >= 0 && value < 70000000)
                {
                    base.Population = value;
                }
                else
                {
                    throw new System.Exception("Wrong population");
                }
            }
        }

        public override int Square
        {
            get
            {
                return base.Square;
            }

            set
            {
                if (value >= 0 && value <= 100000000)
                {
                    base.Square = value;
                }
                else
                {
                    throw new System.Exception("Wrong square");
                }
            }
        }
    }
}
