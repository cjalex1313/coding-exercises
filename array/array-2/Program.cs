//Implement an algorithm that reverses a string

namespace Array2;

public class Array2 {
  public static void Main() {
    Console.WriteLine("Please enter your string: ");
    char[] sentence = (Console.ReadLine() ?? "").ToCharArray();
    Array.Reverse(sentence);
    Console.WriteLine(sentence);
  }
}
