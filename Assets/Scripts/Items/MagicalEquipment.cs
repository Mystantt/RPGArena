using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MagicalEquipment : Item,IEquipable
{
    public EquipmentType Type { get;  }
    protected MagicalEquipment(string name, string description, int value, int weight, int id, Rarity r) : base(name, description, value, weight, id, r)
    {
    }

    public bool CanBeEquiped(Stats s)
    {
        throw new System.NotImplementedException();
    }

    public EquipmentType getPartType()
    {
        return Type;
    }
}
