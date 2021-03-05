using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level
{
    public int LVL { get; private set; }

    public int XP { get; }
    /// <summary>
    /// Level of the player
    /// </summary>
    public Level()
    {
        LVL = 1;
        XP = 0;
    }
    /// <summary>
    /// Level of a creature generated at a given LVL
    /// </summary>
    /// <param name="lvl"> Level of the creature</param>
    public Level(int lvl)
    {
        if(lvl >= 1 && lvl <= 100)
        {
            LVL = lvl;
            XP = (int)(1.25 * (LVL - 1) * (LVL - 1) * (LVL - 1));
        }
        else
        {
            throw new System.ArgumentException("The level must be between 1 and 100");
        }

    }
    /// <summary>
    /// Method indicating if the character can level up and ends up doing so in the process of checking
    /// </summary>
    /// <returns> True if he levels up, false otherwise</returns>
    public bool IsLVLUP()
    {
        if(XP > ((int)(1.25 * LVL * LVL * LVL)))
        {
            LVL += 1;
            return true;
        }
        else
        {
            return false;
        }
    }
}
