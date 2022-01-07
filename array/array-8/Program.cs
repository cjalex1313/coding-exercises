// Given 2 strings write a method that checks if one is a rotation of the other

namespace Program;

public class Program {
  public static void Main() {
    Console.WriteLine("Input the first string");
    string s1 = Console.ReadLine() ?? "";
    Console.WriteLine("Input the second string");
    string s2 = Console.ReadLine() ?? "";
    Console.WriteLine(IsRotation(s1, s2));
  }

  private static bool IsRotation(string s1, string s2)
  {
    if (s1.Length == s2.Length && s1.Length > 0) {
      string doubled = s1 + s1;
      return doubled.Contains(s2);
    }
    return false;
  }
}
