using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
/*{
    Console.Write("Enter your score: ");
    int score =  Convert.ToInt32(Console.ReadLine());

    switch (score)
    {
        case 100:
        case 90:
        case 80:
        case 75:
            Console.WriteLine("Your grade is A");
            break;
        case 70:
            Console.WriteLine("Your grade is B");
            break;
        case 60:
            Console.WriteLine("Your grade is C");
            break;
        case 50:
            Console.WriteLine("Your grade is D");
            break;
        case <=40:
            Console.WriteLine("Your grade is F");
            break;
        default:
            Console.WriteLine("Enter a valid score");
            break;
    }




    //Equation = xsquared - 5x + 6;
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());
    double d = Math.Pow(b, 2) - 4 * a * c;
    int e = (int)Math.Sqrt(d);
    int x1 = (-b + e)/ 2*a;
    int x2 = (-b - e)/2*a;
    Console.WriteLine(x1);
    Console.WriteLine(x2);

    int sum = 0;

    for(int i = 1; i<=10; i+=2){
        sum = sum +i;
    }

    Console.WriteLine(sum);
    for (int i = 1; i<=3; i++)
       {
           for(int j = 1; j<=3; j++) {
               Console.WriteLine(i + "" + j);
           }
       }

    int i = 1;
    int sum = 0;
    while(i<=10)
    {
        if(i % 2 != 0)
        {
            sum = (i * i) + sum;
            
        }
        i++;
    }
    Console.WriteLine(sum);

    while (i <= 3)
    {
        int j = 1;
        while (j <= 3)
        {
            Console.WriteLine(i +  " " + j);    
            j++;    
        }
        i++;
    }

    do
    {
        Console.WriteLine(i);
        i++;
    } while (i < 10);

    do
    {
        int j = 1;
        do
        {
            Console.WriteLine(i + " " + j);
            j++;
        } while (j <= 3);
        i++;
    } while (i <= 3);

    do
    {
        int choice = 0;

        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdrawal");
        Console.WriteLine("3. Inquiry");
        Console.WriteLine("4. Airtime");
        Console.WriteLine("5. Data");
        Console.WriteLine("6. Exit");

        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Congratulations, you have successfully chosen the deposit option\n");
                    break;
                case 2:
                    Console.WriteLine("Congratulations, you have successfully chosen the withdrawal option\n");
                    break;
                case 3:
                    Console.WriteLine("Congratulations, you have successfully chosen the Inquiry option\n");
                    break;
                case 4:
                    Console.WriteLine("Congratulations, you have successfully chosen the Airtime option\n");
                    break;
                case 5:
                    Console.WriteLine("Congratulations, you have successfully chosen the Data option\n");
                    break;
                case 6:
                    Console.WriteLine("You have successfully exited the menu");
                    return;
                default:
                    Console.WriteLine("Enter a valid option\n");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric option.\n");
        }
    } while (true);
}*/


internal class Training{   
    public void Message()
    {
        Console.WriteLine("This is a beautiful tube");
    }
    /*private static void Main(String[] args)
    {
        Training tr = new Training();
        tr.Message();
        Mathematics m = new Mathematics();
        Console.WriteLine(m.Addition(5, 2));
    }*/
    
}

class Mathematics
{
    public int Addition(int a, int b)
    {
        return a + b;   
    }
}
class bag
{
    static void printMin() {
        int[] arr = { 1, 2, 3, 4 };
        int min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        Console.WriteLine("minimum is " + min);
    }

    static void even(int[] x)
    {
        int sum = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] % 2 == 0)
            {
                sum += x[i];
            }

        }
        Console.WriteLine("The sum of the even numbers is " + sum);

    }
    static String winner(int[] x) {
        int even = 0;
        int odd = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }

        }
        if (even > odd)
        {
            return "Even is the winner";
        }
        else if (odd > even) {
            return "Odd is the winner";
        }
        else
        {
            return "Draw";
        }

    }

    static void highestScore()
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("How many scores do you want to input?");
        int size = Convert.ToInt32(Console.ReadLine());
        int highest = 0;
        int score = 0;
        int current = 0;
        int[] scoreArr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Input a score");
            score = Convert.ToInt32(Console.ReadLine());
            scoreArr[i] = score;
        }
        for (int j = 0; j < size; j++)
        {
            current = scoreArr[j];

            if (current > highest)
            {
                highest = current;
            }
        }
        Console.WriteLine("\nThe highest score is " + highest);


    }

    static void multiArray()
    {
        int[,] arr = new int[3, 3];
        arr[0, 0] = 1;
        arr[1, 1] = 2;
        arr[2, 2] = 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }

    static int sum1()
    {
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum += arr[i, j];
            }
        }
        return sum;
    }

    static string Pairs()
    {
        int[] numbers = { 2, 4, 3, 5, 7, 8 };
        string total = "";

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNum = numbers[i];
            for (int j = 0; j < numbers.Length; j++)
            {
                int otherNum = numbers[j];
                if (currentNum + otherNum == 7)
                {
                    total += "[" + currentNum + ", " + otherNum + "]";
                    if (i != numbers.Length - 1 || j != numbers.Length - 1)
                    {
                        total += ", ";
                    }
                }
            }
        }
        return total;
    }


    static int Max()
    {
        int[,] matrix = { { 3, 5, 1 }, { 7, 2, 8 }, { 4, 6, 9 } };
        int max = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int current = matrix[i, j];
                if (current > max)
                {
                    max = current;
                }
            }
        }
        return max;
    }

    static int max1()
    {
        int[][] arr = new int[3][];
        arr[0] = new int[] { 11, 27, 56, 78 };
        arr[1] = new int[] { 2, 5, 6, 7, 98, 5 };
        arr[2] = new int[] { 2, 5 };
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                int current = arr[i][j];
                sum += current;
            }
        }
        return sum;
    }

    static void Grade()
    {
        Console.WriteLine("GRADING SYSTEM");
        Console.WriteLine("-------------------------------\n\n");
        Console.WriteLine("Enter the number of students: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of subjects: ");
        int subSize = Convert.ToInt32(Console.ReadLine());
        string[] students = new string[size];
        string[] subjects = new string[subSize];
        int[,] scores = new int[size, subSize];

        
        for (int j = 0; j < subSize; j++)
        {
            Console.WriteLine();
            Console.WriteLine("Input subject name: ");
            string subject = Convert.ToString(Console.ReadLine());
            subjects[j] = subject;
        }

        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Input student name: ");
            string name = Convert.ToString(Console.ReadLine());
            students[i] = name;

            for (int j = 0; j < subSize; j++)
            {
                Console.WriteLine("Input " + subjects[j] + " score: ");
                scores[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        
        Console.WriteLine();
        Console.Write("".PadRight(15));

        for (int i = 0; i < subSize; i++)
        {
            Console.Write(subjects[i].PadRight(15));
        }

        Console.WriteLine();

        
        for (int i = 0; i < size; i++)
        {
            Console.Write(students[i].PadRight(15));

            for (int j = 0; j < subSize; j++)
            {
                Console.Write(scores[i, j].ToString().PadRight(15));
            }

            Console.WriteLine();
        }
    }

    static void vertical()
    {
        int[] array = { 1, 2, 3 };

        for(int i = 0; i<array.Length; i++)
        {
            int current = array[i];
            Console.WriteLine(current);
        }
    }






  private static void Main(String[] args)
    {

        vertical();
    }
}
