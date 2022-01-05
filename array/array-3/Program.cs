// Given 2 string write a program that determines if one is a permutation of the other
// We'll assume all the characters are in ASCII

namespace Exercise;

public class Program {
  public static void Main() {
    Console.WriteLine("Input the first string:");
    string first  = Console.ReadLine() ?? "";
    Console.WriteLine("Input the second string");
    string second = Console.ReadLine() ?? "";
    bool isPermutation = IsPermutation(first, second);
    Console.WriteLine(isPermutation);
  }

  private static bool IsPermutation(string first, string second)
  {
    if (first.Length != second.Length) {
      return false;
    }

    int[] letterOccurances = new int[256];

    foreach (char c in first)
    {
      letterOccurances[c]++;
    }
    foreach(char c in second)
    {
      if(--letterOccurances[c] < 0) {
        return false;
      }
    }
    return true;
  }
}
