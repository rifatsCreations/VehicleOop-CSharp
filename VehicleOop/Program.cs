using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleOop.entities;
using VehicleOop.enums;

namespace VehicleOop
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                DoTask();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            Console.WriteLine("How many vehicle you want to create?");
            int count = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Select Operatoin\nHint\n1 --Car\n2 --Motorcycle");
                int operation = Convert.ToInt16(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        PrintCarInfo();
                        break;
                    case 2:
                        PrintMotorcycleInfo();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;

                }

            }




        }

        private static void PrintMotorcycleInfo()
        {
            Console.WriteLine("Enter Model No");
            string modelNo = Console.ReadLine();

            Console.WriteLine("Enter Make Year");
            int yearMake = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Number Of Gears");
            int numberOfGear = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Maximum power in BPH");
            int maxPower = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Maximum Torque");
            int maxTorque = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Milage Kmpl");
            int milege = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Front Break");
            string fBreak = Console.ReadLine();

            Console.WriteLine("Enter Rare Break");
            string rBreak = Console.ReadLine();

            Console.WriteLine("Enter Number Of Engine Capacity");
            int enginecapacity = Convert.ToInt16(Console.ReadLine());

        EnterVehicleType:
            Console.WriteLine("Enter Vehicle Type.\n Hints 1- Personal\n,2- Rented\n,3- Others");

            int VehicleT = Convert.ToInt16(Console.ReadLine());
            VehicleType vtype;
            try
            {
                vtype = (VehicleType)(Enum.Parse(typeof(VehicleType), VehicleT.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                vtype = VehicleType.Invalid;
                goto EnterVehicleType;
            }
            MotorCycle cycle = new MotorCycle(maxPower, maxTorque, milege, fBreak, rBreak, modelNo, yearMake, numberOfGear, enginecapacity, vtype);
            cycle.GetDetails();
            cycle.StartingMethod();
            cycle.Cooling();

            string[] list = cycle.GetExteriorDesign("Sticker,Hydrolic,Whistle,Mobile Stand,Cover");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"Sl No: {i + 1} {list[i]}");
            }
        }

        private static void PrintCarInfo()
        {
            Console.WriteLine("Enter Model No");
            string modelNo = Console.ReadLine();

            Console.WriteLine("Enter Make Year");
            int yearMake = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Number Of Gears");
            int numberOfGear = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Number Of Doors");
            int numberOfDoor = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Number Of Seats");
            int numberOfSeat = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Number Of Engine Capacity");
            int enginecapacity = Convert.ToInt16(Console.ReadLine());

        EnterVehicleType:
            Console.WriteLine("Enter Vehicle Type.\n Hints 1- Personal\n,2- Rented\n,3- Others");

            int VehicleT = Convert.ToInt16(Console.ReadLine());
            VehicleType vtype;
            try
            {
                vtype = (VehicleType)(Enum.Parse(typeof(VehicleType), VehicleT.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                vtype = VehicleType.Invalid;
                goto EnterVehicleType;
            }

            VehicleType type = VehicleType.Personal;
            Car objcar = new Car(numberOfSeat, numberOfDoor, modelNo, yearMake, numberOfGear, enginecapacity, type);
            objcar.GetDetails();
            Console.WriteLine();
            Console.WriteLine("Interior Design");
            Console.WriteLine();
            string[] designs = objcar.GetInteriorDesigns("Tissue Box,Air Fresner,Pillow,Hanging Show Piece Sticker");
            for (int j = 0; j < designs.Length; j++)
            {
                Console.WriteLine($"{j + 1} {designs[j].Trim()}");
            }
        }
    }
}
