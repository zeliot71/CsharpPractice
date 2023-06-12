// Class 13 [1: 18: 20 - 1: 26: 00 ]
//Anonymous object; temon use hoina & eta reference type
dynamic o = new { Name = "Zihad", Age = 22 };

//Console.WriteLine(o.Name);
//Sorasori object'k call kora jaina so that we should use Dynamic or reflection instead of object
//Dynamic keyword use korle intelligence deina error hole kintu compile korar somoy erorr dei thikoi
Console.WriteLine(o.Name);