using System;
using System.Reflection;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;

        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
           IntListNode currentNode = First;
           IntListNode newNode = new IntListNode(value);
            if(currentNode == null)
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

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            int currentPos = 0;
            IntListNode currentNode = First;
            while (currentNode.Next != null && currentPos<index) 
            {
                currentNode = currentNode.Next;
                currentPos++;

            }
            if(currentPos == index)
            {
                return currentNode;
            }
            return null;
        }

        
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            if(index < 0 || index> Count())
            {
                return 0;
            }
            IntListNode x = GetNode(index);
            return x.Value;
        }

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            int pos = 0;
            IntListNode currentNode = First;
            if(currentNode != null)
                pos++;
            else
            {
                return pos = 0;
            }
            while (currentNode.Next != null) 
            {
                currentNode= currentNode.Next;
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
            if(index == 0)
            {
                First = First.Next;
            }
            else
            {
                IntListNode nodo = GetNode(index - 1);
                nodo.Next = GetNode(index-1).Next.Next;
            }
            
            
        }

        
        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            First = null;

        }
    }
}