using System;
using static System.Net.Mime.MediaTypeNames;

class Consumable : Item
{
    public string Effect { get; set; }
    public int Duration { get; set; }

    public override int GetItemValue()
    {
        return base.GetItemValue() + (Duration * 5);
    }
}