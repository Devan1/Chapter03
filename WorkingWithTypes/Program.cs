using static System.Console;
using static System.Convert;

int a = 10;
double b = a; //an int can be safely cast into a double
WriteLine(b);
double c = 9.8;
int d = (int)c; //casting type double to int
WriteLine(d); //d will lose the .8 because you are losing information in the cast. 

double g = 9.8;
int h = ToInt32(g); //ToInt32 is a method of System.Convert;
WriteLine(h);
WriteLine(h.ToString());

//converting any type to a string
int number = 12;
WriteLine(number.ToString());
bool t = true;
WriteLine(t.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());
dynamic him = new[] { "Devan", "Sam", "Emi", "Presley" };
WriteLine(him.ToString());

//converting strings to number types or datetime with .Parse()
int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");
WriteLine($"age = {age}");
WriteLine($"birthday = {birthday}");
WriteLine($"birthday = {birthday:D}");

//converting string to number types or datetime with .TryParse()
WriteLine($"How many eggs are there?: ");
string? input = ReadLine();
if(int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine($"I could not parse the input.");
}