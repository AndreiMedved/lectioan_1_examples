Console.Clear();
//Console.SetCursorPosition(10, 3);
//Console.WriteLine("+");

int xa = 25, ya = 1;
int xb = 1, yb = 15;
int xc = 50, yc = 15;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;

while(count < 10000)
{
    int ran = new Random().Next(0, 3);
    if (ran == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if(ran == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if(ran == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}