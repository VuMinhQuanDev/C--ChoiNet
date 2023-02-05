// See https://aka.ms/new-console-template for more information

static void Main()
{
    object objectValue = "Hello,";
    char[] characterArray = { 'a', 'f', 'd', 'c', 'e', 'b' };
    System.Text.StringBuilder buffer = new StringBuilder();
    buffer.Append(characterArray);
    buffer.Sort();
    buffer.Insert(0, objectValue);
    Console.WriteLine(buffer);
}

Main();

Console.WriteLine("Hello, World!");
