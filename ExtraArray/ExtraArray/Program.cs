using System.Runtime.CompilerServices;

namespace ExtraArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] array = new int[] {10, 20, 30, 40, 50, 60};

            int val = program.TelOp(array);

            Console.WriteLine(val);
        }

        private int TelOp(int[] array)
        {
            int val = 0;

            for (int i = 0; i < array.Length; i++)
            {
                val += array[i];
            }

            return val;
        }
    }
}