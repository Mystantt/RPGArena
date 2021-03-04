using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level
{
    public int LVL { get; }

    public int XP { get; }

    public Level()
    {
        LVL = 1;
        XP = 0;
    }

    public Level(int lvl)
    {
        if(lvl >= 1 && lvl <= 100)
        {

        }
        else
        {

        }

    }
}
