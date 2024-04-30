using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomCollection
{

public class MathsOperationsCollection<T> : ICustomCollection<T>, IEnumerable<T>
{
    private class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;
    private int count;

    public void Add(T item)
    {
            CheckNumerical(item.ToString());
            Node newNode = new Node(item);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        count++;
    }
        public static void CheckNumerical(string item)
        {
            try
            {
                double.Parse(item.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter only numerical value!", ex.Message);
                throw;
            }
        }
        public bool Remove(T item)
    {
        Node current = head;
        Node previous = null;

        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, item))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
                return true;
            }

            previous = current;
            current = current.Next;
        }

        return false;
    }

    public bool Contains(T item)
    {
        Node current = head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, item))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public T GetMedian()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }

        List<T> sortedList = new List<T>(this);
        sortedList.Sort();

        int middle = count / 2;

        if (count % 2 == 0)
        {
            // Even number of elements, return the average of the two middle values
            dynamic value1 = sortedList[middle - 1];
            dynamic value2 = sortedList[middle];
            return (value1 + value2) / 2;
        }
        else
        {
            // Odd number of elements, return the middle value
            return sortedList[middle];
        }
    }

    public T Sum()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }

        dynamic sum = 0;
        Node current = head;
        while (current != null)
        {
            sum += current.Data;
            current = current.Next;
        }
        return sum;
    }

    public T Average()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }

        dynamic sum = Sum();
        return sum / count;
    }

    public T Product()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }

        dynamic product = 1;
        Node current = head;
        while (current != null)
        {
            product *= current.Data;
            current = current.Next;
        }
        return product;
    }

    public T Maximum()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }

        dynamic max = head.Data;
        Node current = head.Next;
        while (current != null)
        {
            if (Comparer<T>.Default.Compare(current.Data, max) > 0)
            {
                max = current.Data;
            }
            current = current.Next;
        }
        return max;
    }

    public T Minimum()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }

        dynamic min = head.Data;
        Node current = head.Next;
        while (current != null)
        {
            if (Comparer<T>.Default.Compare(current.Data, min) < 0)
            {
                min = current.Data;
            }
            current = current.Next;
        }
        return min;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
}
