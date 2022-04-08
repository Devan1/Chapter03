using static System.Console;
int number = (new Random()).Next(1, 7);
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break; //jumps to end of switch statement
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: //multiple case section
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}

WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");