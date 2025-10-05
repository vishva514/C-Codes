using System;
using System.Collections.Generic;
public interface ISubscriber
{
    void Update(string news);
}

public class Subscriber : ISubscriber
{
    private string _name;

    public Subscriber(string name)
    {
        _name = name;
    }

    public void Update(string news)
    {
        Console.WriteLine($"{_name} received news: {news}");
    }
}
public class NewsPublisher
{
    private List<ISubscriber> subscribers = new List<ISubscriber>();

    public void AddSubscriber(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }
    public void RemoveSubscriber(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }
    public void Notify(string news)
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update(news);
        }
    }
}
class Program
{
    static void Main()
    {
        NewsPublisher publisher = new NewsPublisher();
        ISubscriber s1 = new Subscriber("Alice");
        ISubscriber s2 = new Subscriber("Bob");
        ISubscriber s3 = new Subscriber("Charlie");
        publisher.AddSubscriber(s1);
        publisher.AddSubscriber(s2);
        publisher.AddSubscriber(s3);
        publisher.Notify("Breaking News: Observer Pattern in C#!");

        Console.WriteLine("\n--- Bob unsubscribed ---\n");
        publisher.RemoveSubscriber(s2);
        publisher.Notify("Update: Observer Pattern explained with example!");
    }
}
