//using static System.Console;

//string path C:\Users\Devan\Documents\Repos\C# 10 and .NET 6 Book\Chapter03\Chapter03
string path = @"C:\Users\Devan\Documents\Repos\C# 10 and .NET 6 Book\Chapter03\Chapter03";
Console.WriteLine($"Press 'R' for Read or 'W' for Write: ");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();

Stream? s;

if(key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);
}
else
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write);
}
string message;

switch (s)
{
    case FileStream writeableFile when s.CanWrite:
        message = "The stream is a file that I can write to.";
        break;
    case FileStream readOnlyFile:
        message = "The stream is a read only fine.";
        break;
    case MemoryStream ms:
        message = "The stream is a memory address.";
        break;
    default: //always evaluated Last despite its current position
        message = "The stream is some other type";
        break;
}

Console.WriteLine(message);

//switch expressions

message = s switch
{
    FileStream writeableFile when s.CanWrite
    => "The stream is a file that I can write to",
    FileStream readOnlyFile
    => "The stream is a read only file",
    MemoryStream ms
    => "The stream is a memory address.",
    null
    => "The stream is null.",
    _
        => "The stream is some other type"
};

Console.WriteLine(message);