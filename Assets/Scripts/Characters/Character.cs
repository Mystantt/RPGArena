using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
/// <summary>
/// Class <c>Character</c> representing the base character of the game
/// </summary>
public abstract class Character
{
    public string Name { get; }
    public string Description { get; }
    public int ID { get; }

    /// <summary>
    /// Constructor of a base character, strings can't be null
    /// </summary>
    /// <param name="name"> name of the character</param>
    /// <param name="description">description of the character in the journal</param>
    /// <param name="id">unique id attributed to the character</param>
    public Character(string name, string description, int id)
    {
        if(!name.Equals(null) && !description.Equals(null))
        {
            this.Name = name;
            this.Description = description;
            this.ID = id;
        }
        else
        {
            throw new System.ArgumentNullException("The name and description can't be null");
        }
    }
}
