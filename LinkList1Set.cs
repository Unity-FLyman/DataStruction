using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkList1Set<E>:Iset<E>
{
    private LinkList1<E> list;

    public LinkList1Set()
    {
        list=new LinkList1<E>();
        
    }

    public int Count
    {
        get { return list.Count; }
    }

    public bool IsEmpty
    {
        get { return list.IsEmpty; }
    }
    public void Add(E e)
    {
        // 如果集合中不包含元素e
        if (!list.Contains(e))
        {
           list.AddFirst(e);
        }
    }

    public void Remove(E e)
    {
        list.Remove(e);
    }

    public bool Contains(E e)
    {
        return list.Contains(e);
    }
}
