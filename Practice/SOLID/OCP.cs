using System;

interface ISerial
{
    string serialNumber { get; }
}

interface ISpec
{
    int price { get; }
}

class Guitar : ISerial
{
    public string serialNumber => _serialNumber;
    private string _serialNumber;
    private GuitarSpec spec;
    public Guitar(string _number, GuitarSpec _spec)
    {
        _serialNumber = _number;
        spec = _spec;
    }
}

class GuitarSpec : ISpec
{
    public int price => _price;
    private int _price;

    public GuitarSpec(int _p)
    {
        _price = _p;
    }
}

class Violin : ISerial
{
    public string serialNumber => _serialNumber;
    private string _serialNumber;
    private ViolinSpec spec;
    public Violin(string _number, ViolinSpec _spec)
    {
        _serialNumber = _number;
        spec = _spec;
    }
}

class ViolinSpec : ISpec
{
    public int price => _price;
    private int _price;

    public ViolinSpec(int _p)
    {
        _price = _p;
    }
}

class Program1
{
    public static void Main1()
    {
        Guitar guitar = new Guitar("123", new GuitarSpec(100));
        Violin violin = new Violin("231", new ViolinSpec(112));
    }
}
