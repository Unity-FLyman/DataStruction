using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDictionary<Key,Value>
{
    public  int Count { get; }
    public bool IsEmpty { get; }
    void Add(Key key, Value value);
    void Remove(Key key);
    void Set(Key key, Value newValue);
    Value Get(Key key);
}
