using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array1Stack<E>:IStack<E>
{
     private Array1<E> arr;

     public Array1Stack(int capacity)
     {
         arr = new Array1<E>(capacity);// 构造函数中初始化动态数组
     }

     public Array1Stack()
     { 
         arr=new Array1<E>(); ;
     }

     // 栈中含有多少个元素
     public int Count
     {
         get { return arr.Count; }
     }
     public bool IsEmpty
     {
         get { return arr.IsEmpty; }
     }
     public void Push(E e)
     {
        // 数组移动往后面添加元素是最不需要消耗性能的 因为往头添加元素的话需要将整个数组进行移动
        arr.AddLast(e);
     }

     public E Pop()
     {
        return  arr.RemoveLast();
     }

     public E Peek()
     {
         return arr.GetLast();
     }

     public override string ToString()
     {
         return "Statck:" + arr.ToString() + "top";
     }
}
