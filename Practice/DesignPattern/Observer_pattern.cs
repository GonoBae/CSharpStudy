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

class Holy : Youtuber
{
    private List<Subscriber> subscribers = new List<Subscriber>();

    public void food()
    {
        Console.WriteLine("먹 방");
        notify("먹방 방송이 시작되었습니다.");
    }

    public void dance()
    {
        Console.WriteLine("춤 방");
        notify("춤방 방송이 시작되었습니다.");
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

class ObserverPattern
{
    public static void Main1()
    {
        Holy holy = new Holy();
        Danny danny = new Danny();
        Lala lala = new Lala();
        Land land = new Land();

        holy.subscribe(danny);
        holy.subscribe(lala);
        holy.subscribe(land);

        holy.food();

        holy.unsubscribe(lala);

        holy.dance();
    }
}