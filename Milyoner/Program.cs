using System;
using System.Collections.Specialized;
using System.Drawing;



string[] suallar = { "İlk qülə saatı neçənci ildə düzəlib?", "Çempionlar liqasını 5 dəfə qaldıran klub?", "Pişiklərin maksimum surəti saatda neçə kilometrdir?", "Hansı heyvanın qırılan sümüyü qaynamır?", "İnsandan başqa digər hansı canlı zövq üçün cinsi əlaqədə olur?", "İlk teleskop neçənci ildə düzəlib?", "4 ədəd dizi olan yeganə heyvan hansıdır?", "Hansı canlının qanı bəyazdır?", "1950-ci ildə dünya kuboku hansı ölkədə keçirilib?", "2010-cu ildə dünya kubokunu hansı ölkə qazanıb?" };


string[][] cavablar = new string[10][];
cavablar[0] = new string[4]{"1534","1345","1432","1404" };
cavablar[1] = new string[4] {"Liverpul", "Benfika","M.Yunayted","Barselona" };
cavablar[2] = new string[4] { "50", "40", "80", "70" };
cavablar[3] = new string[4] { "Zürafə", "At", "Dələ", "Pişik" };
cavablar[4] = new string[4] { "İt", "Timsah", "Delfin", "Ayı" };
cavablar[5] = new string[4] { "1589", "1699", "1704", "1608" };
cavablar[6] = new string[4] { "Fil", "Ayı", "Zürafə", "Dələ" };
cavablar[7] = new string[4] { "Hörümçək", "İlbiz", "Maral", "Çəyirtgə" };
cavablar[8] = new string[4] { "İngiltərə", "Fransa", "İtalya", "Brazilya" };
cavablar[9] = new string[4] { "İspaniya", "Fransa", "Hollandiya", "Brazilya" };

string[] cavablarr = { "1404", "Liverpul", "50", "At", "Delfin", "1608", "Fil", "Çəyirtgə", "Brazilya", "İspaniya" };


string answer1;
string answer2;
string answer3;
string answer4;

void DeleteElementFromArray(ref string[] arr, int index)
{
    string[] temp = new string[arr.Length - 1];
    for (int i = 0; i < index; i++)
    {
        temp[i] = arr[i];
    }
    for (int i = index; i < arr.Length - 1; i++)
    {
        temp[i] = arr[i + 1];
    }
    arr = temp;
}
void DogruCavab(ref int Xal)
{
    Console.Clear();
    Xal += 10;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Dogru Cavab");
    Thread.Sleep(1000);
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;

}
void YanlisCavab(ref int Xal)
{
    Console.Clear();
    Xal -= 10;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Yanlis Cavab");
    Thread.Sleep(1000);
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
}

void ShowXal(int Xal)
{
    if (Xal >= 0)
    {
        Console.WriteLine("Senin Xalın : " + Xal);
    }
    else
        Console.WriteLine("Senin Xalın : " + 0);
}

int Xal = 0;
Random rand = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + 1 + "." + suallar[i]);
    int j = rand.Next(0, cavablar[i].Length - 1);
    answer1 = cavablar[i][j];
    DeleteElementFromArray(ref cavablar[i], j);
    Console.WriteLine("A)" + answer1);
    j = rand.Next(0, cavablar[i].Length - 1);
    answer2 = cavablar[i][j];
    DeleteElementFromArray(ref cavablar[i], j);
    Console.WriteLine("B)" + answer2);
    j = rand.Next(0, cavablar[i].Length - 1);
    answer3 = cavablar[i][j];
    DeleteElementFromArray(ref cavablar[i], j);
    Console.WriteLine("C)" + answer3);
    j = rand.Next(0, cavablar[i].Length - 1);
    answer4 = cavablar[i][j];
    DeleteElementFromArray(ref cavablar[i], j);
    Console.WriteLine("D)" + answer4);
    ShowXal(Xal);
lcavab:
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.A)
    {
        if (answer1 == cavablarr[i])
        {
            DogruCavab(ref Xal);
        }
        else
            YanlisCavab(ref Xal);
    }
    else if (key.Key == ConsoleKey.B)
    {
        if (answer2 == cavablarr[i])
        {
            DogruCavab(ref Xal);
        }
        else
            YanlisCavab(ref Xal);
    }
    else if (key.Key == ConsoleKey.C)
    {
        if (answer3 == cavablarr[i])
        {
            DogruCavab(ref Xal);
        }
        else
           YanlisCavab(ref Xal);
    }
    else if (key.Key == ConsoleKey.D)
    {
        if (answer4 == cavablarr[i])
        {
            DogruCavab(ref Xal);
        }
        else
            YanlisCavab(ref Xal);
    }
    else
    {
        goto lcavab ;
    }
}





