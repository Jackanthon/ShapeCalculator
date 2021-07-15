using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ASsignment1
{
    abstract class Shape
    {
        protected string name;
        protected string description;
        protected int method;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public int Method
        {
            get { return this.method; }
            set { this.method = value; } 
        }
        public abstract decimal Perimeter();
        public abstract decimal Area();
    }
}
//Write a class : Shape and add basic properties like id, name and description and method like calculate area.
//Inherit circle shape from base class and add properties like radius. 
//Add calculate area logic. Inherit square class from shape and add change the calculate area logic.
//Add property like side of square.