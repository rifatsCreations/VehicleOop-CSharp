using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOop.enums;

namespace VehicleOop.entities
{
    public class Car : FourWheeler
    {
        int numberofSeat;
        int numberofDoors;

        public Car(int numberofSeat, int numberofDoors, string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
        {
            this.numberofSeat = numberofSeat;
            this.numberofDoors = numberofDoors;
        }



        public int NumberofSeat { get => numberofSeat; set => numberofSeat = value; }
        public int NumberofDoors { get => numberofDoors; set => numberofDoors = value; }

        public override void Start(string startvalue = "Virtual method implemented")
        {
            base.Start(startvalue);
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Car Information\n\n Vehicle Model:{ModelNo}\n Manufacturing Year: {YearMake}\n Number of Gear: {NumberOfGear}\n Number of Seat: {numberofSeat}\n Number Of Door: {numberofDoors}\n Engine Capacity: {EngineCapacity}\n Vehicle Type: {Type}");
        }
    }
}
