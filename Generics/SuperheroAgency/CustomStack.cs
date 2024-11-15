using System.Collections;

namespace SuperheroAgency;

internal class CustomStack<T> : ICollection<T>
{
    private T[] items = Array.Empty<T>();

    public int Count => ((ICollection<T>)items).Count;

    public bool IsReadOnly => ((ICollection<T>)items).IsReadOnly;

    public void Push(T item)
    {
        Array.Resize(ref items, items.Length + 1);
        items[items.Length - 1] = item;
    }

    public T Pop()
    {
        T result = items[items.Length - 1];
        Array.Resize(ref items, items.Length - 1);
        return result;
    }

    public void Add(T item)
    {
        ((ICollection<T>)items).Add(item);
    }

    public void Clear()
    {
        ((ICollection<T>)items).Clear();
    }

    public bool Contains(T item)
    {
        return ((ICollection<T>)items).Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        ((ICollection<T>)items).CopyTo(array, arrayIndex);
    }

    public bool Remove(T item)
    {
        return ((ICollection<T>)items).Remove(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)items).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return items.GetEnumerator();
    }
}
