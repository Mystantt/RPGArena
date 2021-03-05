using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<Item> items;
    public int WeightCapacity { get; set; }
    public int WeightUsed { get; private set; }

    public Inventory()
    {
        items = new List<Item>();
        WeightCapacity = 100;
        WeightUsed = 0;
    }

    public void AddItem(Item i)
    {
        if(WeightUsed + i.Weight <= WeightCapacity)
        {
            WeightUsed += i.Weight;
            items.Add(i);
        }
        else
        {
            throw new InventoryFullException("This item weighs too much to add to your inventory");
        }
    }

    public void RemoveItem(Item i)
    {
        if (items.Contains(i))
        {
            items.Remove(i);
        }
    }

    public List<Item> GetItems()
    {
        return new List<Item>(items);
    }
}
