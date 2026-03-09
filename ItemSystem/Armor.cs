using System;
using static System.Net.Mime.MediaTypeNames;

class Armor : Item
{
    public int Defense { get; set; }

    enum ArmorType
    {
        Helmet,
        Chest,
        Boots
    }

    public override int GetItemValue()
    {
        return base.GetItemValue() + (Defense * 15);
    }
}