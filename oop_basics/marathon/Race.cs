namespace marathon;

public class Race
{
    private Team[] teams;

    public Race(int n)
    {
        this.teams = new Team[n];
    }

    public void Move()
    {
        for (int i = 0; i < teams.Length; i++)
        {
            teams[i].Move();
        }
    }

    public bool End()
    {
        int stillRace = 0;
        for (int i = 0; i < teams.Length; i++)
        {
            if (teams[i].End())
            {
                stillRace++;
            }
        }
        return stillRace == 0;
    }

    public string Display()
    {
        string actualSitu = null;
        for (int i = 0; i < teams.Length; i++)
        {
            actualSitu += teams[i].Display() + "\n";
        }
        return actualSitu;
    }

    public Team[] Results()
    {
        int finishCount = 0;
        for (int i = 0; i < teams.Length; i++)
        {
            if (teams[i].GetActualD() == 42)
            {
                finishCount++;
            }
        }
        
        //A beérkezett csapatokat menti ki és rendezi sorba egyből
        
        Team[] finishedTeam = new Team[finishCount];
        int finishedI = 0;

        for (int i = 0; i < teams.Length; i++)
        {
            if (teams[i].GetActualD() == 42)
            {
                finishedTeam[finishedI] = teams[i];
                finishedI++;
            }
        }

        for (int i = finishedTeam.Length; i >= 2; i--)
        {
            int idx = 0;
            for (int j = 1; j < i-1; j++)
            {
                if (finishedTeam[j].GetActualT() > finishedTeam[j+1].GetActualT())
                {
                    Team temp = finishedTeam[j];
                    finishedTeam[j] = finishedTeam[j + 1];
                    finishedTeam[j + 1] = temp;
                    idx = j;
                }
            }
            i = idx;
        }

        return finishedTeam;
    }
}