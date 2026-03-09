using System;

class Item
{
    public string Name { get; set; }
    public Rarity rarity { get; set; }

    public enum Rarity
    {
        Common = 10,
        UnCommon = 50,
        Rare = 200,
        Epic = 1000,
        Legendary = 5000
    }

    public virtual int GetItemValue()
    {
        return (int)rarity;
    }
}