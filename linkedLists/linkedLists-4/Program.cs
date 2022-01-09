// Write a program to partition a linked list around a value x
// such that all emenets smaller than x come before all elements greater or equal to x

namespace Program;

public class Program {
  public static void Main() {
    var head = new Node(5);
    head.AppendToTail(1);
    head.AppendToTail(3);
    head.AppendToTail(6);
    head.AppendToTail(5);
    head.AppendToTail(2);
    head.AppendToTail(3);
    head.AppendToTail(6);
    head.AppendToTail(1);
    head.AppendToTail(8);
    head.AppendToTail(3);

    PrintLinkedList(head);

    head = PartitionLinkedList(head, 5);

    PrintLinkedList(head);
  }

  private static Node? PartitionLinkedList(Node head, int v)
  {
    Node? beforeStart = null;
    Node? beforeEnd = null;
    Node? afterStart = null;
    Node? afterEnd = null;
    
    Node? current = head;
    while(current != null) {
      Node? next = current.Next;
      current.Next = null;
      if (current.Data < v) {
        if (beforeStart == null || beforeEnd == null) {
          beforeStart = current;
          beforeEnd = beforeStart;
        } else {
          beforeEnd.Next = current;
          beforeEnd = current;
        }
      } else {
        if (afterStart == null || afterEnd == null) {
          afterStart = current;
          afterEnd = afterStart;
        } else {
          afterEnd.Next = current;
          afterEnd = current;
        }
      }
      current = next;
    }
    if (beforeStart == null || beforeEnd == null) {
      return afterStart;
    }
    beforeEnd.Next = afterStart;
    return beforeStart;
  }

  private static void PrintLinkedList(Node? head)
  {
    Node? current = head;
    while (current != null) {
      Console.WriteLine(current.Data);
      current = current.Next;
    }
    Console.WriteLine();
  }
}