namespace G_NET_26_C__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ENUMS
            #region Q1
            /*
             Q1 : Day of the Week
                Create an enum called DayOfWeek with values: Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday.
                Then write a program that:
                •	Asks the user to enter a day number (0–6).
                •	Converts it to the enum and prints the day name.
                •	Uses a switch statement to print whether it's a "Workday" or a "Weekend".
            */

            //Console.Write("Enter a day number (1-7): ");
            //int dayNumber = int.Parse(Console.ReadLine());

            //DayOfWeek day = (DayOfWeek)(dayNumber - 1);
            //Console.WriteLine($"Day: {day}");

            //switch (day)
            //{
            //    case DayOfWeek.Friday:
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("It's the Weekend");
            //        break;
            //    case DayOfWeek.Sunday:
            //    case DayOfWeek.Monday:
            //    case DayOfWeek.Tuesday:
            //    case DayOfWeek.Wednesday:
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine("It's a Workday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;
            //}
            #endregion
            #endregion

            #region Arrays
            #region Q1
            /*Q1 : Array Statistics
                Write a program that:
                •	Asks the user for the size of an integer array.
                •	Reads the elements from the user.
                •	Prints: the sum, the average, the maximum value, the minimum value, and the array in reverse order.
            */
            //Console.Write("Enter array size: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] numbers = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element [{i}]: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();

            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"Sum = {sum}");

            //double average = (double)sum / numbers.Length;
            //Console.WriteLine($"Average = {average}");

            //int max = numbers[0];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine($"Max = {max}");

            //int min = numbers[0];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine($"Min = {min}");

            //Console.Write("Reverse = ");
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i]);
            //    if (i > 0)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            //Console.WriteLine();
            #endregion

            #region Q2
            /*
             Q2 : Student Grades Matrix
             You have 3 students, each with 4 subject 
             You have 3 students, each with 4 subject grades. Store them in a 2D array.
             Write a program that:
             -	Reads grades from the user into a [3, 4] array.
             -	Prints each student's average grade.
             -	Prints the overall class averal 
            */
            
            //int[,] grades = new int[3, 4];

            //for (int student = 0; student < 3; student++)
            //{
            //    Console.WriteLine($"Enter grades for Student {student + 1}:");
            //    for (int subject = 0; subject < 4; subject++)
            //    {
            //        Console.Write($"  Subject {subject + 1}: ");
            //        grades[student, subject] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine(); 

            //double totalSum = 0;
            //for (int student = 0; student < 3; student++)
            //{
            //    int studentSum = 0;
            //    for (int subject = 0; subject < 4; subject++)
            //    {
            //        studentSum += grades[student, subject];
            //    }
            //    double studentAverage = (double)studentSum / 4;
            //    Console.WriteLine($"Student {student + 1} Average = {studentAverage}");
            //    totalSum += studentSum;
            //}

            //double classAverage = totalSum / (3 * 4);
            //Console.WriteLine($"Overall Class Average = {classAverage}");
            #endregion
            #endregion
        }
    }
}
