// Implement a method to get the kth to last element from a singly linked list

namespace Program;

public class Program {
  public static void Main() {
    var node = new Node(5);
    node.AppendToTail(1);
    node.AppendToTail(2);
    node.AppendToTail(3);
    node.AppendToTail(4);
    node.AppendToTail(5);
    node.AppendToTail(6);
    node.AppendToTail(7);
    node.AppendToTail(8);
    node.AppendToTail(9);
    node.AppendToTail(10);


    int k = 2;
    Node? result = GetKToLastNode(node, k);
    if (result != null)
      Console.WriteLine(result.Data);
  }

  private static Node? GetKToLastNode(Node node, int k)
  {
    if (node == null) {
      throw new Exception("Linked list not big enough");
    }
    Node? p1 = node;
    Node? p2 = node;
    while(k > 0) {
      if (p2 == null) return null;
      p2 = p2.Next;
      k--;
    }
    while (p2 != null && p1 != null) {
      p1 = p1.Next;
      p2 = p2.Next;
    }
    return p1;
  }
}