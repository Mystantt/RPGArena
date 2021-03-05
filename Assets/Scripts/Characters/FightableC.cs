using System;
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
    protected int currentHP;

    /// <summary>
    /// Creates a fightable character from a given lvl
    /// </summary>
    /// <param name="name"> See Character</param>
    /// <param name="description">See Character</param>
    /// <param name="id">See Character</param>
    /// <param name="f">Fighting Class of the character(can't be null)</param>
    /// <param name="l">Level of the character see the Level Class (can't be null)</param>
    /// <param name="s">Stats of the character (can't be null)</param>
    public FightableC(string name, string description, int id,FClass f,Race r,Level l,Stats s) : base(name, description, id)
    {
        
        if(!f.Equals(null) && !l.Equals(null) && !s.Equals(null) && !r.Equals(null))
        {
            Inventory = new Inventory();
            Equipment = new EquipmentSet();
            FClass = f;
            LVL = l;
            Stats = s;
            Race = r;
            currentHP = GetMaxHP();
        }
        else
        {
            throw new System.ArgumentNullException("This fightable character can't be constructed because one of your argument is null");
        }
    }

    public Race Race { get; }

    public Inventory Inventory { get; }

    public EquipmentSet Equipment { get; }

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
    /// <summary>
    /// Returns the maximum HP of the target (depends on the LVL + constitution of the target)
    /// </summary>
    /// <returns> Health points</returns>
    public int GetMaxHP()
    {
        return LVL.LVL * 10 + Stats.ConstiMod() * 10;
    }

    protected void ChangeHP(int modifier)
    {
        if(currentHP + modifier < 0)
        {
            currentHP = 0;
        }else if(currentHP + modifier > GetMaxHP())
        {
            currentHP = GetMaxHP();
        }
        else
        {
            currentHP += modifier;
        }
    }

    /// <summary>
    /// Inflicts dommages to the character
    /// </summary>
    /// <param name="modifier"> Must be positive number to be effective or else it will heal the target</param>
    public void DealHP(int modifier)
    {
        ChangeHP(-modifier);
    }

    /// <summary>
    /// Heals dommages to the character
    /// </summary>
    /// <param name="modifier">Must be positive to be effective or else it will have the opposite effect on the target</param>
    public void HealHP(int modifier)
    {
        ChangeHP(modifier);
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

public enum Race
{
    HUMAN,
    ELF,
    DWARF,
    WURM,
    GOBLIN,
    FIEND,
    ANGEL
}