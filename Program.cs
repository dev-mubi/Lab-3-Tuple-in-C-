namespace Lab_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //tuple in c#
            //is of hetrogenous type-can store multiple values of different type
            (string name, int age, string country) student = ("Mubi", 21, "Pakistan");
            var test = student; //??
            Console.WriteLine("Assigning whole tuple to a new variable: (Test):" + test.age);
            //accessing value
            Console.WriteLine(student);
            Console.WriteLine(student.Item1); //by item index
            var student2 = ("Shahzaib", 20, "Pakistan", 3.5, 5); //var data type is decided on runtime
            //item is used to access as there are no variable names
            Console.WriteLine("Student2 using var: " + student2.Item2);
            //var a; is invalid - There has to be value assigned.
            //value with decimal is double by default - Explicitly mention f at the end to make it float.

            //returned tuple
            var res = Calculate(10, 2);
            Console.WriteLine("Sum: " + res.Item1);
            Console.WriteLine("Division: " + res.Item2);


            // - Arrays in C# - Collection of same data type.
            // - It is reference type, Tuple is value type.
            // - Bounds checking on each operation. ?? (Index oot of bound)
            // - All elements are initialized with default values. (0 for int) (null for object type) In c/c++, garbage value is stored.
            // - An array cannot be partially initialized. In C++, int x[5] = {1,2} is valid but not in C#.

            //Syntax
            int[] x = new int[10]; //allocation
            //or
            //int [] x; declaration
            //x = new int[10]; allocation

            //Initialization
            int[] arr = new int[] { 2, 4, 6, 7, 5 }; //No size needed. Automatically guesses. If you give size less than or more than the initalized value, it will throw error.
            //or
            int[] arr2 = { 3, 5, 3, 5 };

            //Var in arrays
            var arr3 = new int[] { 1, 2, 8, 9 };
            //or
            var arr4 = new int[3]; //declaration
            var arr5 = new[] { 2, 4, 6, 6 }; //Here it finds the type by itself.
            //var arr6 = { 2, 4, 6, 4 }; //error
            //var can also be used as local variable.

            //Array Collection Expression (C# 12+)

            int[] carr = [4, 2, 4, 2];
            int[] carr2 = new int[2];
            carr2 = [3, 45, 3, 34];
            Console.WriteLine(carr.Length); //RETURNS 4 - Recreates the array with new size.
            //carr2[5] = 33; //Index out of range exception

            // ^ (Hat) Operator
            // ^1 --> Last index

            Console.WriteLine("Last index: " + carr2[^1]);


            //2D Arrays
            int[,] array = new int[2, 2];
            //for length -
            // array.length will return all element count.
            //for specific row
            Console.WriteLine("All elements in 2D: " +array.Length);
            Console.WriteLine("Rows: " +array.GetLength(0)); //for rows 0
            Console.WriteLine("Cokumns: " +array.GetLength(1)); //for columns 1

            //Task - Find some of values in each row
            array[0,0] = 3;
            array[0,1] = 4;
            array[1, 0] = 6;
            array[1, 1] = 8;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int rowsum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    rowsum += array[i, j];
                }
                Console.WriteLine("Sum of " + (i+1)  + " row: " + rowsum);

            }
            }











        //tuple enables us to return multiple values from a function.

        public static (int sum, double div) Calculate(int x, int y)
        {
            int sum = x + y;
            double div = y != 0 ? (double)x / y : double.NaN;  // Avoid division by zero
            return (sum, div);
        }
    }
}
