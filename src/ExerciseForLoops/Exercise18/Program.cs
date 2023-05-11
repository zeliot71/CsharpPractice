//Print a pattern of stars using a do while loop. For example:
var i = 1;


do
{
    Console.WriteLine();
         var j = 1;
            do
            {
                j++;
                Console.Write("* ");
            }
            while (j <= i);
    i++;
}
while (i <= 5);