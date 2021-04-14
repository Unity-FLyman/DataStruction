using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStack <E>
{
    int Count { get; }
    bool IsEmpty { get; }
    void Push(E e); // 向中间添加元素
    E Pop(); // 删除栈顶的元素并返回
    E Peek();// 查看栈顶的元素
}
