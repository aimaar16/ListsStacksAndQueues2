using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        GenericListNode<T> currentNode = First;
        GenericListNode<T> newNode = new GenericListNode<T>(value);
        if (currentNode == null)
        {
            First = newNode;
        }
        else
        {
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
        }
    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'
        int currentPos = 0;
        GenericListNode<T> currentNode = First;
        while (currentNode.Next != null && currentPos < index)
        {
            currentNode = currentNode.Next;
            currentPos++;

        }
        if (currentPos == index)
        {
            return currentNode;
        }
        return null;

    }

    public T Get(int index)
    {
<<<<<<< HEAD
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
        GenericListNode<T> list = null;
        list = null;
        if (index < 0 || index > Count())
        {
            return list.Value;
        }
        GenericListNode<T> x = FindNode(index);
        return x.Value;
=======
        //TODO #3: return the element on the index-th position. YOU MUST USE FindNode(int). Return the default value for object class T if the position is out of bounds

        return default(T);
>>>>>>> 66727ab734f29d21a13616e2afeecfc19e4aeae5
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list

        int pos = 0;
        GenericListNode<T> currentNode = First;
        if (currentNode != null)
            pos++;
        else
        {
            return pos = 0;
        }
        while (currentNode.Next != null)
        {
            currentNode = currentNode.Next;
            pos++;
        }
        return pos;
    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        if (index > Count())
        {
            return;
        }
        if (index == 0)
        {
            First = First.Next;
        }
        else
        {
            GenericListNode<T> nodo = FindNode(index - 1);
            nodo.Next = FindNode(index - 1).Next.Next;
        }
    }

    public void Clear()
    {
        //TODO #6: remove all the elements on the list
        First = null;
    }
}