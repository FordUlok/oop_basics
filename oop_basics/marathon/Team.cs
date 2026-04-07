namespace marathon;

public class Team
{
    private Runner[] runners;
    private int actualR = 0;
    private int actualD = 0;
    private int actualT = 0;

    public Team(int n)
    {
        if (n == 2 || n == 3 || n == 5)
        {
            this.runners = new Runner[n];
        }
    }

    public int GetActualT()
    {
        return actualT;
    }
    public int GetActualD()
    {
        return actualD;
    }

    public bool GetIsInRace()
    {
        int weak = 0;
        for (int i = 0; i < runners.Length; i++)
        {
            if (runners[i].GetGaveUp())
            {
                weak++;
            }
        }
        return weak == 0;
        
    }

    public void Move()
    {
        runners[actualR].Move();
        actualD += runners[actualR].GetPace() / 60;
        actualT++;

        switch (runners.Length, actualR, actualD)
        {
            case(2, 0, >= 21):
                actualR++;
                break;
            case(3, 0, >= 10):
                actualR++;
                break;
            case(3, 1, >= 30):
                actualR++;
                break;
            case(5, 0, >= 8):
                actualR++;
                break;
            case(5, 1, >= 18):
                actualR++;
                break;
            case(5, 2, >= 25):
                actualR++;
                break;
            case(5, 3, >= 36):
                actualR++;
                break;
        }
    }

    public bool End()
    {
        int stillR = 0;
        if (actualD < 42)
        {
            for (int i = 0; i < runners.Length; i++)
            {
                if (!runners[i].GetGaveUp())
                {
                    stillR++;
                }
            }
        }
        return stillR == runners.Length;
    }

    public string MemberNames()
    {
        string nameAll = null;
        for (int i = 0; i < runners.Length; i++)
        {
            nameAll += runners[i].GetName() + "\n";
        }
        return nameAll;
    }

    public string Display()
    {
        string actualPosi = null;
        for (int i = 0; i < 43; i++)
        {
            if (i == actualD)
            {
                actualPosi += i + " X " + runners[actualR].GetName();
            }
            else
            {
                actualPosi += i + ". ";
            }
        }
        return actualPosi;
    }
    
    
    
}