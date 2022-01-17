
namespace Exercise;

public class Program {
  public static void Main() {
    LLNode l1Head = new LLNode(9, new LLNode(6, new LLNode(1, new LLNode(9))));

    LLNode l2Head = new LLNode(1, new LLNode(2, new LLNode(3, new LLNode(4))));
    LLNode resultHead = AddLists(l1Head, l2Head);
    PrintList(resultHead);
  }

  private static void PrintList(LLNode resultHead)
  {
    var current = resultHead;
    while (current != null) {
      Console.WriteLine(current.Data);
      current = current.Next;
    }
  }

  private static LLNode AddLists(LLNode l1, LLNode l2)
  {
    var l1Lenght = GetLength(l1);
    var l2Length = GetLength(l2);

    if (l1Lenght < l2Length) {
      l1 = PadList(l1, l2Length - l1Lenght);
    } else if (l2Length < l1Lenght) {
      l2 = PadList(l2, l1Lenght - l2Length);
    }

    LLNode? result = AddNodes(l1, l2);
    if(result == null) throw new Exception("Input error");

    if (result.Data >= 10) {
      result.Data -= 10;
      result = new LLNode(1, result);
    }
    return result;
  }

  private static int GetLength(LLNode l1)
  {
    int sum = 1;
    var current = l1;
    while(current.Next != null) {
      current = current.Next;
      sum++;
    }
    return sum;
  }

  private static LLNode? AddNodes(LLNode? node1, LLNode? node2)
  {
    if (node1 == null || node2 == null) {
      return null;
    }
    var current = new LLNode(node1.Data + node2.Data);

    var nextNode = AddNodes(node1.Next, node2.Next);
    if (nextNode == null) {
      return current;
    }
    current.Next = nextNode;
    if (nextNode.Data >= 10) {
      nextNode.Data -= 10;
      current.Data++;
    }
    return current;
  }

  private static LLNode PadList(LLNode l, int n)
  {
    if (n < 0) throw new Exception("Bad padding value");
    for (int i = 0; i < n; i++) {
      l = new LLNode(0, l);
    }
    return l;
  }
}

public class LLNode {
  public int Data {get;set;}
  public LLNode? Next {get;set;}
  public LLNode(int data, LLNode? node = null) 
  {
      Data = data;
      Next = node;
  }
}
