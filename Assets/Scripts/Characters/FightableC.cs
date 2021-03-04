using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>FightableC</c> representing any fightable character in the game
/// Date : 04/03/2021
/// Author : DOMPEY Fabien
/// </summary>
public class FightableC : Character
{
    protected Status s;

    /// <summary>
    /// Creates a fightable character from a given lvl
    /// </summary>
    /// <param name="name"> See Character</param>
    /// <param name="description">See Character</param>
    /// <param name="id">See Character</param>
    /// <param name="f">Fighting Class of the character(can't be null)</param>
    /// <param name="l">Level of the character see the Level Class (can't be null)</param>
    /// <param name="s">Stats of the character (can't be null)</param>
    public FightableC(string name, string description, int id,FClass f,Level l,Stats s) : base(name, description, id)
    {
        
        if(!f.Equals(null) && !l.Equals(null) && !s.Equals(null))
        {
            Inventory = new Inventory();
            Equipment = new Equipment();
            FClass = f;
            LVL = l;
            Stats = s;
        }
        else
        {
            throw new System.ArgumentNullException("This fightable character can't be constructed because one of your argument is null");
        }
    }

    public Inventory Inventory { get; }

    public Equipment Equipment { get; }

    public FClass FClass { get; }

    public Stats Stats { get; }

    public Level LVL { get; }

    public Status Status
    {
        get => s;
        set
        {
            if(!value.Equals(null) && !value.Equals(s))
            {
                s = value;
            }
        }
    }

    public int getMaxHP()
    {
        return 0;
    }
}

/// <summary>
/// Status affecting any fightable character in the game
/// </summary>
public enum Status
{
    BURNED,
    POISONED,
    SLOWED,
    FROZEN,
    GRAPPLED,
    HEALTHY
}
