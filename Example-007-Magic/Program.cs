Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.Write("+");

int xa=30;
int ya=1;
int xb=1;
int yb=20;
int xc=60;
int yc=20;

Console.SetCursorPosition(xa,ya);
Console.Write("+");

Console.SetCursorPosition(xb,yb);
Console.Write("+");

Console.SetCursorPosition(xc,yc);
Console.Write("+");

int x = xa, y = xb;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0,3); // [0,1,2]
    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if(what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if(what==2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}