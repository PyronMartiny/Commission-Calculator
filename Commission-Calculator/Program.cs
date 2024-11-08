namespace Commission_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double commission = Calc(2600000, 4, 50, true);
            Console.WriteLine($"Agent commission is: R{commission}");
        }
        static double Calc(double salePrice, double agentCommission, double agencySplit, bool vat)
        {
            agencySplit = 1 - (agencySplit / 100);
            agentCommission = ((agentCommission / 100) * salePrice * agencySplit) * 0.95; // franchise fee
            if (vat)
            {
                double addvat = 1.15;
                agentCommission *= addvat;
            }
            else
            {
                double addvat = 1.0;
                agentCommission *= addvat;
            }
            return Math.Round(agentCommission, 2);
        }
    }
}
