﻿using static System.Console;

WriteLine("Before parsing");
Write("What is your age?: ");
string? input = ReadLine();

try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old");
}
catch (OverflowException)
{
    WriteLine($"Your age is a valid number format but it is either too big or small");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

WriteLine("After Parsing");

//catching with filters
Write("Enter an amount:");
string? amount = ReadLine();
try
{
    decimal amountValue = decimal.Parse(amount);
}
catch(FormatException) when (amount.Contains("$"))
{
    WriteLine($"Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!");
}

//checking for overflow
try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    } 
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}


