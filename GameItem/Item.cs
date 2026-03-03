using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

class Item
{
    public string Name;
    public int Price;

    public override string ToString() => $"Name = {Name}, Price = {Price}";
}

class Weapon : Item
{
    public int Damage;

    public override string ToString() => $"Weapon {{ Name = {Name}, Price = {Price}, Damage = {Damage} }} [Weapon]";
}

class Potion : Item
{
    public int HealAmount;

    public override string ToString() => $"Potion {{ Name = {Name}, Price = {Price}, HealAmount = {HealAmount} }} [Potion]";
}

class Inventory
{
    object[] items = new object[10];
    int count = 0;

    public void AddItem(object item)
    {
        items[count++] = item;
    }

    public void ShowInventory()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"슬롯 {i + 1}: {items[i]}");
        }
    }
}