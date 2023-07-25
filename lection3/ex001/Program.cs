// first method

void Method1()
{
    Console.WriteLine("author ...");
}
// Method();


// sexond method

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "text message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "text", count: 4);
// Method21(count:4, msg:"new text");

// third method

int method3()
{
    return DateTime.Now.Year;
}
int year = method3();
// Console.WriteLine(year);

// 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "wefwe");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i=0; i<count;i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "wefwe");
Console.WriteLine(res);

// цикл в цикле


for (int i=2; i<=10;i++)
{
        for (int j=2; j<=10;j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}