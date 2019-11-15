using System;

public class LinkedListGen<T>
{
    public class Node<U>
    {
        // link to next Node in list
        public Node<U> next = null;
        // value of this Node
        public U data;
    }

    private Node<T> root = null;

    public Node<T> First
    {
        get
        {
            return root;
        }
    }

    public bool Any()
    {
        return root != null;
    }

    public void AddLast(T value)
    {
        Node<T> n = new Node<T> { data = value };
        if (root == null)
        {
            root = n;
        }
        else
        {
            Node<T> curr = root;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = n;
        }
    }

    public void Remove(T data)
    {
        if (root != null && Object.Equals(root.data, data))
        {
            var node = root;
            root = node.next;
            node.next = null;
        }
        else
        {
            Node<T> curr = root;
            while (curr.next != null)
            {
                if (curr.next != null && Object.Equals(curr.next.data, data))
                {
                    var node = curr.next;
                    curr.next = node.next;
                    node.next = null;
                    break;
                }
                curr = curr.next;
            }
        }
    }
}