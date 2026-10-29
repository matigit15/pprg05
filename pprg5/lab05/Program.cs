
//1
// using System.ComponentModel.DataAnnotations;
// int suma = 0;
// int wieksze = 0;
// int[] zlotoWTurach = { 5, 12, 0, 8, 16 };
// for (int i = 0; i< zlotoWTurach.Length; i++)
// {
//     Console.WriteLine($"Tura {i+1}: {zlotoWTurach[i]}  sztuk zlota\n ");
//     suma+= zlotoWTurach[i];
//     if (zlotoWTurach[i]>10);
//     {
//         wieksze+=1;
//     }
// }
// double srednia = (double)suma / zlotoWTurach.Length;
// Console.WriteLine($"Łącznie: {suma}\n");
// Console.WriteLine($"Średnio na ture:  {srednia}\n");
// Console.WriteLine($"Tury z wynikime co najmniej 10: {wieksze}\n");
// Console.WriteLine($"Liczby od tyłu:"  );
// foreach (var liczba in zlotoWTurach.AsEnumerable().Reverse() )
// {

//     Console.WriteLine(liczba  );
// }


//2
// using System.Runtime.InteropServices;

// List<string> plecak = new List<string>
// {
//     "Miecz",
//     "Mikstura",
//     "Pochodnia"
// };
// int liczba = 0;
// Console.WriteLine($"Plecak  {plecak.Count}/6:\n");
// foreach (string przedmiot in plecak )
// {
//     liczba+=1;
//     Console.Write($"{liczba}.{przedmiot}\n");
// }
// liczba = 0;
// Console.WriteLine("Co odnalazles bozydarze\n");
// string skarb = Console.ReadLine();
// plecak.Add(skarb);
// Console.WriteLine("Czy chcesz uzyc mikstury bozydarze?\n");
// bool mikstura = bool.Parse(Console.ReadLine());
// if (mikstura ==true && plecak.Contains("Mikstura"))
// {
//     plecak.Remove("Mikstura");
//     Console.WriteLine("Przepyszna mikstura bozydarze\n");
// }
// else
// {
//     Console.WriteLine("Nie mozesz uzyc mikstury bozydarze\n");
// }

// foreach (string przedmiot in plecak )
// {
//     liczba+=1;
//     Console.Write($"{liczba}.{przedmiot}\n");
// }
//3
// Dictionary<string, int> ceny = new Dictionary<string, int>
// {
//     { "Mikstura", 15 },
//     { "Pochodnia", 5 },
//     { "Miecz", 40 }
// };
// Console.WriteLine($"W sklepiku jest {ceny.Count} przedmiotow\n");
// foreach (KeyValuePair<string, int> para in ceny)
// {
//     Console.WriteLine($"{para.Key}: kosztuje {para.Value}  sztuk złota\n");
// }
// Console.WriteLine("Co chcialbys kupic bozydarze");
// string zakup = Console.ReadLine();
// if (ceny.ContainsKey(zakup))
// {
//     Console.WriteLine($"Ten przedmiot kosztuje {ceny[zakup]} zlota\n");
//     ceny[zakup] = 20;
//     Console.ReadKey();
//     Console.Clear();
// }
// else
// {
//     Console.WriteLine("Bozydarze oszalales nie mamy tego na stanie\n");
//     Console.ReadKey();
//     Console.Clear();
// }


// Console.WriteLine($"W sklepiku jest {ceny.Count} przedmiotow\n");
// foreach (KeyValuePair<string, int> para in ceny)
// {
//     Console.WriteLine($"{para.Key}: kosztuje {para.Value}  sztuk złota\n");
// }
//4
// Console.WriteLine("Podaj liczbe tur od 1-10:");
// int dlugosc = int.Parse(Console.ReadLine());
// int[] zlotoWTurach = new int[dlugosc];
// Random losuj = new Random();
// int suma = 0;
// int min = zlotoWTurach[0];
// int max = zlotoWTurach[0];
// int najlepszy = 0;
// int pierwsza =0;
// int ilosc =0;

// for (int i = 0; i < zlotoWTurach.Length;i++)
// {
//     zlotoWTurach[i] = losuj.Next(0,31);
// }
// for (int i = 0; i < zlotoWTurach.Length;i++)
// {
//     suma+=zlotoWTurach[i];
//     if (min>zlotoWTurach[i])
//     {
//         min=zlotoWTurach[i];
//     }
//     if (max<zlotoWTurach[i])
//     {
//         max=zlotoWTurach[i];
//         najlepszy = i+1;
//     }
//     if (zlotoWTurach[i]==0);
//     {
//         pierwsza=i+1;
//     }


// }
// if (zlotoWTurach.Contains(max))
// {
//     ilosc+=1;
// }
// Console.WriteLine($"Suma:{suma}\n Minimum:{min}\n Maksimum:{max}\n Pierwszy najlepszy wynik:{najlepszy}\n Liczba tur z maksimum:{ilosc}\n Pierwsza tura bez zlota:{pierwsza}");






//5
using System.Diagnostics;

List<string> przedmioty = new List<string>
{
    "Miecz",
    "Tarcza",
    "Mikstura",
    "Klucz"
};
for (int i = 0; i < przedmioty.Count;i++)
{
    Console.WriteLine($"{i+1}.{przedmioty[i]}");
      

}
Console.WriteLine("Podaj przedmiot do usuniecia");  
string tekst = Console.ReadLine();
if (int.TryParse(tekst,out int usun))
{
    Console.WriteLine($"Luzik bozydarze usuwam przedmiot{usun}");
    przedmioty.RemoveAt(usun-1);
    
}
else
{
    Console.WriteLine("Bozydarze jestes glupkiem");    

    
}