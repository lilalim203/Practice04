

// Create an algorithm to determine the largest of 3 numbers

using System;

class Program4
{
    static void Main(string[] args)
    {
        string sinput1, sinput2, sinput3, orderChar = "";
        int input1, input2, input3, largeNum = 0;

        //    public int largeNum;

        Console.Write("\nInput the first number: ");
        sinput1 = Console.ReadLine();
        input1 = Convert.ToInt32(sinput1);

        Console.Write("\nInput the second number: ");
        sinput2 = Console.ReadLine();
        input2 = Convert.ToInt32(sinput2);

        Console.Write("\nInput the third number: ");
        sinput3 = Console.ReadLine();
        input3 = Convert.ToInt32(sinput3);

        if (input1 == input2 || input1 == input3 || input2 == input3)
        {
            Console.WriteLine("\nAT LEAST TWO NUMBERS ARE DUPLICATED! PLEASE TRY AGAIN!");
        }
        else
        {
            if (input2 < input1 & input3 < input1)
            {
                largeNum = input1;
                orderChar = "FIRST";
            }
            else if (input1 < input2 & input3 < input2)
            {
                largeNum = input2;
                orderChar = "SECOND";
            }
            else if (input1 < input3 & input2 < input3)
            {
                largeNum = input3;
                orderChar = "THIRD";
            }

            Console.WriteLine("\nTHE LARGEST NUMBER IS THE " + orderChar + " ONE," + largeNum);
        }
    }
}