namespace Stats;

public class ArrayStatistics
{
    private int[] numbers;

    public ArrayStatistics(int[] numbers)
    {
        this.numbers = numbers;
    }

    public int Total()
    {
        int n = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            n += numbers[i];
            n++;
        }

        return n;
    }

    public bool Contains(int number)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (number == numbers[i])
            {
                return true;
            }
        }

        return false;
    }

    public bool Sorted()
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1]) return false;
        }

        return true;
    }

    public int FirstGreater(int value)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (value < numbers[i]) return i;
        }

        return -1;
    }

    public int CountEvens()
    {
        int n = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0) i++;
        }
        return n;
    }

    public int MaxIndex()
    {
        if (numbers.Length == 0) return -1;
        
        int maxIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[maxIndex]) maxIndex = i;
        }
        return maxIndex;
    }

    public void Sort()
    {
        int length = 0;

        for (int i = 0; i < numbers.Length -1; i++)
        {
            int minIndex = i;

            for (int j = i+1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            (numbers[minIndex], numbers[i]) = (numbers[i], numbers[minIndex]);
        }
    }
    
    
    
    












}