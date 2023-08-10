namespace ConsoleApp10Avgust;



public class SimCard
{
    public string carrierName { get; set; }
    public string Number { get; set; }
    public decimal Tariff { get; set; }




    public decimal Balance { get; set; }


    public void increaceBalance(decimal add)
    {
        if (add <= 0)
        { return; }
        Console.WriteLine("Add:"+add);
        Balance = Balance + add;

    }
    public void Call()
    {
        if (Tariff > Balance)
        {
            Console.WriteLine("Not Enough Money on Balance");
            return;
        }
        Console.WriteLine("After call:-" +Tariff);
        Balance = Balance - Tariff;

    }

}




internal class Program
{
    static void Main(string[] args)
    {
        SimCard sim = new SimCard();
        sim.carrierName = "Nar";
        sim.Number = "994700402301";
        sim.Tariff = 100m;
        sim.Balance = 134.78M;


        Console.WriteLine(sim.carrierName);
        Console.WriteLine(sim.Number);
        Console.WriteLine(sim.Tariff);



        Console.WriteLine(sim.Balance);

        sim.increaceBalance(5);
        Console.WriteLine(sim.Balance);
        sim.Call();
        Console.WriteLine(sim.Balance);
    }


}