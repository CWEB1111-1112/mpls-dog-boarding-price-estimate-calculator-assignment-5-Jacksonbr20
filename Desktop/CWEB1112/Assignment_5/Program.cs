using System;

namespace assignment_5
{
    class Estimate
    {
        public string serviceCode;
        public int numberDays;
        public int weight;
        public string dogsName;
        public string ownerName;
        public double OVERNIGHT = 75.00;
        public double A = 169.00;
        public double C = 112.00;
        public double total;
        
        public void EstimateRate()
        {
            serviceCode.ToUpper();
        }

        // public override string ToString(){
        //     return String.Format($"The total is ${this.total}");
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Estimate aEstimate = new Estimate();
            Console.WriteLine("What is the owners name?");
            aEstimate.ownerName = Console.ReadLine();

            Console.WriteLine("What is the dogs name?");
            aEstimate.dogsName = Console.ReadLine();

            Console.WriteLine("What is the dogs weight?");
            aEstimate.weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many days?");
            aEstimate.numberDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the the service code? (A - for night stay or C - for night, bath, and grooming)");
            aEstimate.serviceCode = Console.ReadLine();


            while(aEstimate.serviceCode != "A" && aEstimate.serviceCode != "C")
            {
                Console.WriteLine("Error incorrect code?");
                Console.WriteLine("(A - for night stay or C - for night, bath, and grooming");
                aEstimate.serviceCode = Console.ReadLine(); 
                aEstimate.serviceCode.ToUpper();
            }
            
            if(aEstimate.serviceCode == "A"){
                aEstimate.total += aEstimate.numberDays * aEstimate.OVERNIGHT + aEstimate.A;
            }else if(aEstimate.serviceCode == "C"){
                aEstimate.total += aEstimate.numberDays * aEstimate.OVERNIGHT + aEstimate.C;
            }

            Console.WriteLine($"{aEstimate.ownerName} and their dog {aEstimate.dogsName} stayed for {aEstimate.numberDays} days");
            Console.WriteLine($"With a total of ${aEstimate.total}");
        }
    }
}
