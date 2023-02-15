
string[] startArray = new string [] {"qwerty", "123321", "o", "hi"};

int NewArraySize = 0;

for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
        NewArraySize++;        
}

string[] finalArray = new string[NewArraySize];

int j = 0;
for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
        finalArray[j] = startArray[i];
        j++;    
    }
}
Console.Write("\n [{0}] ->",String.Join(", ", startArray));
Console.WriteLine(" [{0}]",String.Join(", ", finalArray));


