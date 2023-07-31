// Вид 1(Методы которые ничего не принимают и ничего не возвращают)
/*
void Method1()
{
    Console.WriteLine("АВтор: ");
}
Method1();
*/
// Вид 2(Методы которые что-то принимают, но ничего не возвращают)
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Text masseg");

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
Method21(msg: "Text messeg21", 4);
Method21(count: 4, msg: "Text messeg21");
*/
// Вид 3(Методы которве ничего не принимают, но что-то возвращают)
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/
// Вид 4(Методы которые и принимают и возвращают)
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Text");
Console.WriteLine(res);
*/