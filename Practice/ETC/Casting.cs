using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Computer
{
    public void TurnOn()
    {
        Console.WriteLine("Turn On!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turn Off!");
    }
}

class MacBook : Computer
{
    public void Chatting()
    {
        Console.WriteLine("Chatting!");
    }
}

class Casting
{
    //public static void Main()
    //{
    //    // Up-Casting _ 암시적
    //    Computer com = new MacBook(); // 맥북 클래스의 인스턴스이며, 타입은 컴퓨터
    //    // 타입이 Computer 이기 때문에 Chatting 호출 불가
    //    com.TurnOn();
    //    com.TurnOff();
        

    //    Computer com2 = new MacBook(); // 암시적 Up-Casting
    //    MacBook mac2 = (MacBook)com2; // Down-Casting _ 명시적

    //    mac2.TurnOn();
    //    mac2.Chatting();
    //}
}