// Given an image represented by an NxN matrix where each pixel is 4 bytes write a
// method to rotate the image by 90 degrees. Can you do it in place

namespace Program;

public class Program {
  public static void Main() {
    Console.WriteLine("Enter a value for N: ");
    int n = int.Parse(Console.ReadLine() ?? "2");
    int[,] matrix = GenerateMatrixOfNByN(n);
    Print2dMatrix(matrix, n);
    RotateMatrix(matrix, n);
    Print2dMatrix(matrix, n);
  }

  private static void RotateMatrix(int[,] matrix, int n)
  {
    for(int layer = 0; layer < n/2; ++layer) {
      int last = n - 1 - layer;
      for (int i = layer; i < last; i++) {
        int offset = i - layer;
        int aux = matrix[layer, i];
        matrix[layer, i] = matrix[last - offset, layer];
        matrix[last - offset, layer] = matrix[last, last - offset];
        matrix[last, last - offset] = matrix[i, last];
        matrix[i, last] = aux;
      }
    }
  }

  private static void Print2dMatrix(int[,] matrix, int n)
  {
    for (int i = 0; i < n; i++) {
      for(int j = 0; j < n; j++) {
        int x = matrix[i,j];
        Console.Write($"{x} ");
      }
      Console.Write("\n");
    }
    Console.Write("\n");
  }

  private static int[,] GenerateMatrixOfNByN(int n)
  {
    int[,] matrix = new int[n,n];
    for (int i = 0; i < n; i++) {
      for(int j = 0; j < n; j++) {
        matrix[i,j] = (i * n) + j;
      }
    }
    return matrix;
  }
}