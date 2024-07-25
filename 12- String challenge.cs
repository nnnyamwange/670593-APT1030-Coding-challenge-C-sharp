string sentence = "The quick brown fox jumps over the lazy dog";

string[] words = sentence.Split(' ');

Console.WriteLine("Reversed words:");

foreach (string word in words)
{
    string reversedWord = ReverseString(word);
    Console.WriteLine(reversedWord);
}

static string ReverseString(string input)
{
    char[] characters = input.ToCharArray();
    Array.Reverse(characters);
    return new string(characters);
}