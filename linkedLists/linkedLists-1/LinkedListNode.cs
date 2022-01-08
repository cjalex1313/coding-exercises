namespace Program;

public class Node {
  public Node(int data)
  {
    this.Data = data;
    this.Next = null;   
  }
  public int Data {get;set;}
  public Node? Next {get;set;}

  public void AppendToTail(int d) {
    var current = this;
    while (current.Next != null) {
      current = current.Next;
    }
    var lastNode = new Node(d);
    current.Next = lastNode;
  }
}