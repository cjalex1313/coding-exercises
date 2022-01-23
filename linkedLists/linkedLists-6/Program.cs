// Write a program that given a circular linked list return the node where the loop starts

namespace Program;

public class Program {
  public static void Main() {
    var head = new LNode {
      Value = 1
    };
    var current = head;
    LNode? five = null;
    for (int i = 2; i <= 9; i++) {
      var next = new LNode {
        Value = i
      };
      if (i == 5) {
        five = next;
      }
      current.Next = next;
      current = current.Next;
    }
    current.Next = five;

    LNode? loopStart = GetLoopStart(head);
    if (loopStart == null) {
      Console.WriteLine("Something went wrong");
    } else {
      Console.WriteLine(loopStart.Value);
    }
  }

  private static LNode? GetLoopStart(LNode head)
  {
    if (head == null)
      return null;
    LNode? p1 = head.Next;
    LNode? p2 = head.Next?.Next;
    while (p1 != p2) {
      p1 = p1?.Next;
      p2 = p2?.Next?.Next;
    }
    p1 = head;
    while (p1 != p2) {
      p1 = p1?.Next;
      p2 = p2?.Next;
    }
    return p1;
  }
}

public class LNode {
  public int Value {get;set;}
  public LNode? Next {get;set;}
}