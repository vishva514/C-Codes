using System;

namespace EventDemo
{

    public delegate void AlarmEventHandler(string message);

 
    class AlarmClock
    {

        public event AlarmEventHandler Ring;

        public void StartAlarm()
        {
            Console.WriteLine("Alarm is starting...");
            if (Ring != null)
            {
                Ring("Wake up! It's time to get up!");
            }
        }
    }

    class Person
    {
        public void AlarmRang(string msg)
        {
            Console.WriteLine("Person heard the alarm: " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarm = new AlarmClock();  
            Person person = new Person();         

            alarm.Ring += person.AlarmRang;
            alarm.StartAlarm();

            Console.ReadLine();
        }
    }
}
