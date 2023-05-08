// Write a program that simulates a game of rock-paper-scissors against the computer. The program should ask the user to enter their choice (rock, paper, or scissors) and then randomly generate the computer's choice. The program should then determine the winner based on the following rules: rock beats scissors, scissors beats paper, and paper beats rock.

Console.WriteLine("Please select any option:  \n" +
    "1) Rock \n" +
    "2) Papers \n" +
    "3)Scissor \n");

int oponion = int.Parse(Console.ReadLine());

string[] Options = { "Rock", "Papers", "Scissors" };
Random random = new Random();
int index = random.Next(Options.Length);
string selected = Options[index];
Console.WriteLine("Player2 selected: " + selected);

if (oponion == 1 && selected == "Scissiors" ||
    oponion == 3 && selected == "Papers" ||
    oponion == 2 && selected == "Rock"
    )
{ 
    Console.WriteLine("Player 1 won!");
}
else if(oponion == 3 && selected == "Rock" ||
    oponion == 2 && selected == "Scissors" ||
    oponion == 1 && selected == "Papers")
{
    Console.WriteLine("Plaer 2 won!");
}
else
{
    Console.WriteLine("It's a tie!");
}