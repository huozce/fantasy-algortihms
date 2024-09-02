
using System.ComponentModel;
int parameterx = int.Parse(Console.ReadLine());
string yildiz = "";
for  (int i = 0; i < parameterx; i++)
{
    
    yildiz = yildiz + "a";
    Console.WriteLine(yildiz);
    
}for (int y=0; y<parameterx; y++ )
    {
        yildiz=yildiz.Remove(parameterx-y);
        Console.WriteLine(yildiz);
    }