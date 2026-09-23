/*int[] numbers = {10,20,30,40,50};
Console.WriteLine(numbers[0]);*/

/*int[] numbers = {10,20,30,40,50};
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[2]);
Console.WriteLine(numbers[4]);*/

/*int[] numbers = {10,20,30,40,50};
numbers[2] = 100;
Console.WriteLine(numbers[2]);*/

/*int[] numbers = {10,20,30,40,50};
for (int i = 0; i<numbers.Length; i++)
{
    Console.WriteLine(i + "-" + numbers[i]);
}*/

/*int[] studentMarks = {78,85,92,67,88};
Console.WriteLine($"Total number of students: {studentMarks.Length}");
for(int i=0; i<studentMarks.Length; i++)
{
    
    Console.WriteLine(studentMarks[i]);
}*/

int[] numbers = {10,20,30,40,50};
int a = 0;
Console.WriteLine($"Total number of items: {numbers.Length}");
for(int i=0; i<numbers.Length; i++)
{   
    a = a + numbers[i];
}
Console.WriteLine($"Sum of numbers: {a}" );




