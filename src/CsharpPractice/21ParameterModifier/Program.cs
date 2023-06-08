// See https://aka.ms/new-console-template for more information

using _21ParameterModifier;
//There four parameter modifier in c#, they are being used for modify parameters
//they are: Params, ref,in & out


ParamsExample paramExample = new ParamsExample();
paramExample.sum(5,6);

paramExample.sum(7,8,5,4,6,3);
//We can write both for the benifits of PARAMS!
paramExample.sum(new int[] {2,4,5,6,5,5,5});

//Ref: er value sorasori parameter e call kora jaina new variables create kore then korte hoi
REFinOUT refinout = new REFinOUT();
int t = 10;
refinout.Something(ref t);
Console.WriteLine(t);