using System;
using System.Collections.Generic;

namespace CSharpRep
{
    class Program
    {
        int[] array = new int[10];
        int value;

        public int ListMin(int[] list)
        {
            int minvalue = Int32.MaxValue;

            for (int i = 0; i < list.Length; i++)
                if (list[i] < minvalue)
                    minvalue = list[i];
            return minvalue;
        }

        public float CircleArea(ushort radius)
        {
            return 3.14f * radius * radius;
        }

        public void MyFunction(string param = "ojdå")
        {
            const int alpha = 1;
            Int32 a = alpha;
            List<Object> list = new List<Object>();

            list.Add("String");
            list.Add(alpha);

            int b = a + alpha;

            if (alpha + "" == param)
            {

            }
        }

        private void Run()
        {
            double d = 3.1;
            string s = "Hej";

            Program p = new Program();
            int minValue = p.ListMin(p.array);
            p.MyFunction("Hej");

            ElectricDrill drill = new ElectricDrill();
            PowerTool tool = new ElectricDrill();
            Object anonymousTool = new ElectricDrill();
            IChargeable chargeable = new ElectricDrill();
            
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

    }
}
