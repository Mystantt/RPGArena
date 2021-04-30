using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Class <c>EquipmentSet</c> The set of equipment that a character is using in the game
/// Date : 30/04/2021
/// Author : DOMPEY Fabien
/// </summary>
public class EquipmentSet
{
    private IEquipable[] equipment;

    public EquipmentSet()
    {
        equipment = new IEquipable[9];
    }

    public void equip(IEquipable i,FightableC c)
    {
        int index = 0;
        Item it = null;
        if (!i.Equals(null) && !s.Equals(null))
        {
            if(i is Equipment)
            {
                it = i as Equipment;
            }else if (i is MagicalEquipment)
            {
                it = i as MagicalEquipment;
            }
            if (i.CanBeEquiped(c.Stats))
            {
                index = getPosFromPartType(i.getPartType());
            }
            else throw new EquipmentRequirementsNotMetException("You don't meet the requirements needed to use that equipment");
        }
        else throw new System.ArgumentException("Params can't be null");
    }

    private int getPosFromPartType(EquipmentType equipmentType)
    {
        throw new NotImplementedException();
    }
}
