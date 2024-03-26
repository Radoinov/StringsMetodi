namespace Zadacha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string karta = Console.ReadLine();

            while (true)
            {
                string[] clue = Console.ReadLine().Split();
                char searchedCharacter = char.Parse(clue[0]);
                int minimumCount = int.Parse(clue[1]);

                int index = karta.IndexOf(searchedCharacter);
                if (index != -1)
                {
                    int count = 0;
                    for (int i = index; i < karta.Length; i++)
                    {
                        if (karta[i] == searchedCharacter)
                        {
                            count++;
                        }
                        if (count >= minimumCount)
                        {
                            Console.WriteLine($"Hideout found at index {index} and it is with size {count}!");
                            return;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
