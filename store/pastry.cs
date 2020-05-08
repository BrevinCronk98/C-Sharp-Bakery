using System;

namespace Order.Pastry
{
    public class Pastry
    {
    private string _name;
    private int _cost;

    public  Pastry()
    {
        _name = "Jelly Danish";
        _cost = 4;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetCost()
    {
        return _cost;
    }
    }
}