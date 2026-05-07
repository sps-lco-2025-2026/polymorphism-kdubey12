using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance;

public class IHashSet<T>
{
    private readonly List<T?> _store;
    private int Size => _store.Count;

    public IHashSet(int initialSize)
    {
        _store = Enumerable.Range(0, initialSize).Select(_ => default(T?)).ToList();
    }

    public void Add(T item)
    {
        int index = item.GetHashCode() % Size;
        _store[index] = item;
    }

    public bool IsPresent(T item)
    {
        int index = item.GetHashCode() % Size;
        return _store[index]?.Equals(item) ?? false;
    }
}