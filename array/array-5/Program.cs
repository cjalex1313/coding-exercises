// Implement a method to perform basic string compression using the counts of repeted characters
// For example the string aabccccaaa would become a2b1c4a3
// If the compressed string would not become smaller than the original string, your method should return the original string

using System.Text;

namespace Program;

public class Program {
  public static void Main() {
    Console.WriteLine("Enter your string:");
    string input = Console.ReadLine() ?? "";
    string solution = Compress(input);
    Console.WriteLine(solution);
  }

  private static string Compress(string input)
  {
    int compressedLength = CountCompressedLength(input);
    if (compressedLength > input.Length) {
      return input;
    }
    StringBuilder sb = new StringBuilder();
    char last = input[0];
    int count = 1;
    for (int i = 1; i < input.Length; i++) {
      if (input[i] == last) {
        ++count;
      } else {
        sb.Append(last);
        sb.Append(count.ToString());
        last = input[i];
        count = 1;
      }
    }
    sb.Append(last);
    sb.Append(count.ToString());
    return sb.ToString();
  }

  private static int CountCompressedLength(string input)
  {
    char last = input[0];
    int length = 0;
    int count = 1;
    for (int i = 1; i < input.Length; i++) {
      if (input[i] == last) {
        ++count;
      } else {
        last = input[i];
        length += 1 + count.ToString().Length;
        count = 1;
      }
    }
    length += 1 + count.ToString().Length;
    return length;
  }
}
