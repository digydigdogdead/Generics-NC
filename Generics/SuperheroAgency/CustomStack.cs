namespace SuperheroAgency;

internal class CustomStack<T>
{
    private T[] items = Array.Empty<T>();
    public int Length() { return items.Length; }
    
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
}
