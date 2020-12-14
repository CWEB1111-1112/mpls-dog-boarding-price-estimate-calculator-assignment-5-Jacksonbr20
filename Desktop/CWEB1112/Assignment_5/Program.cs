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
        double OVERNIGHT = 75.00;
        double A = 169.00;
        double C = 112.00;
        double total;
        
        public void EstimateRate()
        {
            while(this.serviceCode != "A" && this.serviceCode != "C")
            {
                Console.WriteLine("Error incorrect code?");
                Console.WriteLine("(A - for night stay or C - for night, bath, and grooming");
                this.serviceCode = Console.ReadLine(); 
            }
            if(this.serviceCode == "A"){
                this.total += this.numberDays * OVERNIGHT + A;
            }else if(this.serviceCode == "C"){
                this.total += this.numberDays * OVERNIGHT + C;
            }
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

            Console.WriteLine("How many days");
            aEstimate.numberDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the the service code? (A - for night stay or C - for night, bath, and grooming)");
            aEstimate.EstimateRate.serviceCode = Console.ReadLine();
            aEstimate.serviceCode.ToUpper();
            Console.WriteLine($"{aEstimate.ownerName} and their dog {aEstimate.dogsName} stayed for {aEstimate.numberDays} days");
            Console.WriteLine($"With a total of ${aEstimate.total}");
        }
    }
}
