namespace Bohdan_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = 7;
            string nameToCheck = "John";
            int divider = 3;

            var finishedNumberEntery = false;
            while (!finishedNumberEntery)
            {
                Console.WriteLine("Please enter a number:");
                var numberInput = Console.ReadLine();
                if (Double.TryParse(numberInput, out double number))
                {
                    var message = number > numberToCheck ? "Hello" : $"Entered number was less than {numberToCheck}";
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("Entered value was not a number");
                }

                CheckIfRepeatStep("Enter another number? (y/n)", ref finishedNumberEntery);
            }

            var finishedNameEntry = false;
            while (!finishedNameEntry)
            {
                Console.WriteLine("Please enter a name:");
                var nameInput = Console.ReadLine();
                if (nameInput != null && nameInput.Equals(nameToCheck))
                {
                    Console.WriteLine($"Hello, {nameInput}");
                }
                else
                {
                    Console.WriteLine("There is no such name");
                }

                CheckIfRepeatStep("Enter another name? (y/n)", ref finishedNameEntry);
            }

            var finishedArrayEntry = false;
            while (!finishedArrayEntry)
            {
                Console.WriteLine("Please an array of numbers separated by space (e.g. 12 434 89 1000):");
                var arrayInput = Console.ReadLine();
                if (arrayInput != null)
                {
                    var numbersInput = arrayInput.Split(' ');
                    List<int> numbers = new();
                    for (int i = 0; i < numbersInput.Length; i++)
                    {
                        if (int.TryParse(numbersInput[i], out var number) && number % divider == 0)
                        {
                            numbers.Add(number);
                        }
                    }

                    if (numbers.Count == 0)
                    {
                        Console.WriteLine($"There are no numbers divisivle by {divider}");
                    }
                    else
                    {
                        Console.WriteLine($"Numbers divisible by {divider} are:");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.WriteLine(numbers[i]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("input is invalid");
                }

                CheckIfRepeatStep("Enter different numbers? (y/n)", ref finishedArrayEntry);
            }

            Console.WriteLine("Thank you for interacting with this program!");
        }

        private static void CheckIfRepeatStep(string message, ref bool checkVariable)
        {
            Console.WriteLine(message);
            var answer = Console.ReadLine();
            if (answer != null && answer.Equals("n", StringComparison.CurrentCultureIgnoreCase))
            {
                checkVariable = true;
            }
        }
    }
}
