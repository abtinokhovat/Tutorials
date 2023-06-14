namespace Leetcode;

public class Solution843
{
    public static void FindSecretWord(string[] wordlist, Master master)
    {
        var random = new Random();
        var matches = 0;

        for (var i = 0; i < 10 && matches != 6; i++)
        {
            var guess = wordlist[random.Next(wordlist.Length)];
            matches = master.Guess(guess);
            var candidates = new List<string>();

            foreach (var word in wordlist)
                if (matches == GetMatches(guess, word))
                    candidates.Add(word);

            wordlist = candidates.ToArray();
        }
    }

    private static int GetMatches(string word1, string word2)
    {
        var matches = 0;
        for (var i = 0; i < word1.Length; i++)
            if (word1[i] == word2[i])
                matches++;

        return matches;
    }

    public class Master
    {
        public Master(string secret, string[] words)
        {
            Secret = secret;
            Words = words;
        }

        private string Secret { get; }
        private string[] Words { get; }
        public int Call { get; set; }

        public int Guess(string word)
        {
            if (!Words.Contains(word)) return -1;
            var count = 0;
            for (var i = 0; i < word.Length; i++)
                if (word[i] == Secret[i])
                    count++;

            Call++;

            return count;
        }
    }
}