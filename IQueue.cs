using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQueue<E>
{
    int Count { get; }
    bool IsEmpty { get;}
    void Enqueue(E e); // 向中间添加元素
    E Dequeue(); // 出队
    E Peek();// 查看元素
}
