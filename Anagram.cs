namespace Anagram
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str1 = "Heart";
            string str2 = "Earth";

            char[] chr1 = str1.ToLower().ToCharArray();
            char[] chr2 = str2.ToLower().ToCharArray();

            Array.Sort(chr1);
            Array.Sort(chr2);

            string val1 = new string(chr1);
            Console.WriteLine(val1);
            string val2 = new string(chr2);
            Console.WriteLine(val2);

            if ( val1 == val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}