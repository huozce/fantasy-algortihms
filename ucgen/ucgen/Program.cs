
int x=0;
int y=0;
int z=0;
int mutlakA = x - y;
int mutlakB = x - z;  
int mutlakC = z - y;
string xstr = x.ToString();
string ystr = y.ToString();
string zstr = z.ToString();
xstr = Console.ReadLine();
ystr = Console.ReadLine();
zstr = Console.ReadLine();
x=Convert.ToInt32(xstr);
y=Convert.ToInt32(ystr);
z=Convert.ToInt32(zstr);
int xx = Math.Abs(mutlakA);
int yy = Math.Abs(mutlakB);
int zz= Math.Abs(mutlakC);
ucgen(x, y, z);
void ucgen(int x, int y, int z){

    if (((xx<z)&&(z<x+y))&&((yy<y)&&(y<x+z))&&(((zz<x)&&(x<y+z))))
    {
        if ((x * x + y * y == z * z) || (x * x + z * z == y * y) || (z * z + y * y == x * x))//buradaki mantık çok daha fazla azaltılabilir.
            Console.WriteLine("dik ucgendir");
        else if (x == y && y == z) { Console.WriteLine("eskenar ucgendir"); }
        else { Console.WriteLine("ucgendir"); }

    }
    else { Console.WriteLine("ucgen degildir"); }
}