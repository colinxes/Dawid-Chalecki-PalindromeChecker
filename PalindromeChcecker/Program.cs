namespace PalindromeChcecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!");

            Console.WriteLine("Here you can check if words are palindromes");

            string input = "";
            // Read user input
            input = Console.ReadLine();
            char[] inputAsArray = input.ToCharArray();
            string output = "";
            int startPoint = inputAsArray.Length - 1;

            for (int i = startPoint; // DEFINE START POINT
                i >= 0; // CONDITION HOW LONG THE LOOP SHOULD EXECUTE
                i-- ) // WHAT SHOULD BE DONE AFTER EACH LOOP             
            {
                output += inputAsArray[i];
            }

            if (input.ToLower() == output.ToLower())
            {
                Console.WriteLine("It is an palindrome!");
            }
            else
            {
                Console.WriteLine("It is not an palindrome!");
            }
        }
    }
}