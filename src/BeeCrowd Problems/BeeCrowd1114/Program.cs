//== BeeCrowd 1114 ==>
int password;
while (true){
    password = int.Parse(Console.ReadLine());

    if (password != 2002)
        Console.WriteLine("Senha Invalida");
    else
        Console.WriteLine("Acesso Permitido");
    break;

}
