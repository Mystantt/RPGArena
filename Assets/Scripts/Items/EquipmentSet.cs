using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSet : MonoBehaviour
{
    private IEquipable[] equip;

    public EquipmentSet()
    {
        equip = new IEquipable[9];
    }
}
