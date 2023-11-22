using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Xml;
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
    static void printMin()
    {
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
    static String winner(int[] x)
    {
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
        else if (odd > even)
        {
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

        for (int i = 0; i < array.Length; i++)
        {
            int current = array[i];
            Console.WriteLine(current);
        }
    }



    static void Strings()
    {
        string name = "Gaadi";
        char[] characters = { 'G', 'a', 'a', 'd', 'i' };
        string newName = new string(characters);
        Console.WriteLine(newName);
    }

    static string name()
    {
        Console.WriteLine("Enter your firstname: ");
        string firstname = Console.ReadLine();
        Console.WriteLine("Enter your lastname: ");
        string lastname = Console.ReadLine();
        string result = string.Format("{0} {1}", firstname, lastname);
        return "Thanks " + result + " for contacting us";
    }

    static void textInfo()
    {
        TextInfo CurrentTextInfo = CultureInfo.CurrentCulture.TextInfo;
        string message = "God is the Greatest";
        string result = CurrentTextInfo.ToTitleCase(message);

    }

    static void task()
    {
        Console.WriteLine("Enter a name: ");
        string name = Console.ReadLine();
        string[] resultName = new string[name.Length];

        for (int i = 0; i < name.Length; i++)
        {
            Char current = name[i];
            string name1 = current.ToString();
            if (name1 == name1.ToUpper())
            {
                resultName[i] = name1.ToLower();
            }
            else
            {
                resultName[i] = name1.ToUpper();
            }

        }
        for (int i = 0; i < resultName.Length; i++)
        {
            string letter = resultName[i];
            Console.Write(letter);
        }
    }


    static void winner()
    {
        Console.WriteLine("Enter a string below: ");
        string word = Console.ReadLine();
        int upper = 0;
        int lower = 0;
        for (int i = 0; i < word.Length; i++)
        {
            Char letter = word[i];
            string letter1 = letter.ToString();
            if (letter1 == letter1.ToUpper())
            {
                upper += 1;
            }
            else
            {
                lower += 1;
            }
        }

        if (upper > lower)
        {
            Console.WriteLine("Uppercase is the winner");

        }
        else if (lower > upper)
        {
            Console.WriteLine("Lowercase is the winner");
        }
        else
        {
            Console.WriteLine("Its a draw");
        }
    }

    static void joinSplit()
    {
        int[] ages = new int[] { 17, 20, 30, 50 };
        string result = String.Join(",", ages);

        string name = "Mike, Jedi, Gaadi";
        string[] namearr = name.Split(",");
        Array.ForEach(namearr, x => Console.WriteLine(x));
        Console.WriteLine(namearr);
    }


    //    Classwork
    static void Dash()
    {
        Console.WriteLine("Enter a string below: ");
        string word = Console.ReadLine();
        TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
        string[] wordArr = new string[word.Length];
        string[] finishedArr = new string[word.Length];
        Char[] currentWord;
        string finishedString = "";
        string result = "";
        string firstUpper = "";

        if (word.Contains("_"))
        {
            wordArr = word.Split("_");
            for (int i = 1; i < wordArr.Length; i++)
            {
                string current = wordArr[i];
                currentWord = current.ToCharArray();
                string firstWord = wordArr[0];
                char otherfirstLetters = currentWord[0];
                string otherfirstLettersString = otherfirstLetters.ToString();

                char firstLetter = wordArr[0][0];
                string firstLetterString = firstLetter.ToString();


                firstUpper = firstLetterString.ToUpper() == firstLetterString ? currentTextInfo.ToTitleCase(firstWord) : firstWord;
                string otherUpper = otherfirstLettersString.ToUpper() == otherfirstLettersString ? currentTextInfo.ToTitleCase(current) : currentTextInfo.ToTitleCase(current);

                result += otherUpper;

            }
            finishedString = firstUpper + result;
        }
        if (word.Contains("-"))
        {
            wordArr = word.Split("-");
            for (int i = 1; i < wordArr.Length; i++)
            {
                string current = wordArr[i];
                currentWord = current.ToCharArray();
                string firstWord = wordArr[0];
                char otherfirstLetters = currentWord[0];
                string otherfirstLettersString = otherfirstLetters.ToString();

                char firstLetter = wordArr[0][0];
                string firstLetterString = firstLetter.ToString();


                firstUpper = firstLetterString.ToUpper() == firstLetterString ? currentTextInfo.ToTitleCase(firstWord) : firstWord;
                string otherUpper = otherfirstLettersString.ToUpper() == otherfirstLettersString ? currentTextInfo.ToTitleCase(current) : currentTextInfo.ToTitleCase(current);

                result += otherUpper;

            }
            finishedString = firstUpper + result;
        }
        Console.WriteLine(finishedString);
    }

    static void palindrome()
    {
        bool option = true;
        do
        {
            Console.WriteLine("Enter a String below: ");
            Console.WriteLine(output());
            Console.WriteLine("Do you want to go again?");
            Console.WriteLine("Enter a Y or N");
            string choice = Console.ReadLine();
            string choiceLowered = choice.ToLower();
            char choiceLoweredLetter = choiceLowered[0];
            option = choiceLoweredLetter == 'y' ? true : false;

        } while (option);

    }

    static String output()
    {
        string word = Console.ReadLine();
        string lower = word.ToLower();
        string reversedString = "";

        for (int i = word.Length; i > 0; i--)
        {
            char currentLetter = lower[i - 1];
            reversedString += currentLetter;
        }
        if (lower == reversedString)
        {
            return "True";
        }
        else
        {
            return "False";
        }
    }
    //solid principles in programming
    //KISS AND DRY

    static void List()
    {
        bool choice = true;
        var tasksList = new List<String>();
        TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
        int number = 0;
        do
        {
            Console.WriteLine("Input task to be displayed:  ");
            string tasks = Console.ReadLine();
            tasksList.Add(tasks);
            Console.WriteLine("Do you want to input more?(Yes or No) ");
            string option = Console.ReadLine();
            string optionLowered = option.ToLower();
            choice = optionLowered[0] == 'y' ? true : false;

            Console.WriteLine(" ");
            if (choice == false)
            {
                Console.WriteLine("Your tasks for today are as follows: ");
                foreach (var task in tasksList)
                {
                    number += 1;
                    Console.WriteLine(number + ". " + currentTextInfo.ToTitleCase(task).Trim());
                }
            }
        } while (choice);
    }

    static void hashSet()
    {
        var products = new HashSet<String>();
        products.Add("Fanta");
        products.Add("Laptop");
        products.Add("Chair");
        products.Add("Fanta");
        products.Remove("Fanta");

        foreach (var item in products)
        {
            Console.WriteLine(item);

        }
    }

    static void sortedSet()
    {
        var cities = new SortedSet<String>();
        cities.Add("Lagos");
        cities.Add("Abuja");
        cities.Add("Kano");
        cities.Add("Accra");
        foreach (var item in cities)
        {
            Console.WriteLine(item);
        }

    }

    static void stack()
    {
        var item = new Stack<string>();
        item.Push("Iwasen");
        item.Push("Godrice");
        item.Push("Hodovai");
        item.Push("Iengem");
        item.Push("Iwasen");
        item.Push("Munachi");
        foreach (var name in item)
        {
            Console.WriteLine(name);
        }
    }
    static void queue()
    {
        Queue<string> cities = new Queue<string>();

        cities.Enqueue("Ibadan");
        cities.Enqueue("Lagos");
        cities.Enqueue("Port-Harcourt");
        cities.Enqueue("Lokoja");
        cities.Enqueue("Ibadan");
        cities.Enqueue("Ibadan");


        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }

    }

    static void LinkedList()
    {
        var subjects = new LinkedList<string>();
        subjects.AddLast("Physics");
        subjects.AddLast("Biology");
        subjects.AddLast("Chemistry");

        LinkedListNode<string> node = subjects.Find("Biology");
        subjects.AddBefore(node, "Mathematics");
        subjects.AddBefore(node, "English");

        foreach (var item in subjects)
        {
            Console.WriteLine(item);
        }

    }

    static void Dictionary()
    {
        Dictionary<string, string> states = new Dictionary<string, string>();
        states.Add("Rivers", "Port Harcourt");
        states.Add("Osun", "Osogbo");
        states.Add("Lagos", "Ikeja");

        foreach (KeyValuePair<string, string> item in states)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }

    }

    public class Employee
    {
        public int id;
        public string name;
        public float flag;
        public float salary;


        public Employee(int id, string name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public static void Main(string[] args)
        {

            Employee emp = new Employee(1, "John", 50000.0f);


            Console.WriteLine(emp.flag);
        }
    }
}

