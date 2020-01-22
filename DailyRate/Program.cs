using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
            Console.ReadKey();
        }

        void run()
        {
            double dailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of days: ");
            writeFee(calculateFee(dailyRate, noOfDays));
        }

        private double readDouble(string v)
        {
            Console.Write(v);
            return Double.Parse(Console.ReadLine());
        }

        private int readInt(string v)
        {
            Console.Write(v);
            return int.Parse(Console.ReadLine());
        }

        private double calculateFee(double dailyRate, int noOfDays) => dailyRate * noOfDays;

        private void writeFee(double v) => Console.WriteLine($"The consultant's fee is {v * 1.1}.");
    }
}
