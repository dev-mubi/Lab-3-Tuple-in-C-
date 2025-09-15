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
