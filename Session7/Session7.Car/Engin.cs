
using System.Net.Http.Headers;

public class Engin
{
    public Engin(int cylinder)
    {
        this.cylinder = cylinder;
    }

    public void Start()
    {
        state = EnginState.On;
        rpm = 1000;
    }

    public void TurnOff()
    {
        state = EnginState.Off;
        rpm = 0;
    }

    public int Rpm()
    {
        return rpm;
    }

    public void SetRpm(int speed)
    {
        switch (speed)
        {
            case int s when (s > 0 && s < 20):
                rpm = 1000;
                break;

            case int s when (s > 20 && s < 50):
                rpm = 3000;
                break;

            case int s when (s > 50 && s < 70):
                rpm = 5000;
                break;
        }
    }
    public EnginState state;

    public int cylinder;
    private int rpm;
}

public enum EnginState
{
    On,
    Off
}
