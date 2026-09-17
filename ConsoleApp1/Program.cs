
//bullet1 är live
bool blank = true;

bool dintur = true;

bool återstartbool = false;

void bullet1()
{
    blank = false;
    Console.WriteLine("panng");
}

void bullet2()
{
    Console.WriteLine("CLICK");
}
/*
void bullet3()
{ 
    Console.WriteLine("CLICK");
}

void bullet4()
{
    Console.WriteLine("AAAAHHHHHHHHH CLICK");
}

void bullet5()
{ 
    Console.WriteLine("CLICK");
}

void bullet6()
{ 
    Console.WriteLine("CLICK");
}

void bullet7()
{ 
    Console.WriteLine("CLICK");
}

void bullet8()
{
    Console.WriteLine("CLICK");
}
*/
void återstart()
{
    Console.Clear();
    Console.WriteLine("tryck r för återstart");
    återstartbool = true;

}


Console.WriteLine("du kör nu rysk rollet tryck f och enter för att skjuta den du ser framfördig är din motståndare");
while (true)
{




    List<Action> funktioner = new List<Action>()
    {
        bullet1
    };

    for (int i = 0; i < 7; i++)
    {
        funktioner.Add(bullet2);
    }
    Random slump = new Random();
    int index = slump.Next(funktioner.Count);

    funktioner[index]();

    if (dintur == true && blank == false)
    {
        Console.WriteLine("du klämmer avtryckaren i med hög puls och hör ett klick");
        dintur = false;
    }
    else if (dintur == false && blank == true)
    {
        Console.WriteLine("din fiende trycker avtryckaren och hör ett klick ");
        dintur = true;
    }

    if (dintur == true && blank == false)
    {
        Console.WriteLine("du hör ett högt skott och ser ett ljus och så långsamt börjar du falla neråt och ser din kropp framlutad utan liv i ögonen och då inser du vem du spelade med, det var djävulen");
        återstart();
    }
    else if (dintur == false && blank == false)
    {
        Console.WriteLine("du hör ett högt pang och så ser du din fiende falla framot och så börjar du långsamt stiga uppot och då inser du att du van mot djävulen i rysk rolet");
        återstart();
    }
       string återstartstring = Console.ReadLine;
    

    if (återstartbool == true && återstartstring == "r")
    {

    }

}