Console.Clear();

// Console.SetCursorPosition();
// Console.Writeline()

int xa = 20, ya = 1,
    xb = 1, yb = 15,
    xc = 40, yc = 15;

int x = xa, y = xb;

int count = 0;

while (count < 100)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("/");
    count++;
}

