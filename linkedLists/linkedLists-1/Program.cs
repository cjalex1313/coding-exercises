// Write a program to remove duplicates from a unordered linked list
// Implement it without using a temporary buffer

namespace Program;

public class Program {
  public static void Main() {
    Node node = new Node(5);
    node.AppendToTail(3);
    node.AppendToTail(5);
    node.AppendToTail(2);
    node.AppendToTail(1); 
    node.AppendToTail(4); 
    node.AppendToTail(1); 
    node.AppendToTail(4); 
    node.AppendToTail(1); 
    node.AppendToTail(1);

    RemoveDuplicates(node);

    Console.WriteLine(node.Data);
    while(node.Next != null) {
      node = node.Next;
      Console.WriteLine(node.Data);
    }
  }

  private static void RemoveDuplicates(Node node)
  {
    if (node == null) {
      return;
    }
    var p1 = node;
    while (p1 != null) {
      var p2 = p1;
      while(p2.Next != null) {
        if (p2.Next.Data == p1.Data) {
          p2.Next = p2.Next.Next;
        } else {
          p2 = p2.Next;
        }
      }
      p1 = p1.Next;
    }
  }
}