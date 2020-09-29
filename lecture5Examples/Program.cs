using System;

namespace lecture5Examples
{
    class Program
    {
        enum CardSuit { Club, Diamond, Spades, Hearts } 
        enum month
        {
            jan,
            feb,
            mar,
            apr,
            may
        }
        static void Main(string[] args)
        {

            ////nested for loop 
            //Console.WriteLine("enter the number of hours and i will tell you how many minutes in it:");
            //int h = int.Parse(Console.ReadLine());
            //int numberOfMinutes = 0;
            //int numberOfSeconds = 0;
            //int x;
            //for (x = 0; x < h; x++)
            //{
            //    for (int y = 0; y < 60; y++)
            //    {
            //        numberOfMinutes++;
            //        for (int z = 0; z < 60; z++)
            //        {
            //            numberOfSeconds++;
            //        }
            //    }
            //}
            //Console.WriteLine("Number of minutes in " + h + " hours is " + numberOfMinutes + " minutes and " + numberOfSeconds +" seconds");

            //FizzBuzz
            //int n = 100; 
            //for(int i = 1; i <= 100; i++)
            //{
            //    //number can be divided by both 3 and 5 
            //    //print 'FizzBuzz' in place of the number
            //    if (i % 15 == 0)
            //    {
            //        Console.Write("FizzBuzz" + " ");
            //    }
            //    //number can be divided by 3 
            //    //print 'Fizz' in place of the number

            //    else if (i % 3 == 0)
            //    {
            //        Console.Write("Fizz" + " ");
            //    }

            //    //number can be divided by 5
            //    //print 'Buzz' in place of the number
            //    else if(i % 5 == 0)
            //    {
            //        Console.Write("Buzz" + " ");
            //    }

            //    else
            //    {
            //        Console.Write(i + " ");
            //    }


            //}

            //Random numbers
            //Random dice = new Random(); 
            ////asuming we are rolling a dice ten times
            //for(int i = 0; i < 10; i++)
            //{
            //    //int randomNumber =  dice.Next(); // non-negative number 
            //    //int randomNumber = dice.Next(6);//to generate numbers between 0 and 6-1
            //    int randomNumber = dice.Next(1, 7); //To generate between n and m-1 where m > n
            //    Console.WriteLine(randomNumber); 
            //}

            ////generate random double number
            //Random nGenerator = new Random();
            //double b = nGenerator.NextDouble();
            //Console.WriteLine(b);

            //Arrays
            double[] score = new double[5];
            //The first index of a C# array starts at 0 not 1.
            //The last element index is n – 1.Where n is the total number of slots in an array.
            //initialize array
            //long way
            score[0] = 80;
            score[1] = 99.9;
            score[2] = 75;
            score[3] = 100;
            score[4] = 85;
            //short way
            //double[] score = { 80, 99.9, 75, 100, 85 }; 

            //initialize array using for loop 
            //double[] reading = new double[10];
            //int index;
            ////Console.WriteLine(reading.Length); 
            //for(index = 0; index < reading.Length; index++)
            //{
            //    //reading[index] = 42.0; all elements will take same value
            //    Console.WriteLine("enter a number to array element #  " + (index + 1));
            //    reading[index] = double.Parse(Console.ReadLine()); 

            //}

            ////accessing an array values 
            //for (index = 0; index < reading.Length; index++)
            //{
            //    Console.WriteLine(reading[index]);
            //}

            //Index Boundaries
            //Be sure to stay within the boundaries of the array.

            //Partially filled arrays
            //int size = 10;
            //int count = 0;
            //int[] partialArray = new int[size];
            //Console.WriteLine("How many number would you like to enter? ");
            //count = int.Parse(Console.ReadLine()); 
            //for(int i = 0; i < count; i++)
            //{
            //    Console.WriteLine("enter a number to array element #  " + (i + 1));
            //    partialArray[i] = int.Parse(Console.ReadLine()); 
            //}
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine("Number entered in element #" + (i + 1)+ " is " + partialArray[i]); 
            //}

            //for each loop 
            //double[] a = new double[10];
            //for (int i = 0; i < a.Length ; i++)
            //{
            //    Console.WriteLine(a[i]); 
            //}


            //foreach(double element in a )
            //{
            //    Console.WriteLine(element); 
            //}

            //Multidimensional Array
            //int[,] c = new int[5, 6];
            //Console.WriteLine("The array c length is  " + c.Length);

            //Additional Information
            //You can also have 3 dimensional or 4 dimensional arrays.  C# will support arrays up to 32 dimensions.  
            //You can think of these as an array for an array.  

            //array lab 
            //int headCount = 0;
            //int tailCount = 0;
            //double headPercent;
            //double tailPercent;

            //Random flip = new Random();

            //Console.WriteLine("This program will filp the coin 8 times ");
            //for (int i = 1; i <= 8; i++)
            //{
            //    int coinFlip = flip.Next(2);
                
            //    if (coinFlip == 0)
            //    {
            //        headCount++; // 0 for head 
            //    }
            //    else
            //        tailCount++; // 1 for tail

            //}
            //Console.WriteLine("the coin flips gave us " + headCount + " head and " + tailCount + " tail");
            //headPercent = Convert.ToDouble(headCount) / 8 * 100;
            //tailPercent = Convert.ToDouble(tailCount) / 8 * 100;
            //Console.WriteLine("the 8 times flips, we got   " + headPercent + " % head and " + tailPercent + " % tail");

            //Enumerations

            CardSuit C = CardSuit.Club;
            Console.WriteLine(C);

            Console.WriteLine("The value of Jan in month enum is " + (int) month.jan);
            Console.WriteLine("The value of feb in month enum is " + (int)month.feb);
            Console.WriteLine("The value of mar in month enum is " + (int)month.mar);
            Console.WriteLine("The value of apr in month enum is " + (int)month.apr);
            Console.WriteLine("The value of may in month enum is " + (int)month.may);


        }
    }
}
