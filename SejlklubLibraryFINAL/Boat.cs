using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class Boat
    {
        #region Properties
        public string BoatType { get; set; }
        public string Model { get; set; }
        public string Motor { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public int BuildYear { get; set; }
        public string Name { get; set; }
        public string BoatNumber { get; set; }
        public Guid Id { get; set; }
        #endregion

        #region Constructor
        public Boat(string boatType, string model, string motor, double length, double width, double depth, int buildYear, string name, string boatNumber, Guid Id)
        {
            BoatType = boatType;
            Model = model;
            Motor = motor;
            Length = length;
            Width = width;
            Depth = depth;
            BuildYear = buildYear;
            Name = name;
            BoatNumber = boatNumber;
            this.Id = Id;

        }
        public Boat(string boatType, string model, double length, double width, double depth, int buildYear, string name, string boatNumber, Guid Id)
        {
            BoatType = boatType;
            Model = model;
            Length = length;
            Width = width;
            Depth = depth;
            BuildYear = buildYear;
            Name = name;
            BoatNumber = boatNumber;
            this.Id = Id;

        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Boattype - {BoatType}\nModel - {Model}\nMotor - {Motor}\n Length/Width/Depth - {Length}m - {Width}m - {Depth}m\nBuilt in {BuildYear}\nName: {Name}\n Boat Number: {BoatNumber}\n ID: {Id}";
        }
        #endregion
    }
}
