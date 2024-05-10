int x = 150;
if (x is > 100) Console.WriteLine("x is greater than 100");

Console.WriteLine(GetWeightCategory(15));
Console.WriteLine(GetWeightCategory(20));
Console.WriteLine(GetWeightCategory(25));

Console.ReadLine();

string GetWeightCategory(decimal bmi) => bmi switch
{
    < 18.5m => "underweight",
    < 25m => "normal",
    < 30m => "overweight",
    _ => "obese"
};