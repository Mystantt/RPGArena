using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : Item, IEquipable
{
    protected Equipment(string name, string description, int value, int weight, int id) : base(name, description, value, weight, id)
    {
    }

    public abstract bool CanBeEquiped(Stats s);
}
