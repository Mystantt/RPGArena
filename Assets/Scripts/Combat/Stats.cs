using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
/// <summary>
/// Stats for every aspect of the game : Fighting and Social Skills for every fightable character
/// Date : 05/03/2021
/// Author : DOMPEY Fabien
/// </summary>
public class Stats : IComparable
{
    private int consti;
    private int dex;
    private int stre;
    private int wisd;
    private int intel;
    private int cha;

    public int Constitution { get => consti; }
    public int Dexterity { get => dex; }
    public int Strength { get => stre; }
    public int Wisdom { get => wisd; }
    public int Intelligence { get => intel; }
    public int Charisma { get => cha; }

    /// <summary>
    /// Constructor used mainly for new players
    /// </summary>
    public Stats()
    {
        this.cha = 0;
        this.dex = 0;
        this.consti = 0;
        this.stre = 0;
        this.intel = 0;
        this.wisd = 0;
    }

    /// <summary>
    /// Constructor mainly used for mobs 
    /// </summary>
    /// <param name="consti">Constitution : HP, Resistances</param>
    /// <param name="stre">Strength : Damage by melee weapons</param>
    /// <param name="dex">Dexterity : Damage by ranged weapons</param>
    /// <param name="wisd">Wisdom : Exp boost for combats and quests</param>
    /// <param name="intel">Intelligence : Damage by spells</param>
    /// <param name="cha">Charisma : Social skills for quests</param>
    public Stats(int consti,int stre,int dex,int wisd,int intel,int cha)
    {
        if(consti >= 0 && consti <= 100 && stre >= 0 && stre <= 100 && dex >= 0 && dex <= 100 && wisd >= 0 && wisd <= 100 && intel >= 0 && 
            intel <= 100 && cha >= 0 && cha <= 100)
        {
            this.consti = consti;
            this.dex = dex;
            this.cha = cha;
            this.stre = stre;
            this.intel = intel;
            this.wisd = wisd;
        }
    }

    public void AddDex(int modifier)
    {
        if(modifier >= 0 && dex + modifier < 100)
        {
            dex += modifier;
        }
        else
        {
            throw new System.ArgumentException("Your Dexterity can't be removed or over 100");
        }
    }
    public void AddStr(int modifier)
    {
        if (modifier >= 0 && stre + modifier < 100)
        {
            stre += modifier;
        }
        else
        {
            throw new System.ArgumentException("Your Strength can't be removed or over 100");
        }
    }
    public void AddCha(int modifier)
    {
        if (modifier >= 0 && cha + modifier < 100)
        {
            cha += modifier;
        }
        else
        {
            throw new System.ArgumentException("Your Charisma can't be removed or over 100");
        }
    }
    public void AddWisd(int modifier)
    {
        if (modifier >= 0 && wisd + modifier < 100)
        {
            wisd += modifier;
        }
        else
        {
            throw new System.ArgumentException("Your Wisdom can't be removed or over 100");
        }
    }
    public void AddIntel(int modifier)
    {
        if (modifier >= 0 && intel + modifier < 100)
        {
            intel += modifier;
        }
        else
        {
            throw new System.ArgumentException("Your Intelligence can't be removed or over 100");
        }
    }
    public void AddConsti(int modifier)
    {
        if (modifier >= 0 && consti + modifier < 100)
        {
            consti += modifier;
        }
        else
        {
            throw new System.ArgumentException("Your Constitution can't be removed or over 100");
        }
    }

    public int DexMod() => dex / 2;
    public int StrMod() => stre / 2;
    public int WisdMod() => wisd / 2;
    public int IntelMod() => intel / 2;
    public int ChaMod() => cha / 2;
    public int ConstiMod() => consti / 2;

    /// <summary>
    /// Compare two stats from characters or equipments
    /// </summary>
    /// <param name="obj"> A character or an equipment stats</param>
    /// <returns> Zero if they are the same, superior to Zero if this instance of Stats is strictly superior , inferior to Zero otherwise </returns>
    public int CompareTo(object obj)
    {
        int result = 1;
        if (obj == null) return result;
        Stats s = obj as Stats;
        if (s != null)
        {
            result = this.cha.CompareTo(s.Charisma) + this.consti.CompareTo(s.Constitution) + this.dex.CompareTo(s.Dexterity) +
                this.intel.CompareTo(s.Intelligence) + this.stre.CompareTo(s.Strength) + this.wisd.CompareTo(s.Wisdom);
            return result;
        }
        else
        {
            throw new System.ArgumentException("Can't compare those objects");
        }
    }
}
