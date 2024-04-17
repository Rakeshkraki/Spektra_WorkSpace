//using System;

class WordCount
{
    static void Main()

    {

        //CountWords();

        //TimeZone();
        
        //CountWords();

        //NumAvg();

        //SimpleIntrest();

        //MaxNumber();


        //RemoveDup();

        
    }

    

    static void CountWords()
    {
        Console.WriteLine("Enter the String :- ");
        string inputString = Console.ReadLine();
        string[] words = inputString.Split(' ');
        Console.WriteLine("Word Count :- " + words.Length);
    }

    static void TimeZone()
    {
        string myZone =Convert.ToString(TimeZoneInfo.Local);
        Console.WriteLine("Local Timezone: " + myZone);

    }

    static void NumAvg()
    {
        int a =Convert.ToInt32(Console.ReadLine());
        int b =Convert.ToInt32(Console.ReadLine());
        int c =Convert.ToInt32(Console.ReadLine());
        int avg = (a + b + c)/3;
        Console.WriteLine("the avrage of numbers is :- " + avg);

    }

    static void SimpleIntrest()
    {
        int principaAmount = Convert.ToInt32(Console.ReadLine());
        int rateOfIntrest = Convert.ToInt32(Console.ReadLine());
        int TimeInYear = Convert.ToInt32(Console.ReadLine());

        int si = (principaAmount *  rateOfIntrest * TimeInYear)/100;

        Console.WriteLine(si);
    }

    static void MaxNumber()
    {
        int[] arr = { 1, 2, 3 };
        int max = 0;

        for(int i = 0;i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("maximum number is :- " + max);
    }

    static void RemoveDup()
    {
        {
            int[] array = { 1, 2, 2, 3, 4, 4, 5 };

            int[] uniqueArray = array.Distinct().ToArray();

            foreach (var item in uniqueArray)
            {
                Console.WriteLine(item);
            }
        }

    }
}
