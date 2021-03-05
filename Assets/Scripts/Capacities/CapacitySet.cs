using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Capacities available to a class 
/// Date : 05/03/2021
/// Author : DOMPEY Fabien
/// </summary>
public class CapacitySet
{
    private Dictionary<int, List<Capacity>> capSet;
   public CapacitySet()
    {
        capSet = new Dictionary<int, List<Capacity>>();
    }

    public void AddCapacities(int level,List<Capacity> l)
    {
        capSet[level].Concat(l).ToList();
    }

    public void AddCapacity(int level, Capacity c)
    {
        capSet[level].Add(c);
    }

    public List<Capacity> GetCapacitiesFromLevel(int level)
    {
        return capSet[level];
    }

    public List<Capacity> CapacitiesLearned(int level)
    {
        List<Capacity> cap = new List<Capacity>();
        for(int i = 1; i <= level; i++)
        {
            if (!capSet[i].Equals(null))
            {
                cap = cap.Concat(capSet[i]).ToList();
            }
        }
        return cap;
    }
}
