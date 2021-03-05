using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Fightable Class
/// Date : 05/03/2021
/// Author : DOMPEY Fabien
/// </summary>
public abstract class FClass
{
    public string Name { get; }
    public string Description { get; }

    public CapacitySet Capacities { get; }

    public FClass(string name, string desc, CapacitySet c)
    {
        if(!c.Equals(null) && !desc.Equals(null) && !c.Equals(null))
        {

            Name = name;
            Description = desc;
            Capacities = c;
        }
        else
        {
            throw new System.ArgumentNullException("Name,Description and Capacity Set can't be null");
        }
    }
}
