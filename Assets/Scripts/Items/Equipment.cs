using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
/// <summary>
/// Class <c>Equipment</c> defining every equipable object through the game
/// Date : 30/04/2021
/// Author : DOMPEY Fabien
/// </summary>
public abstract class Equipment : Item, IEquipable
{
    public EquipmentType Type { get; }


    public Stats Requirements { get;  }
    protected Equipment(string name, string description, int value, int weight, int id, Rarity r, EquipmentType t,Stats s) : base(name, description, value, weight, id,r)
    {
        if (!t.Equals(null) && !s.Equals(null))
        {
            Type = t;
            Requirements = s;
        }
        else
        {
            throw new System.ArgumentException("An Item can't be constructed by null arguments or negative integers");
        }
    }

    public bool CanBeEquiped(Stats s)
    {
        bool allowed;
        allowed = (s.CompareTo(Requirements) >= 0);
        return allowed;
    }

    public EquipmentType getPartType()
    {
        return Type;
    }
}

public enum EquipmentType
{
    HELMET,
    ARMOR,
    NECKLACE,
    RING,
    PANTS,
    BOOTS,
    SHIELD,
    DUAL_WIELD,
    WEAPON
}
