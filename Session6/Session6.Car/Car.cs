namespace Session6.Car
{
    public class Car
    {
        public string name;
        public string model;
        public string color;

        public Tier FrontLeft;
        public Tier FrontRight;
        public Tier BackLeft;
        public Tier BackRight;
       
    }

    public class Tier
    {
        public int height;
        public int width;
        public int pressure;
    }
}
