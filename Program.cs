namespace MethodAcceptingValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program 1 - Write a program like the above example that asks the user for a 
            //number, this number is then fed into a method as a reference parameter, use the
            //ref keyword in the method header and in the Main body. The method should increase
            //the number by 15%. The answer should only be written out in the Main method
            //int number;
            //double numberIncrease = 0;
            //Console.Write("Enter a number: ");
            //number = int.Parse(Console.ReadLine());
            //Increase(ref number, ref numberIncrease);
            //Console.WriteLine($"Your number: {number}");
            //Console.WriteLine($"Your increased value: {numberIncrease}");
            //Console.ReadLine();

            //Program 2 - Write a swap method that takes in two variables parameters and swaps
            //them around. You may need a local variable to temporarily hold one of the values.
            //The method should be called from the main body with the call:
            //Swap(ref num1, ref num2);
            //You will need to show what the original numbers were, call the swap method and
            //then show what they are now - do this in the main body
            int numberOne, numberTwo, temp = 0;
            Console.Write("Enter the first number: ");
            numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numberTwo = int.Parse(Console.ReadLine());
            Swap(ref numberOne, ref numberTwo, ref temp);
            Console.WriteLine($"Swapped numbers: {numberOne}, {numberTwo}");

            //Program 3 - Sort Three Numbers
            //Using the swap method from Program 2, swap 3 numbers
        }

        public static void Swap(ref int firstNumber, ref int secondNumber, ref int temp)
        {
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        //Program 2 Methods

        //Program 1 Methods
        public static void Increase(ref int num, ref double numberIncrease)
        {
            numberIncrease = (double)(num * .15);
            numberIncrease += num;
            
        }

    }
}
