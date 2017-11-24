using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpRep
{
    public class Hammer : PowerTool
    {
        private bool _canDrill;

        public override bool CanDrill
        {
            get { return _canDrill; }
            set { _canDrill = value; }
        }

        public override bool Use()
        {
            Console.WriteLine("Hammering away");
            return true;
        }
    }

    public class ElectricDrill : PowerTool, IChargeable
    {
        private bool _canDrill = true;
        private int charge = 10;

        public override bool CanDrill
        {
            get { return _canDrill; }
            set { _canDrill = value; }
        }

        public void Charge()
        {
            Console.WriteLine("Charging....");
            charge = 10;
        }

        public override bool Use()
        {
            if (charge > 0)
            {
                Console.WriteLine("Drilling away");
                charge--;
                return true;
            }
           
            Console.WriteLine(".... No Charge");
            return false;
           
        }
    }

    public abstract class PowerTool
    {
        public abstract bool CanDrill { get; set; }
        public virtual bool Use()
        {
            Console.WriteLine("Should be overridden in subclasses");
            throw new NotImplementedException();
        }
    }

    public interface IChargeable
    {
        void Charge();
    }
}
