using static System.Console;
//while loop
int x = 10;

while(x > 0)
{
    WriteLine(x);
    x--;
}
x = 0;

while(x < 11)
{
    WriteLine(x);
    x++;
}

//do statement

string? password;
int y = 0;

do
{
    Write("Enter your password: ");
    password = ReadLine();
    WriteLine($"You have {10 - y} attemps left:");
    y++;
}
while (password != "Pa$$word" && y < 10);
WriteLine("Correct!");

//for statement
for (int i = 0; i < 10; i++)
{
    WriteLine(i);
}

//foreach statement

string[] names = { "Devan", "Emi", "Sam", "Presley" };
foreach(string name in names)
{
    WriteLine(name);
}