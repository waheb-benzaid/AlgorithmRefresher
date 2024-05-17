namespace AlgorithmRefresher
{
    public class PolyndromeWord(string word)
    {
        public bool isPolindromeMySolution()
        {
            int length = word.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = length - 1; j > 0; j--)
                {
                    if (word[i] != word[j])
                    {
                        return false;
                    }
                    i++;
                }
            }
            return true;
        }
        //****************************************************
        public void PolindromeBetterSolution()
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    Console.WriteLine("False");
                    break;
                }
                break;
            }
            Console.WriteLine("true");
        }
    }
}
