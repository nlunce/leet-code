namespace _383;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> ransomNoteDict = new();
        foreach (char c in ransomNote)
            if (ransomNoteDict.ContainsKey(c))
                ransomNoteDict[c]++;
            else
                ransomNoteDict[c] = 1;

        Dictionary<char, int> magazineDict = new();
        foreach (char c in magazine)
            if (magazineDict.ContainsKey(c))
                magazineDict[c]++;
            else
                magazineDict[c] = 1;

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (magazineDict.ContainsKey(ransomNote[i]) && magazineDict[ransomNote[i]] >= 1)
            {
                magazineDict[ransomNote[i]] -= 1;
                continue;
            }

            return false;
        }

        return true;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        string ransomNote = "aa";
        string magazine = "aab";
        bool result = solution.CanConstruct(ransomNote, magazine);
        Console.WriteLine(result);
    }
}