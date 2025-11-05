

/*Write a program that calculates the average of all elements in an array,
then prints only the numbers greater than the average.*/



Console.WriteLine("Write a program that calculates the average of all elements in an array,then prints only the numbers greater than the average.");

int[] arr = new int[6];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Enter The Number {i + 1} : ");
    arr[i] = Convert.ToInt32(Console.ReadLine());


}

int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum = sum + arr[i];

}

double average = (double)sum / arr.Length;
Console.WriteLine($"The Average is : {average}");

foreach (var item in arr)
{
    if (item > average)
    {
        Console.WriteLine($"The Numbers Greater than Average is : {item}");
    }
}

////////////////////////////////
Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine();
///////////////////////////////

/*    Write a program that asks the user to enter several numbers (an array),
    then prints the numbers in reverse order.*/

Console.WriteLine("Write a program that asks the user to enter several numbers(an array),then prints the numbers in reverse order");

int[] numbers = new int[6];


for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Enter The Number {i + 1}");
    numbers[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine();
Console.WriteLine("the numbers in reverse");

for (int i = numbers.Length - 1; i > 0; i--)
{
    Console.WriteLine(numbers[i]);
}


////////////////////////////////
Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine();
///////////////////////////////




/*Write a program that finds the first character in a text (string)
that does not repeat anywhere else in the string.*/

Console.WriteLine("Enter Ur input");

string input = Console.ReadLine();

Dictionary<char, int> freq = new Dictionary<char, int>();


foreach (var item in input)
{

    if (freq.ContainsKey(item))
    {
        freq[item]++;
    }
    else
    {
        freq[item] = 1;
    }
}

char? firstNonRepeating = null;

foreach (var ch in input)
{
    if (freq[ch] == 1)
    {
        firstNonRepeating = ch;
        break;
    }
}

if (firstNonRepeating != null)
{
    Console.WriteLine($"The first non-repeating character is: {firstNonRepeating}");
}
else
{
    Console.WriteLine("No non-repeating character found.");
}
