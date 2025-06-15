using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOop.enums;

namespace VehicleOop.entities
{
    public class MotorCycle : TwoWheeler
    {
        int maximumPowerinBPH;
        int maximumTorInNM;
        int milageKMPL;
        string frontBreak;
        string rearBreak;

        public MotorCycle(int maximumPowerinBPH, int maximumTorInNM, int milageKMPL, string frontBreak, string rearBreak, string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
        {
            this.maximumPowerinBPH = maximumPowerinBPH;
            this.maximumTorInNM = maximumTorInNM;
            this.milageKMPL = milageKMPL;
            this.frontBreak = frontBreak;
            this.rearBreak = rearBreak;
        }



        public int MaximumPowerinBPH { get => maximumPowerinBPH; set => maximumPowerinBPH = value; }
        public int MaximumTorInNM { get => maximumTorInNM; set => maximumTorInNM = value; }
        public int MilageKMPL { get => milageKMPL; set => milageKMPL = value; }
        public string FrontBreak { get => frontBreak; set => frontBreak = value; }
        public string RearBreak { get => rearBreak; set => rearBreak = value; }

        public override void GetDetails()
        {
            Console.WriteLine($"Car Information\n\n Vehicle Model:{ModelNo}\n Manufacturing Year: {YearMake}\n Number of Gear: {NumberOfGear}\n Engine Capacity: {EngineCapacity}\n Vehicle Type: {Type}\n Maximum Power: {maximumPowerinBPH}\n Maximum Torque {maximumTorInNM}\n Milege{milageKMPL}\n Front Break: {frontBreak}\n Rear Break{rearBreak}");
        }

        public override void StartingMethod(string opr = "Kick & self")
        {
            Console.WriteLine("In child class start " + opr);
        }
    }
}
