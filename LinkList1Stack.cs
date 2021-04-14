using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkList1Stack<E>:IStack<E>
{
    private LinkList1<E> list;// 新建一个链表

    public LinkList1Stack()
    {
        list=new LinkList1<E>();
    }


    public int Count
    {
        get { return list.Count;}
    }
    public bool IsEmpty
    {
        get { return list.IsEmpty; }
    }
    public void Push(E e)
    {
        list.AddFirst(e);
    }

    public E Pop()
    {
        return list.RemoveFirest();
    }

    public E Peek()
    {
        return list.Getthefirst();
    }

    public override string ToString()
    {
        return "Stack:top" + list.ToString();
    }
}
