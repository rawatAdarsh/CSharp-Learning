ElectricityBillCalculator electricityBillCalc = new ElectricityBillCalculator();
Console.Write("Enter the number of units consumed: ");
double unitsConsumed = double.Parse(Console.ReadLine());
double billAmount = electricityBillCalc.CalculateBill(unitsConsumed);
Console.WriteLine($"The Electricity Bill for {unitsConsumed} units is: Rs. {billAmount}");

class ElectricityBillCalculator
{
    public double CalculateBill(double units)
    {
        if(units <= 100)
        {
            return units * 2; //Rate for first 100 units ins Rs. 2 per unit
        }
        else if(units >= 101 && units <= 200)
        {
            return (100 * 2) + (units - 100) * 3; //Rate for next 100 units is Rs. 3 per unit
        }
        else if(units >= 201)
        {
            return (100 * 2) + (100 * 3) + (units -200) * 5; //Rate for units above 200 is Rs. 5 per unit
        }
        return 0; // Default case (should not occur with valid input)
    }
}