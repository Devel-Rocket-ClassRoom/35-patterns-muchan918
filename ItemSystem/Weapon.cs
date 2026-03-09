using System;

class Weapon : Item
{
    public int Damage { get; set; }

    enum WeaponType
    {
        Sword,
        Bow,
        Staff
    }

    public override int GetItemValue()
    {
        return base.GetItemValue() + (Damage * 10);
    }
}