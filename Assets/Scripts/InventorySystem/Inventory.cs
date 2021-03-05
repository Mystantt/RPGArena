using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<Item> items;
    public int WeightCapacity { get; set; }

    public Inventory()
    {
        items = new List<Item>();
        WeightCapacity = 100;
    }
}
