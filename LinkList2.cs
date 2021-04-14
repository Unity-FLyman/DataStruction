using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class LinkList2<E>
{
    private class Node
    {
        public E e;
        public Node next;

        public Node(E e, Node next)
        {
            this.e = e;
            this.next = next;
        }

        public Node(E E)
        {
            this.e = E;
            this.next = null;
        }

        public override string ToString()
        {
            return e.ToString();
            
        }
        
    }

    private Node Head;
    private Node tail;
    private int N;

    public LinkList2()
    {
        Head = null;
        tail = null;
        N = 0;

    }

    public int Count
    {
        get { return N; }

    }

    public bool IsEmpty
    {
        get { return N == 0; }

    }

    public void AddLast(E e)
    {
        Node node=new Node(e);
        if (IsEmpty)
        {
            Head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }

        N++;
    }

    public E RemoveFirst()
    {
        if(IsEmpty)
            Debug.Log("链表为空");

        E e = Head.e;
        Head = Head.next;
        N--;

        if (Head == null)
            tail = null;
        return e;
        
    }
    
    public E GetFirst()
    {
        return Head.e;
    }

    public override string ToString()
    {
        StringBuilder res = new StringBuilder();
        Node cur = Head;
        while (cur != null)
        {
            res.Append(cur + "->");
            cur = cur.next;
        }

        res.Append("Null");
        return res.ToString();
    }
}
