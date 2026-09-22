
//bullet1 är live
using Microsoft.VisualBasic;

bool blank = true;

bool dintur = true;

bool återstartbool = false;

int winst = 0;

int förlust = 0;

List<Action> kulor = new List<Action>()
    {
        bullet1,
        bullet2
    };

void bullet1()
{
    blank = false;

}

void bullet2()
{
    blank = true;
}

void återstart()
{
    Console.WriteLine("tryck r för återstart");
    återstartbool = true;

}

void kör()
{
    Console.ReadLine();
}
void start()
{
    Console.Clear();
    Console.WriteLine("du kör nu rysk rollet tryck f och enter för att skjuta den du ser framfördig är din motståndare");
    Console.WriteLine($"winst {winst} förlust {förlust}");
    blank = true;
    återstartbool = false;
    kulor.Clear();
    for (int i = 0; i < 7; i++)
    {
        kulor.Add(bullet2);
    }
    kulor.Add(bullet1);
}

Console.WriteLine("du kör nu rysk rollet tryck f och enter för att skjuta den du ser framfördig är din motståndare");
while (true)
{

    kör();

 

    Random slump = new Random();
    int index = slump.Next(kulor.Count);

    kulor[index]();
    kulor.RemoveAt(index);


    if (dintur == true && blank == true)
    {
        Console.WriteLine("click¤");
        Console.WriteLine("du klämmer avtryckaren i med hög puls och hör ett klick");
        dintur = false;
    }
    else if (dintur == false && blank == true)
    {
        Console.WriteLine("click¤");
        Console.WriteLine("din fiende trycker avtryckaren och hör ett klick ");
        dintur = true;
    }

    else if (dintur == true && blank == false)
    {
        Console.WriteLine("PANG!");
        Console.WriteLine("du hör ett högt skott och ser ett ljus och så långsamt börjar du falla neråt och ser din kropp framlutad utan liv i ögonen och då inser du vem du spelade med, det var djävulen");
        återstart();
        blank = true;
        dintur = false;
        förlust += 1;
    }
    else if (dintur == false && blank == false)
    {
        Console.WriteLine("PANG!");
        Console.WriteLine("du hör ett högt pang och så ser du din fiende falla framot och så börjar du långsamt stiga uppot och då inser du att du van mot djävulen i rysk rolet");
        återstart();
        dintur = true;
        blank = true;
        winst += 1;
    
    }

   string återStartstring = Console.ReadLine();
    återStartstring = återStartstring.ToLower();
    if (återstartbool == true && återStartstring == "r")
    {
        start();
    }

}