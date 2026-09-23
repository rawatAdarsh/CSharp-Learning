/*int[] numbers = {10,20,30,40,50};

Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[2]);
Console.WriteLine(numbers[4]);*/

/*string[] animals = {"Lion", "Tiger", "Elephant", "Monkey"};

Console.WriteLine(animals[0]);
Console.WriteLine(animals[2]);
Console.WriteLine(animals[3]);*/

/*int[] scores = new int[5];
scores[0] = 90;
scores[1] = 75;
scores[2] = 88;
scores[3] = 95;
scores[4] = 82;

Console.WriteLine(scores[0]);
Console.WriteLine(scores[2]);
Console.WriteLine(scores[4]);*/

/*string[] players = new string[3];

players[0] = "Rahul";
players[1] = "Amit";
players[2] = "Vikar";

Console.WriteLine(players[0]);
Console.WriteLine(players[1]);
Console.WriteLine(players[2]);*/

/*int[] numbers = {10,20,30,40,50,60};
Console.WriteLine(numbers.Length);*/

/*string[] animals = {"Lion", "Tiger", "Elephant", "Monkey"};
for(int i = 0; i<animals.Length; i++)
{
    Console.WriteLine(animals[i]);
}*/

/*int[] numbers = {5, 10, 15, 20, 25};
for(int i = 0; i<numbers.Length; i++)
{
    numbers[i] = numbers[i] + 10;
}

for(int i = 0; i<numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}*/

/*int[] marks = {50, 60, 70, 80, 90};
for(int i = 0; i<marks.Length; i++)
{
    marks[i] = marks[i] + 5;
}

for(int i = 0; i<marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}*/

int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter a number: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Your numbers are:");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}