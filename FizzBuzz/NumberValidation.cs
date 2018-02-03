namespace FizzBuzz
{
    public class NumberValidation
    {
        private void PrintFizz()
        {
            System.Console.WriteLine("Fizz");
        }

        private void PrintBuzz()
        {
            System.Console.WriteLine("Buzz");
        }

        private void PrintFizzBuzz()
        {
            System.Console.WriteLine("Fizz Buzz");
        }

        private bool isEven(int n)
        {
            return n % 2 == 0;
        }

        private bool isMultipleOf5(int n)
        {
            return n % 5 == 0;
        }

        public EnumPrintedText ValidateNumber(int currentNumber)
        {

            if (isEven(currentNumber) && isMultipleOf5(currentNumber)) // Any number that is even and is multiple of 5 is a multiple of 10
            {
                PrintFizzBuzz();
                return EnumPrintedText.FizzBuzz;
            }
            else if (isEven(currentNumber)) // Any even number
            {
                PrintFizz();
                return EnumPrintedText.Fizz;
            }
            PrintBuzz(); // All the other numbers are odd
            return EnumPrintedText.Buzz;
        }

        public void IterateNumbers(int number)
        {
            for (int i = 0; i <= number; i++)
            {
#if DEBUG
                System.Console.Write($"{i}: ");
#endif
                ValidateNumber(i);
            }
        }
    }
}