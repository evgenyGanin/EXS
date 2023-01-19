Console.Clear();

int a = 4, b = 10,
    c = 33, d = 1,
    e = 66, f = 10,
    g = 33, h = 20;

Console.SetCursorPosition(a, b);
System.Console.WriteLine("░▒▓1██▒▓░");
Console.SetCursorPosition(c, d);
System.Console.WriteLine("░▒▓2██▒▓░");
Console.SetCursorPosition(e, f);
System.Console.WriteLine("░▒▓3██▒▓░");
Console.SetCursorPosition(g, h);
System.Console.WriteLine("░▒▓4██▒▓░");

int x = a, y = b;

int count = 0;

while(count < 10000000)
{
    int what = new Random().Next(0, 4);
    if(what == 0)
    {
        x = (x+a)/2;
        y = (y+b)/2;
    } 
        if(what == 1)
    {
        x = (x+c)/2;
        y = (y+d)/2;
    } 
        if(what == 2)
    {
        x = (x+e)/2;
        y = (y+f)/2;
    } 
        if(what == 3)
    {
        x = (x+g)/2;
        y = (y+h)/2;
    } 

    Console.SetCursorPosition(x, y);
    System.Console.WriteLine("░▒▓██▒▓░");
    count++;
}

// int a = 1, b = 1,
//     c = 1, d = 15,
//     e = 10, f = 15;

// Console.SetCursorPosition(a, b);
// Console.WriteLine("+");

// Console.SetCursorPosition(c, d);
// Console.WriteLine("+");

// Console.SetCursorPosition(e, f);
// Console.WriteLine("+");
