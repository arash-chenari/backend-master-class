public class Car
{
    public Car(Engin engin)
    {
        this.engin = engin;
    }
    
    private int speed;
    
    public string name;
    public string model;
    private Color color;

    public Engin engin;

    public Tier leftFront;
    public Tier rightFront;
    public Tier leftBack;
    public Tier rightBack;

    public void SetColor(Color color)
    {
        this.color = color;
    }

    public Color GetColor()
    {
        return color;
    }

    public int Speed()
    {
        return speed;
    }

    public void Accelerate()
    {
        if (speed < 70)
        {
            speed += 10;
        }

        engin.SetRpm(speed);
    }

    public void Break()
    {
        if (speed > 0)
        {
            speed -= 10;
        }
        engin.SetRpm(speed);
    }
}

public enum Color
{
    Red,
    Black,
    White
}

