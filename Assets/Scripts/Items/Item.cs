using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>Item</c> defining every object lootable through the game
/// Date : 05/03/2021
/// Author : DOMPEY Fabien
/// </summary>
public abstract class Item
{
    public string Name { get; }
    public string Description { get; }
    public int Value { get; }
    public int Weight { get; }

    public Item(string name, string description,int value,int weight)
    {
        if(!name.Equals(null) && !description.Equals(null) && value >= 0 && weight >= 0)
        {
            Name = name;
            Description = description;
            Value = value;
            Weight = weight;
        }
        else
        {
            throw new System.ArgumentException("An Item can't be constructed by null arguments or negative integers");
        }
    }

}
