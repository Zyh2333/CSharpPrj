using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework4_2
{
    class Time{
        private int second;
        private int minute;
        private int hour;
        public int S
        {
            set => second = value;
            get => second;
        }
        public int M
        {
            set => minute = value;
            get => minute;
        }
        public int H
        {
            set => hour = value;
            get => hour;
        }
    }
    class Clock
    {
        //事件申明及触发类
        public event Action<object> Tick;
        public event Action<object,Time> Alarm;
        public Time current = new Time();
        public Time alarmTime = new Time();
        public void setAlarmTime(Time t)
        {
            alarmTime.S = t.S;
            alarmTime.H = t.H;
            alarmTime.M = t.M;
        }
        public void setClock()
        {
            current.S = DateTime.Now.Second;
            current.M = DateTime.Now.Minute;
            current.H = DateTime.Now.Hour;
            Tick(this);
            Alarm(this, alarmTime);
        }
    }
    class ClockHandler
    {
        public Clock cl = new Clock();
        //实现事件绑定
        public ClockHandler() {
            cl.Tick += this.getTick;
            cl.Alarm += this.getAlarm;
        }
        public void getTick(Object sender)
        {
            Console.WriteLine("tick");
        }
        public void getAlarm(object sender,Time t)
        {
            if (cl.current.H == t.H && cl.current.M == t.M && cl.current.S == t.S)
            {
                Console.WriteLine("ring");
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int i = 0;
            ClockHandler clh = new ClockHandler();
            Time alTime = new Time();
            alTime.H = 17;
            alTime.M = 33;
            alTime.S = 0;
            clh.cl.setAlarmTime(alTime);
            while (i < 200)
            {
                clh.cl.setClock();
                Thread.Sleep(1000);
            }
        }
    }
}
