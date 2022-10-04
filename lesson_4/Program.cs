int a = new Random().Next(1,1000);
int b = new Random().Next(1,1000);
int c = new Random().Next(1,1000);
int d = new Random().Next(1,1000);
int e = new Random().Next(1,1000);
int max = a;

if (b > max) max  = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
Console.Write(max);