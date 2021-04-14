using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList1Queue<E>:IQueue<E>
{
    private LinkList1<E> list;

    public LinkedList1Queue()
    {
        list=new LinkList1<E>(); //初始化链表
    }

    public int Count 
    {
        get { return list.Count; }
    }

    public bool IsEmpty
    {
        get { return list.IsEmpty; }
    }
    public void Enqueue(E e)
    {
        list.AddLast(e);
    }
    

    public E Dequeue()
    {
        return list.RemoveFirest();
    }

    public E Peek()
    {
        return list.Getthefirst();
    }

    public override string ToString()
    {
        return "QUEUE FROMT" + list.ToString() + "tail";
    }
}
