// See https://aka.ms/new-console-template for more information
using MethodOverloadingExercise04;

ArrayUtils arrayUtils = new ArrayUtils();
int sum1 = arrayUtils.Sum(new int[] {1,2,3,1,4,4,5,4,7,9});
double sum2 = arrayUtils.Sum(new double[] { 1.00,2.550,0.55});
Console.WriteLine(sum1);
Console.WriteLine(sum2);