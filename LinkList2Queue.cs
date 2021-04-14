using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkList2Queue <E>
{
    private LinkList2<E> list;

    public LinkList2Queue()
    {
        list=new LinkList2<E>(); //初始化链表
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
        return list.RemoveFirst();
    }

    public E Peek()
    {
        return list.GetFirst();
    }

    public override string ToString()
    {
        return "QUEUE FROMT" + list.ToString() + "tail";
    }
}
