using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>Inventory</c> which is the implementation of a bag in the game, containing all sorts of items, restricted by a weight capacity
/// Date : 05/03/2021
/// Author : DOMPEY Fabien
/// </summary>
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

    /// <summary>
    /// Add an item to the inventory
    /// </summary>
    /// <param name="i"> The item to add, its weight can't excess the capacity of the inventory (can't be null)</param>
    public void AddItem(Item i)
    {
        if(!i.Equals(null) && WeightUsed + i.Weight <= WeightCapacity)
        {
            WeightUsed += i.Weight;
            items.Add(i);
        }else if (i.Equals(null))
        {
            throw new System.ArgumentNullException("The item can't be null");
        }
        else
        {
            throw new InventoryFullException("This item weighs too much to add to your inventory");
        }
    }

    /// <summary>
    /// Remove an item from the inventory
    /// </summary>
    /// <param name="i"> The item to remove (can't be null)</param>
    public void RemoveItem(Item i)
    {
        if (!i.Equals(null) && items.Contains(i))
        {
            items.Remove(i);
        }
        else if (i.Equals(null))
        {
            throw new System.ArgumentNullException("The item can't be null");
        }
    }

    public List<Item> GetItems()
    {
        return new List<Item>(items);
    }
}
