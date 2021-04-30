using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEquipable
{
    /// <summary>
    /// Method to limit the use of the equipment to characters possessing enough stats to use the items
    /// </summary>
    /// <param name="s"> The stats of the character</param>
    /// <returns> If yes or no, the character can use the equipment </returns>
     bool CanBeEquiped(Stats s);
}

