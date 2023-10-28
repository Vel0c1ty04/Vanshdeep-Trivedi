// See https://aka.ms/new-console-template for more information
Console.Write("Enter id (only 1 is available :) ): ");
int ID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter what you want to do (database or calculate): ");
string action = Console.ReadLine();
if (action =="database" && ID == 1)
{
    Console.WriteLine("Name = Bhupinder");
    Console.WriteLine("City = USA");
    Console.WriteLine("Basic Salary = 1000000");
    Console.WriteLine("Dearness Allowance = 10000");
    Console.WriteLine("House rent = 1000");
}
if (action == "calculate" && ID == 1)
{
    int basic = 1000000;
    int da = 10000;
    int hra = 1000;
    int total = basic + basic * da / 100 + basic * hra / 100;
    Console.WriteLine(total);
}
Console.ReadLine();
