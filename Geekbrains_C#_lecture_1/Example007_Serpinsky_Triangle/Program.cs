Console.Clear();
//Console.SetCursorPosition(10,4); // (horisontal, vertical) - console coordinates of cursor
//Console.WriteLine(".");
while (true)
{
    break;
}
int xa = 40, ya = 1, 
    xb = 1, yb = 30,
    xc = 80, yc = 30;
Console.SetCursorPosition(xa,ya);
Console.WriteLine(".");
Console.SetCursorPosition(xb,yb);
Console.WriteLine(".");
Console.SetCursorPosition(xc,yc);
Console.WriteLine(".");

int x = xa, y = xb;
int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine(".");
    count++;
}
Console.SetCursorPosition(1,31);
Console.WriteLine("Triangle of Serpinsky is ready to observe. Press Any Key to continue.");
Console.ReadLine();