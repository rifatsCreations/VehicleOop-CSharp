using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOop.enums;
using VehicleOop.Interfaces;

namespace VehicleOop.entities
{
    public class TwoWheeler : Vehicle, IexteriorDesign
    {
        public TwoWheeler(string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
        {
            this.ModelNo = modelNo;
            this.YearMake = yearMake;
            this.NumberOfGear = numberOfGear;
            this.EngineCapacity = engineCapacity;
            this.Type = type;
        }

        protected override string ModelNo { get; set; }
        protected override int YearMake { get; set; }
        protected override int NumberOfGear { get; set; }
        protected override int EngineCapacity { get; set; }
        protected override VehicleType Type { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Details implemented from Base class");

        }
        public virtual void StartingMethod(string opr = "Kick & self")
        {
            Console.WriteLine("Kick & self");
        }
        public void Cooling()
        {
            Console.WriteLine("Autometic");
        }

        public string[] GetExteriorDesign(string design)
        {
            string[] designList = design.Split(',');
            return designList;
        }
    }
}
