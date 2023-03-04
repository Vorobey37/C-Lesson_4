/*
*/
Console.Clear();

int GetFactorial (int number)
{
    if (number == 1)
    {
        return 1;
    }
    else 
    {
        return number*GetFactorial(number-1);
    }

}

int result = GetFactorial (5);
Console.WriteLine(result);