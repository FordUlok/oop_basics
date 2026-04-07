namespace marathon;

public class Runner
{
    private string name;
    private int pace;
    private int time;
    private bool gaveUp;

    public Runner(string name, int pace)
    {
        this.name = name;
        if (3 <= pace && pace <= 9)
        {
            this.pace = pace;
        }
    }

    public string GetName() { return name; }
    public void SetName(string name) { this.name = name; }
    
    public int GetPace() { return pace; }
    public void SetPace(int pace) { this.pace = pace; }

    public int GetTime() { return time; }
    public void SetTime(int time) { this.time = time; }

    public bool GetGaveUp() { return gaveUp; }
    public void SetGaveUp(bool gaveUp) { this.gaveUp = gaveUp; }

    private static Random rnd = new Random();
    
    public int Move()
    {
        if (gaveUp)
        {
            return 0;
        }
        else
        {
            this.time++;
            double quitChance = 0;
            
            if (time > 180)
            {
                quitChance = 0.005;
            }
            else if (time > 120)
            {
                quitChance = 0.003;
            }
            else if (time > 90)
            {
                quitChance = 0.002;
            }
            else if (time > 60)
            {
                quitChance = 0.001;
            }

            if (rnd.NextDouble() < quitChance)
            {
                gaveUp = true;
                return 0;
            }

            if (time % pace == 0)
            {
                return 1;
            }

            return 0;
        }
    }

    public string Display()
    {
        string runnerName = name;
        if (gaveUp)
        {
            runnerName += " (Gave Up)";
        }
        return runnerName;
    }
}