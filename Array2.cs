using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

/// <summary>
/// 循环数组
/// </summary>
/// <typeparam name="E"></typeparam>
public  class Array2 <E>
{
  
  private E[] data;
  private int first;
  private int last;
  private int N;

  public Array2(int capacity)
  {
    data=new E[capacity];
    first = 0;
    last = 0;
    N = 0;
  }
  public Array2() //重载
  {
    // 数组开十个空间
    data =new E[10];
    N = 0;
  }

  public int Count
  {
    get { return N; }
  }

  public bool IsEmpity
  {
    get { return N == 0; }
  }

  public void AddLast(E e)
  {
    if (N==data.Length)
    {
      //扩容
      ResetCapacity(2*data.Length);
    }
    
    data[last] = e;
    last = (last + 1) % data.Length;
    N++;
  }

  public E RemoveFirst()
  {
    if (IsEmpity)
    {
      Debug.Log("数组为空");
    }
    E net = data[first];// 先把需要删除的数存起来
    data[first] = default(E);
    first = (first + 1) % data.Length;
    N--;

    if (N==data.Length/4)
    {
      // 释放空间 缩容
      ResetCapacity(data.Length/2);
    }
    return net;
  }

  public E GetFirst()
  {
    if (IsEmpity)
    {
      Debug.Log("数组为空");
      
    }
    return data[first];
  }

  private void ResetCapacity(int newCpacity)
  {
    E[] newData=new E[newCpacity];
    for (int i = 0; i < N; i++)
    {
      newData[i] = data[(first + i) % data.Length];
    }

    data = newData;
    first = 0;
    last = N;
  }

  public override string ToString()
  {
    StringBuilder res=new StringBuilder();
    res.Append("[");
    for (int i = 0; i < N; i++)
    {
      res.Append(data[(first + 1) % data.Length]);
      if ((first+i+1)%data.Length!=last)
      {
        res.Append(",");
      }
    }

    res.Append("]");
    return res.ToString();


  }
}
