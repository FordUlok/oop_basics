namespace Pitfall;

public class Stack
{
    private char[] items;
    private int count;

    public Stack(int maxSize)
    {
        items = new char[maxSize];
        count = 0;
    }

    public bool Full()
    {
        return count == items.Length;
    }

    public bool Empty()
    {
        return count == 0;
    }

    public bool Push(char newItem)
    {
        if (Full()) return false;

        items[count] = newItem;
        count++;
        return true;
    }

    public bool Pop(out char item)
    {
        if (Empty())
        {
            item = default;
            return false;
        }

        count--;
        item = items[count];
        return false;
    }
}