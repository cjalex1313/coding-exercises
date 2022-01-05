// Implement a method that replaces spaces with %20 in a char array
// Assumption - the array has a big enough size, let's say 200

namespace Exercise;

public class Program {
  public static void Main() {
    Console.WriteLine("Enter a sentence");
    string sentence = Console.ReadLine() ?? "";
    sentence = sentence.Trim();
    char[] array = new char[200];
    for(int i = 0; i < sentence.Length; i++) {
      array[i] = sentence[i];
    }
    ReplaceWhiteSpace(array, sentence.Length);
    Console.WriteLine(array);
  }

  private static void ReplaceWhiteSpace(char[] array, int length)
  {
    int whiteSpaceCount = array.Count(c => c == ' ');
    int newLength = length + (whiteSpaceCount * 2);
    array[newLength] = '\0';
    for(int i = length - 1; i >= 0; i--) {
      char current = array[i];
      if (current == ' ') {
        array[newLength - 3] = '%';
        array[newLength - 2] = '2';
        array[newLength - 1] = '0';
        newLength -= 3;
      } else {
        array[newLength - 1] = current;
        --newLength;
      }
    }
  }
}
