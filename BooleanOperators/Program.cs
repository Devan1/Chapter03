using static System.Console;
bool a = true;
bool b = false;
WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"AND     |a     |b");
WriteLine($"a       |{a & a,-5} | {a & b,-5}");
WriteLine($"b       |{b & a,-5} | {b & b,-5}");
WriteLine();
WriteLine($"OR      |a     |b");
WriteLine($"a       |{a | a,-5} | {a | b,-5}");
WriteLine($"b       |{b | a,-5} | {b | b,-5}");
WriteLine();
WriteLine($"XOR     |a     |b");
WriteLine($"a       |{a ^ a,-5} | {a ^ b,-5}");
WriteLine($"b       |{b ^ a,-5} | {b ^ b,-5}");
doSomething();

static bool doSomething()
{
    WriteLine();
    WriteLine("doing something");
    return true;
}

WriteLine($"a & doSomething() = {a & doSomething()}");
WriteLine($"b & doSomething() = {b & doSomething()}"); 
WriteLine($"a && doSomething() = {a && doSomething()}");
WriteLine($"b && doSomething() = {b && doSomething()}");