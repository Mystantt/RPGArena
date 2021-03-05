using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Class <c>Capacity</c> regrouping all the moves a character can acquire through leveling
/// Date : 05/03/2021
/// Author : DOMPEY Fabien
/// </summary>
[System.Serializable]
public abstract class Capacity
{
    protected int numberOfUses;
    public string Name { get; }

    public string Description { get; }

    public int NbAvailable { get => numberOfUses; }

    public int MaxAllowed { get; }

    public int Range { get; }

    /// <summary>
    /// Constructor of any Move available in the game
    /// </summary>
    /// <param name="name">Name of the Move</param>
    /// <param name="description">Description of it in the journal</param>
    /// <param name="umax"> Number of uses between rests</param>
    /// <param name="range"> Range of squares it can be used on</param>
    public Capacity(string name,string description,int umax,int range)
    {
        if(!name.Equals(null) && !description.Equals(null) && umax > 0 && range > 0)
        {
            Name = name;
            Description = description;
            MaxAllowed = umax;
            numberOfUses = MaxAllowed;
            Range = range;

        }
        else
        {
            throw new System.ArgumentException("Arguments can't be null or negative");
        }
    }

    public virtual void Use(FightableC f)
    {
        numberOfUses--;
        this.Use(f);
    }

}
