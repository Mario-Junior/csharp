GenericList<int> myList1 = new();
Console.WriteLine(myList1);

GenericList<string> myList2 = new();
Console.WriteLine(myList2);

// Outro Exemplo:
// GenericList<SomeClass> myList = new();

public class GenericList<T>
{
  private class Node
  {
    public T Value;
    public Node? Next;

    public Node(T t)
    {
      Value = t;
      Next = null;
    }
  }

  private Node Head;

  public GenericList()
  {
    Head = null;
  }

  public void Add(T input)
  {

  }
}
