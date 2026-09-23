int[] marks = new int[6];

Console.WriteLine("Enter marks for 6 students: "); //Input of marks
for(int i=0; i<marks.Length; i++)
{
    marks[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("All marks are:"); //Display of marks
for(int i=0; i<marks.Length; i++)
{
    Console.WriteLine($"{marks[i] }");
}

int highest = marks[0];
for(int i=1; i<marks.Length; i++) //Finding the highest of marks
{
    if(marks[i]>highest)
    {
        highest = marks[i];
    }
}

Console.WriteLine($"Highest mark: {highest}");

int lowest = marks[0];
for(int i=1; i<marks.Length; i++)
{
    if(marks[i]<lowest)
    {
        lowest = marks[i];
    }
}
Console.WriteLine($"Lowest mark: {lowest}");

int passing_mark = 50; //find the number of students who passed
int counter = 0;
for(int i=0; i<marks.Length; i++)
{
    if(marks[i]>=passing_mark)
    {
        counter++;
    }
}
Console.WriteLine($"Number of students passed: {counter}");

bool found = false;
int index = 0;
Console.WriteLine("Enter a mark to search");
int search = int.Parse(Console.ReadLine());
for(int i = 0; i<marks.Length; i++)
{
    if(marks[i]==search)
    {
        found=true;
        index = i;
        break;
    }
}

if(found==true)
{
    Console.WriteLine($"Mark found at index: {index}");
}

else
{
    Console.WriteLine("Mark not found.");
}