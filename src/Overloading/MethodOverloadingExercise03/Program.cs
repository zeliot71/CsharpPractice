using MethodOverloadingExercise03;

StringUtils stringUtils = new StringUtils();
string Reverse1 = stringUtils.Reverse("oyillo");
Console.WriteLine(Reverse1);

string[] inputArray = { "Apple", "Banana", "Cherry" };
string[] reversedArray = stringUtils.Reverse(inputArray);
foreach (string str in reversedArray)
{
    Console.Write(str+ " ");
}