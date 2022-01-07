// Write an algorithm such that if an element in an MxN matrix is 0,
// it's entire row and column is set to 0

namespace Program;

public class Program {
  public static void Main() {
    int[,] array = new int[4,6] { {1, 2, 0, 4, 5, 6}, {7, 8, 9, 10, 0, 12}, {13, 14, 15, 16, 17, 18}, {19, 20, 0, 22, 23, 24} };
    PrintArray(array);
    ExtendZero(array);
    PrintArray(array);
  }

  private static void ExtendZero(int[,] array)
  {
    bool[] rows = new bool[array.GetLength(0)];
    bool[] cols = new bool[array.GetLength(1)];

    for(int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++) {
        if (array[i,j] == 0) {
          rows[i] = true;
          cols[j] = true;
        }
      }
    }

    for(int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++) {
        if (rows[i] || cols[j]) {
          array[i,j] = 0;
        }
      }
    }
  }

  private static void PrintArray(int[,] array)
  {
    for(int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++) {
        Console.Write(array[i,j] + " ");
      }
      Console.Write("\n");
    }
    Console.WriteLine();
  }
}