using System.Collections;

namespace DesignPatterns.Iterator;

public class Queue<T> : IEnumerable<T>, ICollection
{
    public int Capacity { get; private set; }
    private T[] _data;
    private int _count;
    private int _head;
    private int _tail = -1;

    public Queue()
    {
        Capacity = 3;
        _data = new T[Capacity];
    }

    public void Enqueue(T item)
    {
        if (_count == Capacity)
        {
            T[] newArray = new T[Capacity * 2];
            for (int i = _head; i < _head + _count; i++)
            {
                newArray[i - _head] = _data[i % Capacity];
            }
            _data = newArray;
            
            Capacity *= 2;
            _head = 0;
            _tail = _count - 1;
        }

        _count += 1;

        _tail = (_tail + 1) % Capacity;
        _data[_tail] = item;
    }

    public T Dequeue()
    {
        if (_count == 0)
            throw new InvalidOperationException("Queue is empty");

        _count -= 1;

        var toReturn = _data[_head];
        _head = (_head + 1) % Capacity;
        return toReturn;
    }

    public IEnumerator<T> GetEnumerator()
    {
        if (_count > 0)
            for (int i = _head; i < _head + _count; i++)
            {
                yield return _data[i % Capacity];
            }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void CopyTo(Array array, int index)
    {
        Array.Copy(_data, 0, array, index, _count);
    }

    public int Count => _count;
    public bool IsSynchronized => false;
    public object SyncRoot => _data.SyncRoot;
    public bool IsReadOnly => false;
}