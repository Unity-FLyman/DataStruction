using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iset<E>
{
    int Count { get; }
    bool IsEmpty { get; }
    void Add(E e);
    void Remove(E e);
    bool Contains(E e);
}
