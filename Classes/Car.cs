using Day7.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Classes
{
    internal class Car:IVehicle , IDrivable
    {
        private int Gasoline { get; set; }   
        public Car( int _start_gasoline )
        {
            Gasoline = _start_gasoline;
        }
		#region Implicitly

		public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("The car is Driving");
            }
            else
            {
                Console.WriteLine("The Car Not Can Driving");
            }
        }

        public bool Refuel(int gasoline)
        {
            Gasoline = Gasoline + gasoline;
            return gasoline > 0;
        } 
        #endregion

        #region Explicitly
        void IDrivable.Move()
        {
            Console.WriteLine("Car Is Move ");
        }
		void IDrivable.Accelerate()
        {
            Console.WriteLine("Accelerate Is Down");
        }
        void IDrivable.Drive()
        {
            Console.WriteLine("The Car is Driving ");
        } 
        #endregion
    }
}
