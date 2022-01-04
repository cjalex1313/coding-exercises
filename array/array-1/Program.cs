// Implement an algorith that determines if a string has all unique characters? Don't use anything else besides array
// We'll be assuming ASCII characters

namespace Exerciese {
  public class Exercises {
    public static void Main() {
      Console.WriteLine(HasUniqueCharacters("Testt"));
    }

    public static bool HasUniqueCharacters(string sentence) {
      bool[] arr = new bool[256];
      if (sentence.Length > 256) {
        return false;
      }
      foreach (var c in sentence)
      {
          int numericValue = (int)c;
          if (arr[numericValue]) {
            return false;
          }
          arr[numericValue] = true;
      }
      return true;
    }
  }
}
