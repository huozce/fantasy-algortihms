using System.ComponentModel;

Random random = new Random();
int hasar = random.Next(0, 100);



Console.WriteLine("İsim Giriniz.");
string isim = Console.ReadLine();
oyuncu oyuncu1 = new oyuncu(isim,0);

Console.WriteLine("İsim Giriniz.");
string isim2 = Console.ReadLine();
oyuncu oyuncu2 = new oyuncu(isim2,1);




int y = 0;
while (oyuncu1.Can >= 0 && oyuncu2.Can >= 0)
{
    string x = Console.ReadLine();
    oyunbasla(x);
}
if (oyuncu1.Can <= 0)
{
    Console.WriteLine(isim + "kaybettin haci");
}
if (oyuncu2.Can <= 0)
{ Console.WriteLine(isim2 + "kaybettin haci"); }



void oyunbasla(string x)
{
    hasar = random.Next(0, 100);
    if (y % 2 == 0)
    {
        Console.WriteLine("Sıra " + isim + "de");
        if (x == "vur")
        {
            
            oyuncu2.Can = oyuncu2.Can - hasar;
            if (oyuncu2.Can >= 100)
            { oyuncu2.Can = 100; }
            Console.WriteLine(isim2 + "in cani" + oyuncu2.Can + isim + "in cani" + oyuncu1.Can);
        }
        else if (x == "can")
        {
           
            oyuncu1.Can = oyuncu1.Can + hasar;
            if (oyuncu1.Can >= 100)
            { oyuncu1.Can = 100; }
            Console.WriteLine(isim2 + "  in cani  " + oyuncu2.Can + isim + "  in cani  " + oyuncu1.Can);
        }

    }
    else if (y % 2 == 1)
    {
        Console.WriteLine("Sıra " + isim2 + "de");
        if (x == "vur")
        {
            
            oyuncu1.Can = oyuncu1.Can - hasar;
            if (oyuncu1.Can >= 100)
            { oyuncu1.Can = 100; }
            Console.WriteLine(isim2 + "in cani" + oyuncu2.Can + isim + "in cani" + oyuncu1.Can);
        }
        else if (x == "can")
        {
            
            oyuncu2.Can = oyuncu2.Can + hasar;
            if (oyuncu2.Can >= 100)
            { oyuncu2.Can = 100; }
            Console.WriteLine(isim2 + "in cani" + oyuncu2.Can + isim + "in cani" + oyuncu1.Can);
        }
    }
    y = y + 1;
}





class oyuncu
{
    public int Can = 100;

    public string player1 = "Player 1 ";
    public string player2 = "Player 2 ";
   
    

    public oyuncu(string nick,int i)
    {
        
        if ( i == 0) { 
        Console.WriteLine(player1 + "in ismi " + nick); ;
        }
        
        else if(i==1) { Console.WriteLine(player2 + "nin ismi " + nick); }
        

    }

}
