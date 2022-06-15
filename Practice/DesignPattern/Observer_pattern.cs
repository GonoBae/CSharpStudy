using System;

interface Youtuber
{
    void subscribe(Subscriber sub);
    void unsubscribe(Subscriber sub);
    void notify(string msg);
}

interface Subscriber
{
    void update(string msg);
}

class Gono : Youtuber
{
    private List<Subscriber> subscribers = new List<Subscriber>();

    public void eatFood()
    {
        Console.WriteLine("먹방");
        notify("먹방 중입니다.");
    }

    public void dance()
    {
        Console.WriteLine("춤방");
        notify("춤방 중입니다.");
    }

    public void notify(string msg)
    {
        foreach (Subscriber sub in subscribers)
        {
            sub.update(msg);
        }
    }

    public void subscribe(Subscriber sub)
    {
        subscribers.Add(sub);
    }

    public void unsubscribe(Subscriber sub)
    {
        subscribers.Remove(sub);
    }
}

class Danny : Subscriber
{
    public void update(string msg)
    {
        Console.WriteLine("Danny : " + msg);
    }
}

class Lala : Subscriber
{
    public void update(string msg)
    {
        Console.WriteLine("Lala : " + msg);
    }
}

class Land : Subscriber
{
    public void update(string msg)
    {
        Console.WriteLine("Land : " + msg);
    }
}

class Program2
{
    public static void Main1()
    {
        Gono gono = new Gono();
        Danny danny = new Danny();
        Lala lala = new Lala();
        Land land = new Land();

        gono.subscribe(danny);
        gono.subscribe(lala);
        gono.subscribe(land);

        gono.eatFood();

        gono.unsubscribe(lala);

        gono.dance();
    }
}