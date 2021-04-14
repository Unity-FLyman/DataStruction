using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array2Queue<E>
{
    private Array2<E> arr;

    public Array2Queue(int capacity)
    {
        arr = new Array2<E>(capacity);
    }

    public Array2Queue()
    {
        // 默认容量
        arr=new Array2<E>();
    } 

    public int Count
    {
        get { return arr.Count; }
    }
    public bool IsEmpty
    {
        get { return arr.IsEmpity; }
    }
    public void Enqueue(E e)
    {
        //进队
        arr.AddLast(e);
    }

    public E Dequeue()
    {
        //出队
        return arr.RemoveFirst();
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
