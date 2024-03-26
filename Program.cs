using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the first number:");
        string firstNumberInput = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string secondNumberInput = Console.ReadLine();

        Calculator cal = new Calculator();

        Console.WriteLine(cal.getOutput(cal.getInput(firstNumberInput), cal.getInput(secondNumberInput)));

        int[] arr = { 1, 22, 3, 40, 5, 6, 7, 82, 999, 10 };


        Console.WriteLine("Largest number in array : {0}",new ArrayHandler().getMax(arr));


       
    }
}

public class Calculator
{

    public int getOutput(int first, int second)
    {
        return first + second;
    }

    public int getInput(string inputNumber)
    {
        return this.checkInput(inputNumber) ? this.convertedToInt(ref inputNumber) : throw new Exception("Input is not an integer."); ;
    }

    private bool checkInput(string a)
    {
        int someValue = 0;
        bool response = int.TryParse(a, out someValue);
        return response;
    }

    private int convertedToInt(ref string number)
    {
        int responseNumber = 0;
        int.TryParse(number, out responseNumber);
        return responseNumber;
    }

}


class ArrayHandler
{

    public int getMax(int[] arr) 
    {
        return isNotEmpty(arr) ? getMaxItemFromArray(arr) : throw new Exception("Array is empty or had only 1 item in it");
    }

    private bool isNotEmpty(int[] arr)
    {
        return arr.Length > 0;
    }

   


    private int getMaxItemFromArray(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
}