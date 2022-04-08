//A feature introduced with c# 7 and later is pattern matching. The if statement ca use
// the is keyword in combination with declaring a local varialbe to make your code safer. 
using static System.Console;

//add or remove the "" to change the behavior.
object o = 3;
int j = 4;

if(o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}