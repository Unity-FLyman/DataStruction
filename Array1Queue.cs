using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array1Queue<E>:IQueue<E>
{
    private Array1<E> arr;

    public Array1Queue(int capacity)
    {
        arr = new Array1<E>(capacity);
    }

    public Array1Queue()
    {
        // 默认容量
        arr=new Array1<E>();
    } 

    public int Count
    {
        get { return arr.Count; }
    }
    public bool IsEmpty
    {
        get { return arr.IsEmpty; }
    }
    public void Enqueue(E e)
    {
        //进队
        arr.AddLast(e);
    }

    public E Dequeue()
    {
        //出队
        return arr.Removefirst();
    }

    public E Peek()
    {
        return arr.GetFirst();
    }

    public override string ToString()
    {
        return "Queue:Front" + arr.ToString() + "tail";
    }
}
