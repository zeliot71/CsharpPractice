//== BeeCrowd 1049 ==>
string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();

if (a.Contains("vertebrado") && b.Contains("ave") && c.Contains("carnivoro"))
    Console.WriteLine("aguia");
else if (a.Contains("vertebrado") && b.Contains("ave") && c.Contains("onivor"))
    Console.WriteLine("pomba");
else if (a.Contains("vertebrado") && b.Contains("mamifero") && c.Contains("onivoro"))
    Console.WriteLine("homem");
else if (a.Contains("vertebrado") && b.Contains("mamifero") && c.Contains("herbivoro"))
    Console.WriteLine("vaca");

else if (a.Contains("invertebrado") && b.Contains("inseto") && c.Contains("hematofago"))
    Console.WriteLine("pulga");
else if (a.Contains("invertebrado") && b.Contains("inseto") && c.Contains("herbivoro"))
    Console.WriteLine("lagarta");
else if (a.Contains("invertebrado") && b.Contains("anelideo") && c.Contains("hematofago"))
    Console.WriteLine("sanguessuga");
else if (a.Contains("invertebrado") && b.Contains("anelideo") && c.Contains("onivoro"))
    Console.WriteLine("minhoca");