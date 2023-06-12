// See https://aka.ms/new-console-template for more information

using _22Tuple;

Customer[] customers = new Customer[2];

customers[0] = new Customer() { Id = 1, Name = "Zihad",Address="Chattogram"};
customers[1] = new Customer() { Id = 2,Name="Rifat", Address="Dhaka"};

Order[] orders = new Order[5];
orders[0] = new Order { OrderID = 1, Prices = 200, CustomerID = 1 };
orders[1] = new Order { OrderID = 2, Prices = 100, CustomerID = 2 };
orders[2] = new Order { OrderID = 3, Prices = 100, CustomerID = 2 };
orders[3] = new Order { OrderID = 4, Prices = 200, CustomerID = 1 };
orders[4] = new Order { OrderID = 5, Prices = 200, CustomerID = 1 };

//Tuple:jokhon kotogulo value ke kotogulo variables er moddhe hold kore rakhar proyojon hoy tokhon tuple use kora hy,
//ekadik data type mile ekti data type gothito hoi
//eti value type
(string Name, double Amount)[] result = new (string, double)[customers.Length];

int count = 0;
foreach (var customer in customers)
{
    var sum = 0.0;
    foreach(var order in orders)
    {
        if (order.CustomerID == customer.Id)
            sum += order.Prices;
    }

    result[count++] = (customer.Name, sum);
}

foreach(var resItem in result)
{
    Console.WriteLine($"{resItem.Name}, {resItem.Amount}");
}
(string,int) GetData((double, bool, int) item1,int item2)
{
    return ("test",2);
}
//Combined uses of Tuple and method that can accept parameter