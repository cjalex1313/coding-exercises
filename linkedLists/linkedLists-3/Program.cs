// Write a program to remove a node from the middle of a linked list only having access to that node

namespace Program;

public class Program{
  public static void Main() {
    Node head = new Node(5);
    head.AppendToTail(1);
    head.AppendToTail(2);
    head.AppendToTail(3);
    head.AppendToTail(4);
    head.AppendToTail(5);
    head.AppendToTail(6);
    head.AppendToTail(7);
    head.AppendToTail(8);
    head.AppendToTail(9);
    head.AppendToTail(10);

    Node? toDelete = head;
    if (toDelete.Next != null) toDelete = toDelete.Next;
    if (toDelete.Next != null) toDelete = toDelete.Next;
    if (toDelete.Next != null) toDelete = toDelete.Next;

    RemoveNode(toDelete);

    Node? current = head;
    while(current != null) {
      Console.WriteLine(current.Data);
      current = current.Next;
    }
  }

  private static void RemoveNode(Node? toDelete)
  {
    if (toDelete == null || toDelete.Next == null) return;

    toDelete.Data = toDelete.Next.Data;
    toDelete.Next = toDelete.Next.Next;
  }
}